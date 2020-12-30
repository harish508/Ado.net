using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    [Table("Details11dec")]
    public class Details
    {
        public int Id { get; set; }
        public string Books { get; set; }
        public string Signature { get; set; }
        public string Phno { get; set; }
    }
}
