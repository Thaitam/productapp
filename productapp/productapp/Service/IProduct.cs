using productapp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace productapp.Service
{
    public interface IProduct
    {
        public List<Product> GetAll();
        public Product GetproductbyID(string code);
        public string Themsanpham(Product product);
        public string Xoasanpham(string code);
        public string Suasanpahm(Product product, string code);
        public string Luusanpham(string code);
        public string Boqua(string code);
    }
}
