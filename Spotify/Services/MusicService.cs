using Spotify.Abstraction;
using Spotify.Helper;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Spotify.Services
{
    internal class MusicService : IService<Music>
    {
        public void Add(Music model)
        {
            Sql.ExecCommand($"INSERT INTO Musics (Name,Duration,CategoryId) VALUES(N'{model.Name}','{model.Duration}' ,{model.CategoryId})");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"Delete FROM Musics WHERE Id = {id}");
        }
        public List<Music> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Musics");
            List<Music> musics = new List<Music>();
            foreach (DataRow dr in dt.Rows)
            {
                musics.Add(new Music { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Duration = TimeSpan.Parse((dr["Duration"].ToString())), CategoryId = Convert.ToInt32(dr["CategoryId"]) });
            }
            return musics;
        }
        public Music GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT * FROM Musics WHERE Id={Id}");
            DataRow dr = dt.Rows[0];
            Music music = new Music()
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString(),
                Duration = TimeSpan.Parse(dr["Duration"].ToString()),
                CategoryId = Convert.ToInt32(dr["CategoryId"])
            };
            return music;
        }
        public void Update(Music model)
        {
            Sql.ExecCommand($"UPDATE Musics SET Name=N'{model.Name}',Duration='{model.Duration}',CategoryId={model.CategoryId} WHERE Id={model.Id}");
        }
    }
}
