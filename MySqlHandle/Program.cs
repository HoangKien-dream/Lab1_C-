using System;
using MySql.Data.MySqlClient;

namespace MySqlHandle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cnn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=t2012e_csharp;SslMode=None;");
            cnn.Open();
              var command = new MySqlCommand("insert into student(name, email) values ('Thanh Mai','thanhmai@gmail.com') ", cnn);
               command.ExecuteNonQuery();
              var select = new MySqlCommand("select * from student", cnn);
              MySqlDataReader mySqlDataReader = select.ExecuteReader();
              while (mySqlDataReader.Read())
              {
                  
                      int id = mySqlDataReader.GetInt32("id");
                      string name = mySqlDataReader.GetString("name");
                      string email = mySqlDataReader.GetString("email");
                      int status = mySqlDataReader.GetInt32("status");
                      Console.WriteLine(" ID: {0} , Name {1}: , Email: {2}, status: {3}", id,name,email,status);
                  
              } 
              cnn.Close(); ;
        }
    }
}