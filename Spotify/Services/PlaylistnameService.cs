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
    internal class PlaylistnameService : IService<Playlistname>
    {
        public void Add(Playlistname model)
        {
            Sql.ExecCommand($"INSERT INTO Playlistnames (Name,UserId) VALUES(N'{model.Name}',{model.UserId})");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"Delete Playlistnames Where Id = {id}");
        }
        public List<Playlistname> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Playlistnames");
            List<Playlistname> playlistnames = new List<Playlistname>();
            foreach (DataRow dr in dt.Rows)
            {
                playlistnames.Add(new Playlistname { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), UserId = Convert.ToInt32(dr["UserId"]) });
            }
            return playlistnames;
        }
        public Playlistname GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT * FROM Playlistnames WHERE Id={Id}");
            DataRow dr = dt.Rows[0];
            Playlistname playlistname = new Playlistname()
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString(),
                UserId = Convert.ToInt32(dr["UserId"])
            };
            return playlistname;
        }
        public void Update(Playlistname model)
        {
            Sql.ExecCommand($"UPDATE Playlistnames SET Name=N'{model.Name}',UserId={model.UserId} WHERE Id={model.Id}");
        }
    }
}
