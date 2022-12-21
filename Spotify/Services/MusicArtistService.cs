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
    internal class MusicArtistService : IService<MusicArtist>
    {
        public void Add(MusicArtist model)
        {
            Sql.ExecCommand($"INSERT INTO MusicArtists (MusicId,ArtistId) VALUES (${model.MusicId},{model.ArtistId}");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE FROM MusicArtists WHERE Id ={id}");
        }
        public List<MusicArtist> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM MusicArtists");
            List<MusicArtist> musicArtist = new List<MusicArtist>();
            foreach (DataRow dr in dt.Rows)
            {
                musicArtist.Add(new MusicArtist { Id = Convert.ToInt32(dr["Id"]), MusicId = Convert.ToInt32(dr["MusicId"]), ArtistId = Convert.ToInt32(dr["ArtistId"]) });
            }
            return musicArtist;
        }
        public MusicArtist GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT * FROM MusicArtists WHERE Id={Id}");
            DataRow dr = dt.Rows[0];
            MusicArtist artist = new MusicArtist()
            {
                Id = Convert.ToInt32(dr["Id"]),
                MusicId = Convert.ToInt32(dr["MusicId"]),
                ArtistId = Convert.ToInt32(dr["ArtistId"])
            };
            return artist;
        }
        public void Update(MusicArtist model)
        {
            Sql.ExecCommand($"UPDATE MusicArtists SET MusicId={model.MusicId},ArtistId={model.ArtistId}, WHERE Id={model.Id}");
        }
    }
}
