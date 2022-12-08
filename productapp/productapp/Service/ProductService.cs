using Microsoft.EntityFrameworkCore;
using productapp.Context;
using productapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace productapp.Service
{
    public class ProductService : IProduct
    {
        public string Boqua(string code)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            try
            {
                using (productDbcontext db = new productDbcontext())
                {
                    return db.products.ToList();
                }
            }
            catch (Exception)
            {

                return new List<Product>();
            }
        }

        public Product GetproductbyID(string code)
        {
            try
            {
                using (productDbcontext db = new productDbcontext())
                {
                    Product pb = db.products.Where(c => c.MASANPHAM.ToString() == code).FirstOrDefault();

                    return pb;
                }
            }
            catch
            {

                return new Product();
            }
        }

        public string Luusanpham(string code)
        {
            try
            {
                using (productDbcontext db = new productDbcontext())
                {
                   db.SaveChanges();
                    return "Save Done!";
                }
            }
            catch
            {
                return "Save Fail";
            }
        }

        public string Suasanpahm(Product product, string code)
        {
            try
            {
                using (productDbcontext db = new productDbcontext())
                {
                    Product pd = db.products.Where(c => c.MASANPHAM.ToString() == code).FirstOrDefault();
                    pd.TENSANPHAM = product.TENSANPHAM;
                    pd.HANSUDUNG = product.HANSUDUNG;
                    pd.NHASANXUAT = product.NHASANXUAT;
                    pd.GIABAN = product.GIABAN;
                    db.SaveChanges();
                    return "Save Change!";
                }
            }
            catch
            {

                return "Save Change Fail!";
            }
        }

        public string Themsanpham(Product product)
        {
            try
            {
                using (productDbcontext db = new productDbcontext())
                {
                    db.products.Add(product);
                    db.SaveChanges();
                    return "Done";
                }
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }

        public string Xoasanpham(string code)
        {
            try
            {
                using (productDbcontext db = new productDbcontext())
                {
                    Product pb = db.products.Where(c => c.MASANPHAM.ToString() == code).FirstOrDefault();
                    db.products.Remove(pb);
                    db.SaveChanges();
                    return "Done!";
                }
            }
            catch
            {

                return "Fail!";
            }
        }
    }
}
