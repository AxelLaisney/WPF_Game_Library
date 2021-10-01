using LibraryGame.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LibraryGame.Repositories
{
    public class GameRepository
    {
        public List<Game> gameRepository { get; set; }

        public GameRepository()
        {
            gameRepository = GetGames();
        }

        public List<Game> GetGames()
        {
            List<Game> listGames = new List<Game>();
            using (SqliteConnection conn = new SqliteConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is null");
                }

                SqliteCommand query = new SqliteCommand("SELECT * FROM Games", conn);
                conn.Open();
                SqliteDataReader data = query.ExecuteReader();

                while (data.Read())
                {
                    Game game = new Game();
                    game.Id = int.Parse(data["Id"].ToString());
                    game.Title = data["Title"].ToString();
                    game.Genre = data["Genre"].ToString();
                    game.Publisher = data["Publisher"].ToString();
                    game.ReleaseDate = data.GetDateTime(4);
                    listGames.Add(game);
                }
                return listGames;
            }
        }

        public void DeleteRecordDB(int id)
        {
            using (SqliteConnection conn = new SqliteConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception ("Connection String is null");
                }

                conn.Open();
                SqliteCommand query = new SqliteCommand("DELETE FROM Games WHERE Id = $id", conn);
                query.Parameters.AddWithValue("$id", id);
                query.ExecuteNonQuery();
            }
        }

        public void AddRecordDB(Game game)
        {
            using (SqliteConnection conn = new SqliteConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is null");
                }

                conn.Open();
                SqliteCommand query = new SqliteCommand("INSERT INTO Games (Title, Genre, Publisher, ReleaseDate) VALUES ($title, $genre, $publisher, $date)", conn);
                query.Parameters.AddWithValue("$title", game.Title);
                query.Parameters.AddWithValue("$genre", game.Genre);
                query.Parameters.AddWithValue("$publisher", game.Publisher);
                query.Parameters.AddWithValue("$date", game.ReleaseDate.ToString("yyyy-MM-dd"));
                query.ExecuteNonQuery();
            }
        }
    }
}
