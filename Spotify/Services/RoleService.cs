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
    internal class RoleService : IService<Role>
    {
        public void Add(Role model)
        {
            Sql.ExecCommand($"INSERT INTO Roles (Type) VALUES (N'{model.Type}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE FROM Roles WHERE Id ={id}");
        }

        public List<Role> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Roles");
            List<Role> roles = new List<Role>();
            foreach (DataRow dr in dt.Rows)
            {
                roles.Add(new Role { Id = Convert.ToInt32(dr["Id"]), Type = dr["Type"].ToString()});
            }
            return roles;
        }
        public Role GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT * FROM Roles WHERE Id={Id}");
            DataRow dr = dt.Rows[0];
            Role role = new Role()
            {
                Id = Convert.ToInt32(dr["Id"]),
                Type = dr["Type"].ToString(),
            };
            return role;
        }
        public void Update(Role model)
        {
            Sql.ExecCommand($"UPDATE Roles SET Type=N'{model.Type}' WHERE Id={model.Id}");
        }
    }
}
