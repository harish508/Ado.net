using BusinessAccessLayer;
using System;
using System.Data;
using DataAccessLayer;

namespace NTARTS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insertion n= new Insertion();
            //n.EmpInsert();
            //Update u = new Update();
            //u.EmpUpdate();
            Delete d = new Delete();
                d.EmpDelete();
            return;
            Console.WriteLine("Enter Empid u want");
            var Empid = int.Parse(Console.ReadLine());
            DataSet dataSet = new DataSet();
            try
            {
                dataSet = new PrintDetails().EmployeeAndDetails(Empid);

                //data = new PrintDetails().EmployeeAndDetails(2);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error occured"+e.Message);
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                 Console.WriteLine(row["Empid"]+" "+row["Empname"]+" "+row["Empsalary"]);
                
            }
            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                
                Console.WriteLine(row["Books"]);
            }
        }
    }
}
