using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OneFoundationAppMaui.Api_v2;
using Serilog;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => {
    o.AddPolicy("AllowAll", a => a.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});

//var dbPath = Path.Join(Directory.GetCurrentDirectory(), "songlist.db");
var conn = new SqliteConnection($"Data Source=C:\\songlistdb\\songlist.db");
builder.Services.AddDbContext<SongListDbContext>(o => o.UseSqlite(conn));

builder.Services.AddIdentityCore<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<SongListDbContext>();

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options => {
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration
        ["JwtSettings:Key"]))
    };
});

builder.Services.AddAuthorization(options =>
{ 
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
    .RequireAuthenticatedUser()
    .Build();
});

builder.Host.UseSerilog((ctx, lc) =>
    lc.WriteTo.Console()
    .ReadFrom.Configuration(ctx.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors("AllowAll");

app.MapGet("/songs", async (SongListDbContext db) => await db.Songs.ToListAsync());

app.MapGet("/songs/{id}", async (int id, SongListDbContext db) =>
    await db.Songs.FindAsync(id) is Song song ? Results.Ok(song) : Results.NotFound()
);

app.MapPut("/songs/{id}", async (int id, Song song, SongListDbContext db) => {
    var record = await db.Songs.FindAsync(id);
    if (record is null) return Results.NotFound();

    record.Title = song.Title;
    record.Authors = song.Authors;
    record.Lyrics = song.Lyrics;

    await db.SaveChangesAsync();

    return Results.NoContent();

});

app.MapDelete("/songs/{id}", async (int id, SongListDbContext db) => {
    var record = await db.Songs.FindAsync(id);
    if (record is null) return Results.NotFound();
    db.Remove(record);
    await db.SaveChangesAsync();

    return Results.NoContent();

});

app.MapPost("/songs", async (Song song, SongListDbContext db) => {
    await db.AddAsync(song);
    await db.SaveChangesAsync();

    return Results.Created($"/songs/{song.Id}", song);

});

app.MapPost("/login", async (LoginDto loginDto, UserManager<IdentityUser> _userManager) =>
{
    var user = await _userManager.FindByNameAsync(loginDto.Username);

    if (user is null)
    {
        return Results.Unauthorized();
    }

    var isValidPassword = await _userManager.CheckPasswordAsync(user, loginDto.Password);

    if (!isValidPassword)
    {
        return Results.Unauthorized();
    }

    // Generate an access token

    var response = new AuthResponseDto
    {
        UserId = user.Id,
        Username = user.UserName,
        Token = "AccessTokenHere"
    };

    return Results.Ok(response);
}).AllowAnonymous();

app.Run();

internal class LoginDto
{
    public string Username { get; set; }
    public string Password { get; set; }
}

internal class AuthResponseDto
{
    public string UserId { get; set; }
    public string Username { get; set; }
    public string Token { get; set; }
}