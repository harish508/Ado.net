
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LINQ
{
   public class Program
    {
        static string conn= "Data Source = 192.168.50.95; Initial Catalog = hbadugula; Integrated Security = True; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False"; 
        static void Main(string[] args)
        {
            Console.WriteLine("linq Example");
            var Emp = GetDetails();
            var data = Emp.Where(d => d.Empname.StartsWith('M'));
            foreach (var item in data)
            {
                Console.WriteLine(item.Empname);
            }
            //foreach (var item in Emp)
            //{
            //    Console.WriteLine(item.Empname+" "+item.Emplocation+" "+item.Empsalary);
            //}
            
        }

        private static IList<Employee> GetDetails()
        {
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("select * from Employee",connection);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            IList<Employee> Employe = new List<Employee>();
             foreach (DataRow row in table.Rows)
            {
                var emplo = new Employee()
                {
                    Empid = int.Parse(row["Empid"].ToString()),
                    Empname = row["Empname"].ToString(),
                    Emplocation=row["Emplocation"].ToString(),
                    Empgender=row["Empgender"].ToString(),
                    Empphno=row["Empphno"].ToString(),
                    Empsalary=Convert.ToDecimal(row["Empsalary"])
                };
                Employe.Add(emplo);
            }
            return Employe;

        }
    }
}
