﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class dataProvider
    {
        private static dataProvider instance; // tạo 1 lần duy nhất {{(crtl +R+E): dóng gói}}
        public static dataProvider Instance
        {
            get { if (instance == null) instance = new dataProvider(); return dataProvider.instance; }
            private set {dataProvider.instance = value; }
        }
        private string connectionSTR = "Data Source=DESKTOP-MN8CCI0;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        // truy xuất dữ liệu
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();  
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string [] listPara = query.Split(' ');
                    int i = 0;
                    foreach ( string item in listPara )
                    {
                        if ( item.Contains("@") ) 
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        // Đếm số lượng thành công
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();   
                connection.Close();
            }
            return data;
        }
        // Đếm số lượng trả lại 
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
