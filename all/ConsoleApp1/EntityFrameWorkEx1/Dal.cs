using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFrameWorkEx1.Models;

namespace EntityFrameWorkEx1
{
   public class Dal
    {
        public void list()
        {
            using(Combining combining=new Combining())
            {
                var Emp = combining.Employee;
                foreach (var item in Emp)
                {
                    Console.WriteLine(item.Empname+" "+item.Empsalary);
                }
            }
        }
        public void list1()
        {
            using (Combining combining = new Combining())
            {
                var Details = combining.Details11dec;
                foreach (var item in Details)
                {
                    Console.WriteLine(item.Books + " " + item.Signature);
                }
            }
        }
        public void AddDepartment(int Id,string Books,string Signature,string Phno)
        {
            using (Combining context = new Combining())
            {
                Details11dec d = new Details11dec()
                {
                    Id = Id,
                    Books = Books,
                    Signature = Signature,
                    Phno = Phno
                };
                context.Details11dec.Add(d);
                context.SaveChanges();
            }
        }

        //public void update(string Signature)
        //{
        //    using (Combining context = new Combining())
        //    {
        //        var context1 = context.Details11dec.Where(d => d.Books.Equals("mfcs"));
        //        Details11dec d = new Details11dec();
        //        Signature = Signature;
        //        context.SaveChanges();
        //    }
        //}


    }
}
