﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClassAccess : DatabaseAccess
    {
        // Kế thừa từ class DatabaseAccess
        // Class MG Logic
        // Lấy danh sách lớp theo ngành
        public Response getListClass(string majorID)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getListClass", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@majorid", majorID);
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
        // Kết thúc lấy danh sách lớp
        // Thêm lớp mới vào CSDL
        public Response addClassToDB(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("addClassToDB", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@classid", req.GetData("ClassID"));
                command.Parameters.AddWithValue("@classname", req.GetData("ClassName"));
                command.Parameters.AddWithValue("@majorid", req.GetData("MajorID"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                {
                    res.code = "class_exist";
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
        // Kết thúc thêm lớp mới
        // Xoá một lớp khỏi CSDL
        public Response DeleteClass(Request request)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("DeleteClass", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@classid", request.GetData("ClassID"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                    res.code = "class_not_exist";
                else
                    res.code = "delete_successfully";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
    }
}
