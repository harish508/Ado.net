using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessAccessLayer
{
   public class PrintDetails
    {
        public DataSet EmployeeAndDetails(int Empid)
        {
            
            EmployeeDal employeeDal = new EmployeeDal();
            var dataTable1 = employeeDal.GetEmployee(Empid);

            DetailsDal detailsDal = new DetailsDal();
           var Det= detailsDal.GetDetails(Empid);

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable1);
            dataSet.Tables.Add(Det);
            return dataSet;
        }
    }
}
