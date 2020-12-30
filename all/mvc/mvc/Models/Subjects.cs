using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    [Table("Subjects1")]
    public class Subjects
    {
        [key]
        public int Autoid { get; set; }
        public string? Subject { get; set; }
        public string? Subsubject { get; set; }
        public int? Subjectid { get; set; }
    }
}
