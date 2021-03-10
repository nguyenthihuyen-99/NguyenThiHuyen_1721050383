﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("Nhanviens")]
    public class Nhanvien
    {
        [Key]
        public string MaNV { get; set; }
        public string HotenNV { get; set; }
        public string Email { get; set; }
        public int Sodienthoai { get; set; }
        public string Ghichu { get; set; }
    }
}