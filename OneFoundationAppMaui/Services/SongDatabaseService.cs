using OneFoundationAppMaui.Models;
using SQLite;

namespace SongListApp.Maui.Services
{
    public class SongDatabaseService
    {
        SQLiteConnection conn;
        string _dbPath;
        public string StatusMessage;
        int result = 0;
        public SongDatabaseService(string dbPath)
        {
            _dbPath = dbPath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Song>();
        }

        public List<Song> GetSongs()
        {
            try
            {
                Init();
                return conn.Table<Song>().ToList();
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return new List<Song>();
        }

        public Song GetSong(int id)
        {
            try
            {
                Init();
                return conn.Table<Song>().FirstOrDefault(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return null;
        }

        public int DeleteSong(int id)
        {
            try
            {
                Init();
                return conn.Table<Song>().Delete(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to delete data.";
            }

            return 0;
        }

        public void AddSong(Song song)
        {
            try
            {
                Init();

                if (song == null)
                    throw new Exception("Invalid Song Record");

                result = conn.Insert(song);
                StatusMessage = result == 0 ? "Insert Failed" : "Insert Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to Insert data.";
            }
        }

        public void UpdateSong(Song song)
        {
            try
            {
                Init();

                if (song == null)
                    throw new Exception("Invalid Song Record");

                result = conn.Update(song);
                StatusMessage = result == 0 ? "Update Failed" : "Update Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to Update data.";
            }
        }
    }
}
