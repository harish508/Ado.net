using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class EmployeeDal
    {
        public string connectionstring = "Data Source=192.168.50.95;Initial Catalog=hbadugula;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        public DataTable GetEmployee(int Empid)
        {
            DataTable dataTable1 = new DataTable();
            using(SqlConnection connection=new SqlConnection(connectionstring))
            {
                string sql = "select * from Employee where Empid=@Empid";
                using(SqlCommand command=new SqlCommand(sql,connection))
                {
                    command.Parameters.AddWithValue("@Empid", Empid);
                    using (SqlDataAdapter adapter=new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable1);
                    }
                }
            }
            return dataTable1;
        }
    }
}
