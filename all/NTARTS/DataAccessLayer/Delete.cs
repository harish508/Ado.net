using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
   public class Delete
    {
        public string connstring = "Data Source=192.168.50.95;Initial Catalog=hbadugula;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        public void EmpDelete()
        {
            using(SqlConnection sqlConnection=new SqlConnection(connstring))
            {
                using(SqlCommand sqlCommand=new SqlCommand("delete Employee where Empname=@Empname",sqlConnection))
                {
                    Console.WriteLine("Enter Empname");
                    string Empname = Console.ReadLine();
                    sqlCommand.Parameters.AddWithValue("@Empname", Empname);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }
    }
}
