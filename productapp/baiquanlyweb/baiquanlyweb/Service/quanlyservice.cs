using baiquanlyweb.Context;
using baiquanlyweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baiquanlyweb.Service
{
    public class quanlyservice : Iquanly
    {
        public List<quanly> Getall()
        {
            try
            {
                using (quanlydbcontext ql = new quanlydbcontext())
                {
                    return ql.quanlies.ToList();
                }
            }
            catch
            {
                return new List<quanly>();
            }
        }

        public string luu(string code)
        {
            try
            {
                using (quanlydbcontext ql = new quanlydbcontext())
                {
                    ql.SaveChanges();
                    return "Save Done";
                }
            }
            catch
            {
                return "Save Fail";
            }
        }

        public string sua(quanly QUANLY, string code)
        {
            try
            {
                using (quanlydbcontext ql = new quanlydbcontext())
                {
                    quanly QL = ql.quanlies.Where(c => c.masp.ToString() == code).FirstOrDefault();
                    QL.tensp = QUANLY.tensp;
                    QL.nhasx = QUANLY.nhasx;
                    QL.hansudung = QUANLY.hansudung;
                    QL.giaban = QUANLY.giaban;
                    ql.SaveChanges();
                    return "Save Change";

                }
            }
            catch
            {

                return "Save fali";
            }
        }

        public string themsp(quanly QUANLY)
        {
            try
            {
                using (quanlydbcontext ql = new quanlydbcontext())
                {
                    ql.quanlies.Add(QUANLY);
                    ql.SaveChanges();
                    return "Done!";
                }

            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string xoasp(quanly QUANLY, string code)
        {
            try
            {
                using (quanlydbcontext ql = new quanlydbcontext())
                {
                    quanly QL = ql.quanlies.Where(c => c.masp.ToString() == code).FirstOrDefault();
                    ql.quanlies.Remove(QL);
                    ql.SaveChanges();
                    return "Done";
                }
            }
            catch (Exception)
            {
                return "Fail";
            }
        }
    }
}
