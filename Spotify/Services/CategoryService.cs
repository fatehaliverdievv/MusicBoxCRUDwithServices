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
    internal class CategoryService : IService<Category>
    {
        public void Add(Category model)
        {
            Sql.ExecCommand($"INSERT INTO Categories (Name) VALUES (N'{model.Name}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE FROM Categories WHERE Id ={id}");
        }

        public List<Category> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Categories");
            List<Category> categories = new List<Category>();
            foreach (DataRow dr in dt.Rows)
            {
                categories.Add(new Category { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString() });
            }
            return categories;
        }
        public Category GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT * FROM Categories WHERE Id={Id}");
            DataRow dr = dt.Rows[0];
            Category category = new Category()
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString(),
            };
            return category;

        }
        public void Update(Category model)
        {
            Sql.ExecCommand($"UPDATE Categories SET Name=N'{model.Name}' WHERE Id={model.Id}");
        }
    }
}
