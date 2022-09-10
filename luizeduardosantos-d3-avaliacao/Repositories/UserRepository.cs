using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using luizeduardosantos_d3_avaliacao.Models;
using luizeduardosantos_d3_avaliacao.Repositories;


namespace luizeduardosantos_d3_avaliacao.Repositories
{
    internal class UserRepository
    {
        public static string dbPassword;
        private static string stringConexao = "Server=labsoft.pcs.usp.br; Initial Catalog=db_16; User id=usuario_16; pwd=";
        //private readonly string stringConexao = "Data source=MP\\SQLEXPRESS; Initial Catalog=Catalog; integrated security=true;";
        private static List<User> ReadAll()
        {
            List<User> listUsers = new();

            using (SqlConnection con = new SqlConnection(stringConexao+dbPassword))
            {
                string querySelect = "SELECT * FROM Users";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        User user = new()
                        {
                            Id = rdr[0].ToString(),
                            Name = rdr[1].ToString(),
                            Email = rdr[2].ToString(),
                            Password = rdr[3].ToString()
                        };

                        listUsers.Add(user);
                    }
                }
            }

            return listUsers;
        }

        public static bool LookUp (string email, string password)
        {
            List<User> listUsers = ReadAll();

            foreach(User user in listUsers)
            {
              
                if (user.Email == email && user.Password == password)
                {
                    LogRepository.LogAccess(user.Name, user.Id);
                    return true;
                }
            }
            return false;
        }


    }
}
