using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class Update
    {
        public string connstring = "Data Source=192.168.50.95;Initial Catalog=hbadugula;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        public void EmpUpdate()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                using (SqlCommand sqlCommand = new SqlCommand("update EMPLOYEE set Empname=@Empname,Emplocation=@Emplocation,Empgender=@Empgender,Empphno=@Empphno,Empsalary=@Empsalary where Empid= 18 ", sqlConnection))
                {
                    Console.WriteLine("Enter Empname");
                    string Empname = Console.ReadLine();
                    Console.WriteLine("Enter Emplocation");
                    string Emplocation = Console.ReadLine();
                    Console.WriteLine("Enter Empgender");
                    string Empgender = Console.ReadLine();
                    Console.WriteLine("Enter Empphno");
                    string Empphno = Console.ReadLine();
                    Console.WriteLine("Enter Empsalary");
                    Decimal Empsalary = Convert.ToDecimal(Console.ReadLine());
                 
                    sqlCommand.Parameters.AddWithValue("@Empname", Empname);
                    sqlCommand.Parameters.AddWithValue("@Emplocation", Emplocation);
                    sqlCommand.Parameters.AddWithValue("@Empgender", Empgender);
                    sqlCommand.Parameters.AddWithValue("@Empphno", Empphno);
                    sqlCommand.Parameters.AddWithValue("@Empsalary", Empsalary);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }
    }
}
