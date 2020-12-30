using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADO.NET
{
    public class list_printing
    {
        public string connstring = "Data Source=192.168.50.95;Initial Catalog=hbadugula;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        
        
        
        public void list()
        {
            Console.WriteLine("Enter Employee Id ");
            var Empid = Console.ReadLine();
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Employee where Empid=@Empid", connection);
            SqlDataAdapter ad = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            try {
                connection.Open();
                sqlCommand.Parameters.AddWithValue("@Empid", Empid);
                ad.Fill(table);
        
                connection.Close();
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(row["Empid"]+" "+row["Empname"]);
                }
                }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }
         }

        public void listwithsp()
        {
            Console.WriteLine("Enter Empid");
            var Empid = int.Parse(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(connstring);
            SqlCommand sqlCommand = new SqlCommand("usp_Emp",sqlConnection);
            SqlDataAdapter ad = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Empid", Empid);
                sqlCommand.CommandType =CommandType.StoredProcedure;
                ad.Fill(table);
                sqlConnection.Close();
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(row["Emplocation"]+" "+row["Empsalary"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);  
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                table.Dispose();
                ad.Dispose();
            }
        }
        //----------------------------------------------------------------------------------------------------

        public void insert()
        {
            
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("Insert into Employee(Empname,Empgender,Empsalary)values(@Empname,@Empgender,@Empsalary)", connection);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                Console.WriteLine("Enter Empname");
                string Empname = Console.ReadLine();
                cmd.Parameters.AddWithValue("@Empname", Empname);
                Console.WriteLine("Enter Empgender");
                string Empgender = Console.ReadLine();
                cmd.Parameters.AddWithValue("@Empgender", Empgender);
                Console.WriteLine("Enter Empsalary");
                decimal Empsalary =Convert.ToDecimal(Console.ReadLine());
                cmd.Parameters.AddWithValue("@Empsalary", Empsalary);

                ad.Fill(table);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                table.Dispose();
                ad.Dispose();
            }
        }

        public void insertwithsp()
        {

            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("usp_Emp", connection);
            try
            {
                connection.Open();
                Console.WriteLine("Enter Empname");
                string Empname = Console.ReadLine();
                cmd.Parameters.AddWithValue("@Empname", Empname);
                Console.WriteLine("Enter Emplocation");
                string Emplocation = Console.ReadLine();
                cmd.Parameters.AddWithValue("@Emplocation", Emplocation);
                Console.WriteLine("Enter Empphno");
                string Empphno =Console.ReadLine();
                cmd.Parameters.AddWithValue("@Empphno", Empphno);
                Console.WriteLine("Enter Empsalary");
                Decimal Empsalary = Convert.ToDecimal(Console.ReadLine());
                cmd.Parameters.AddWithValue("@Empsalary", Empsalary);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        //--------------------------------------------------------------------------------------------------------
        public void update()
        {
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("Update Employee set Empgender=@Empgender where Empid=@Empid",connection);
            try
            {
                connection.Open();
                Console.WriteLine("Enter Empid");
                int Empid = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@Empid", Empid);
                Console.WriteLine("Enter Emp gender");
                string Empgender = Console.ReadLine();
                cmd.Parameters.AddWithValue("@Empgender", Empgender);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public void updatewithsp()
        {
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("usp_Emp", connection);
            try
            {
                connection.Open();
                Console.WriteLine("Enter Empid");
                int Empid = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@Empid", Empid);
                Console.WriteLine("Enter Emp gender");
                string Empgender = Console.ReadLine();
                cmd.Parameters.AddWithValue("@Empgender", Empgender);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        public void delete()
        {
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("delete Employee where Empid=@Empid",connection);
            try
            {
                connection.Open();
                Console.WriteLine("Enter Empid");
                int Empid = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@Empid", Empid);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public void deletewithsp()
        {
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("usp_Emp", connection);
            try
            {
                connection.Open();
                Console.WriteLine("Enter Empid");
                int Empid = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@Empid", Empid);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        public void listwithReadermethod()
        {
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee",connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Empname"]+ " "+reader["Empgender"]+" "+reader["Empsalary"]);
            }
            connection.Close();
        }
        //------------------------------------------------------------------------------------------------------------

        public void transactionEx()
        {
            
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into Employee(Empname,Empsalary)values(@Empname,@Empsalary)", connection);
            var trans =connection.BeginTransaction();
            try
            {
                Console.WriteLine("Enter Empname");
                string Empname = Console.ReadLine();
                Console.WriteLine("Enter Emp salary");
                Decimal Empsalary = Convert.ToDecimal(Console.ReadLine());
                cmd.Parameters.AddWithValue("@Empname", Empname);
                cmd.Parameters.AddWithValue("@Empsalary", Empsalary);
                trans.Commit();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Dispose();
                cmd.Dispose();
            }
        }
        //------------------------------------------------------------------------------------------------------------------

    }
}
