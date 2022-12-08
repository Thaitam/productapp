using baiquanlyweb.Models;
using baiquanlyweb.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiquanlyweb
{
    public partial class Form1 : Form
    {

        private Iquanly quanlyservices;
        public Form1(Iquanly _quanly)
        {
            quanlyservices = _quanly;
            InitializeComponent();
        }

        void lock_text()
        {
            txtmasp.Enabled = false;
            txttensp.Enabled = false;
            txtnsx.Enabled = false;
            numgiaban.Enabled = false;
            dthansd.Enabled = false;
            btnLUU.Enabled = false;
            btnCAPNHAT.Enabled = true;
            btnTHEM.Enabled = true;
            btnBOQUA.Enabled = false;
            btnXOA.Enabled = true;
        }
        void unlock_text()
        {
            txtmasp.Enabled = true;
            txttensp.Enabled = true;
            txtnsx.Enabled = true;
            numgiaban.Enabled = true;
            dthansd.Enabled = true;
            btnLUU.Enabled = true;
            btnCAPNHAT.Enabled = false;
            btnTHEM.Enabled = false;
            btnBOQUA.Enabled = true;
            btnXOA.Enabled = false;
        }
        void setnull()
        {
            txtmasp.Text = "";
            txtnsx.Text = "";
            txttensp.Text = "";
            dthansd.Value = DateTime.Now;
            numgiaban.Value = 120000;
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            unlock_text();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lock_text();
        }

        private void btnBOQUA_Click(object sender, EventArgs e)
        {
            setnull();
            lock_text();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if (txtmasp.Enabled == true)
            {
                quanlyservices.luu(new quanly()
                {
                    masp = Convert.ToInt32(txtmasp.Text),
                    tensp = txttensp.Text,
                    hansudung = dthansd.Value,
                    nhasx = txtnsx.Text,
                    giaban = Convert.ToSingle(numgiaban.Value)

                });
                MessageBox.Show("Lưu thành công");
            }
            else
            {

            }
        }
    }
}
