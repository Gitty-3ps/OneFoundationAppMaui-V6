
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace OneFoundationAppMaui.Api_v2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", a => a.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            });
            var dbPath = Path.Join(Directory.GetCurrentDirectory(), "songlist.db");
            var conn = new SqliteConnection($"Data Source={dbPath}");
            builder.Services.AddDbContext<SongListDbContext>(o => o.UseSqlite(conn));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");
            //app.UseAuthorization();  

            app.MapGet("/songs", async (SongListDbContext db) => await db.Songs.ToListAsync());

            app.MapGet("/songs/{id}", async (int id, SongListDbContext db) =>
            await db.Songs.FindAsync(id) is Song song ? Results.Ok(song) : Results.NotFound()
            );

            app.MapPut("/songs/{id}", async (int id, Song song, SongListDbContext db) =>
            {
                var record = await db.Songs.FindAsync(id);
                if (record != null) return Results.NotFound();

                song.Title = record.Title;
                song.Authors = record.Authors;
                song.Lyrics = record.Lyrics;

                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            app.MapDelete("/songs/{id}", async (int id, SongListDbContext db) =>
            {
                var record = await db.Songs.FindAsync(id);
                if (record != null) return Results.NotFound();

                db.Remove(record);

                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            app.MapPost("/songs/{id}", async (int id, Song song, SongListDbContext db) =>
            {
                await db.AddAsync(song);
                await db.SaveChangesAsync();

                return Results.Created($"/songs/{song.Id}", song);
            });

            app.Run();
        }
    }
}