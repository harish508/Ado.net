using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWorkEx1.Models
{
    [Table("Details11dec")]
   public  class Details11dec
    {

        public int Id { get; set; }
        public string Books { get; set; }
        public string Signature { get; set; }
        public string Phno { get; set; }

    }
}
