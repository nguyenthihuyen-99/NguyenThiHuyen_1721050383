using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("Tacgias")]
    public class Tacgia
    {
        [Key]
        public string Matacgia { get; set; }
        public string Tentacgia { get; set; }
        public string Ghichu { get; set; }

    }
}