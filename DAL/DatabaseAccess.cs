using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

// DATA ACCESS LAYER
namespace DAL
{
    public class Response
    {
        public string code;
        public int permission;

    }
    // Handle data access
    public class DatabaseAccess
    {
        // Create connection string
        public static SqlConnection Connection() {
            string connectString = @"Server=35.185.176.142,1433;Initial Catalog=StudentMG;Persist Security Info=False;User ID=sqlserver;Password=tuan2002;Connection Timeout=10;";
            SqlConnection connection = new SqlConnection(connectString);
            return connection;
        }

        public static Response hanndleLogin(UserAccount account)
        {
        // Connect to database
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("handleLoginProduce", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", account.userName);
                command.Parameters.AddWithValue("@password", account.userPassword);

                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read())
                    {
                        res.code = "success";
                        res.permission = reader.GetInt32(3);
                    }
                    reader.Close();
                    section.Close();
                }
                else
                {
                    res.code = "user_not_exsist";
                }
            }    
            catch(Exception ex)
            {
                res.code = "server_error";
            }
            return res;
        }
    }
}
