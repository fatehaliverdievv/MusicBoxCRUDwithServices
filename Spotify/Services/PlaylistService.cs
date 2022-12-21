using Spotify.Abstraction;
using Spotify.Helper;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Services
{
    internal class PlaylistService : IService<Playlist>
    {
        public void Add(Playlist model)
        {
            Sql.ExecCommand($"INSERT INTO Playlists (NameId,MusicId) VALUES ({model.NameId},{model.MusicId})");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE FROM Playlists WHERE Id ={id}");
        }
        public List<Playlist> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Playlists");
            List<Playlist> playlists = new List<Playlist>();
            foreach (DataRow dr in dt.Rows)
            {
                playlists.Add(new Playlist { Id = Convert.ToInt32(dr["Id"]), NameId = Convert.ToInt32(dr["NameId"]), MusicId = Convert.ToInt32(dr["MusicId"])});
            }
            return playlists;
        }
        public Playlist GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT * FROM Playlists WHERE Id={Id}");
            DataRow dr = dt.Rows[0];
            Playlist playlist = new Playlist()
            {
                Id = Convert.ToInt32(dr["Id"]),
                NameId = Convert.ToInt32(dr["NameId"]),
                MusicId = Convert.ToInt32(dr["MusicId"]),
            };
            return playlist;
        }
        public void Update(Playlist model)
        {
            Sql.ExecCommand($"UPDATE Playlists SET NameId={model.NameId},MusicId={model.MusicId} WHERE Id={model.Id}");
        }
    }
}
