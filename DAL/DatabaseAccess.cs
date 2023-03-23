﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using COM;
using System.Data;
using System.Security.AccessControl;

// DATA ACCESS LAYER
namespace DAL
{
    public class Response
    {
        public string code;
        public string permissionType;
        public string userFullName;
        public string userImage;
        public DataTable data = new DataTable();

    }
    // Handle data access
    public class DatabaseAccess
    {
        // Create connection string
        public static SqlConnection Connection() {
            string connectString = @"Data Source=188.166.205.125;Database=StudentMG;Integrated Security=false;User ID=sa;Password=Tuandev2002@;TrustServerCertificate=true;";
            SqlConnection connection = new SqlConnection(connectString);
            return connection;
        }

        public Response hanndleLogin(Request loginReq)
        {
        // Connect to database
            Response res = new Response();
            UserAccount account = new UserAccount();
            account.userName = loginReq.GetData("userName");
            account.userPassword = loginReq.GetData("password");
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
                        res.userFullName = reader.GetString(0);
                        res.permissionType = reader.GetString(1);
                        res.userImage = reader.GetString(2);
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
        public Response getListUser()
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getListUser", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                res.code = "success";
                res.data.Load(reader);
                reader.Close();
                section.Close();
            }
            catch (Exception ex)
            {
                res.code = "server_error";
            }
            return res; 
        }
        public Response getPermissionList ()
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getPermissionList", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                res.code = "success";
                res.data.Load(reader);
                reader.Close();
                section.Close();
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        public Response addUserToDB(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("addUserToDB", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", req.GetData("userName"));
                command.Parameters.AddWithValue("@password", req.GetData("password"));
                command.Parameters.AddWithValue("@fullname", req.GetData("fullName"));
                command.Parameters.AddWithValue("@email", req.GetData("email"));
                command.Parameters.AddWithValue("@permissiontype", Int32.Parse(req.GetData("permissionType")));
                command.Parameters.AddWithValue("@avatar", req.GetData("avatar"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                {
                    res.code = "user_exist";
                }
                else
                {
                    res.code = "success";
                }
            }

            catch
            {
                res.code = "server_error";
            }
            return res; 
        }
        public Response getUserData(string userName)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getUserData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", userName);
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                res.code = "success";
                res.data.Load(reader);
                reader.Close();
                section.Close();
           
            }
            catch (Exception ex)
            {
               res.code = "server_error";
            }
            return res; 
        }
    }
}
