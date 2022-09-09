using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using luizeduardosantos_d3_avaliacao.Models;

namespace luizeduardosantos_d3_avaliacao.Repositories
{
    internal class UserRepository
    {
        private readonly string stringConexao = "Server=labsoft.pcs.usp.br; Initial Catalog=db16; User id=usuario_16; pwd=;";
        //private readonly string stringConexao = "Data source=MP\\SQLEXPRESS; Initial Catalog=Catalog; integrated security=true;";
        private static List<User> ReadAll()
        {
            List<User> listUsers = new();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT * FROM Products";

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
                    return true;
                }
            }
            return false;
        }


    }
}
