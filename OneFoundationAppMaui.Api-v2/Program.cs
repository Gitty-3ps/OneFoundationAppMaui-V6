using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OneFoundationAppMaui.Api_v2;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => {
    o.AddPolicy("AllowAll", a => a.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});

var dbPath = Path.Join(Directory.GetCurrentDirectory(), "songlist.db");
var conn = new SqliteConnection($"Data Source=C:\\songlistdb\\songlist.db");
builder.Services.AddDbContext<SongListDbContext>(o => o.UseSqlite(conn));

builder.Host.UseSerilog((ctx, lc) =>
    lc.WriteTo.Console()
    .ReadFrom.Configuration(ctx.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
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

app.Run();