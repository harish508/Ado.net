using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWorkEx1.Models
{
    [Table("Employee")]
   public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Empgender { get; set; }
        public string Emplocation { get; set; }
        public string Empphno { get; set; }
        public Decimal Empsalary { get; set; }
    }
}
