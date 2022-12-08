using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace productapp.Models
{
    public class Product
    {
        [Key]
        [MaxLength(7)]
        public uint MASANPHAM { get; set; }
        public string TENSANPHAM { get; set; }
        public DateTime HANSUDUNG { get; set; }
        public string NHASANXUAT { get; set; }
        public float GIABAN { get; set; }
    }
}
