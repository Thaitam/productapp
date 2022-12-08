using baiquanlyweb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace baiquanlyweb.Service
{
    public interface Iquanly
    {
        public List<quanly> Getall();
        public string themsp(quanly QUANLY);
        public string xoasp(quanly QUANLY,string code);
        public string sua(quanly QUANLY, string code);
        public string luu(string code);
    }
}
