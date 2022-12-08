using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace baiquanlyweb.Models
{
    public class quanly
    {
        [Key]
        [MaxLength(6)]
        public int masp { get; set; }
        public string tensp { get; set; }
        public DateTime hansudung { get; set; }
        public string nhasx { get; set; }
        public float giaban { get; set; }
    }
}
