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
    internal class UserService : IService<User>
    {
        public void Add(User model)
        {
            Sql.ExecCommand($"INSERT INTO Users (Name,Surname,Username,Password,Gender,RoleId) VALUES (N'{model.Name}',N'{model.Surname}',N'{model.Username}','{model.Password}',N'{model.Gender}',{model.RoleId})");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE FROM Users WHERE Id ={id}");
        }
        public List<User> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Users");
            List<User> users = new List<User>();
            foreach (DataRow dr in dt.Rows)
            {
                users.Add(new User { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Surname = dr["Surname"].ToString(), Username = dr["Username"].ToString(), Password = (dr["Password"]).ToString(), Gender = dr["Gender"].ToString() , RoleId= Convert.ToInt32(dr["RoleId"])});
            }
            return users;
        }
        public User GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT * FROM Users WHERE Id={Id}");
            DataRow dr = dt.Rows[0];
            User users = new User()
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString(),
                Surname = dr["Surname"].ToString(),
                Username = dr["Username"].ToString(),
                Password = dr["Password"].ToString(),
                Gender = dr["Gender"].ToString(),
                RoleId = Convert.ToInt32(dr["RoleId"])
            };
            return users;
        }
        public void Update(User model)
        {
            Sql.ExecCommand($"UPDATE Users SET Name=N'{model.Name}',Surname=N'{model.Surname}',Username=N'{model.Username}',Password='{model.Password}',Gender='{model.Gender}',RoleId={model.RoleId} WHERE Id={model.Id}");
        }
    }
}
