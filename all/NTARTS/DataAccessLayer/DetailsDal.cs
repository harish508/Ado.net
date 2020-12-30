using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
   public class DetailsDal
    {
      public string connectionstring = "Data Source=192.168.50.95;Initial Catalog=hbadugula;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        public DataTable GetDetails(int Empid)
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection connection=new SqlConnection(connectionstring))
            {
                string sql = "select * from Details11dec where Empid=@Empid";
                using(SqlCommand command=new SqlCommand(sql,connection))
                {
                    command.Parameters.AddWithValue("@Empid", Empid);
                    using(SqlDataAdapter adapter=new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}
