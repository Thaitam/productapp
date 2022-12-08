using productapp.Models;
using productapp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productapp
{
    public partial class Form1 : Form
    {
        private IProduct productservice;
        public Form1(IProduct _product)
        {
            productservice = _product;
            InitializeComponent();
        }


        
        private void btnTHEM_Click(object sender, EventArgs e)
        {
            unlock_text();
            set_null();
            txtMASP.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productservice.GetAll();
            lock_text();

        }

        void lock_text()
        {
            txtMASP.Enabled = false;
            txtTENSP.Enabled = false;
            txtNHASX.Enabled = false;
            dtHANSUDUNG.Enabled = false;         
            numGIA.Enabled = false;
            btnTHEM.Enabled = true;
            btnXOA.Enabled = true;
            btnSUA.Enabled = true;
            btnLUU.Enabled = false;
            btnBOQUA.Enabled = true;
        }
        void unlock_text()
        {
            txtMASP.Enabled = true;
            txtTENSP.Enabled = true;
            txtNHASX.Enabled = true;
            dtHANSUDUNG.Enabled = true;
            numGIA.Enabled = true;
            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnSUA.Enabled = false;
            btnLUU.Enabled = true;
            btnBOQUA.Enabled = true;
        }
        void set_null()
        {
            txtMASP.Text = "";
            txtNHASX.Text = "";
            txtTENSP.Text = "";
            dtHANSUDUNG.Value = DateTime.Now;
            numGIA.Value = 120000;
        }

        private void btnBOQUA_Click(object sender, EventArgs e)
        {
            lock_text();
            set_null();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if (txtMASP.Enabled == true)
            {
                productservice.Themsanpham(new Product()
                {
                    MASANPHAM = Convert.ToUInt32(txtMASP.Text),
                    TENSANPHAM = txtTENSP.Text,
                    NHASANXUAT = txtNHASX.Text,
                    HANSUDUNG = dtHANSUDUNG.Value,
                    GIABAN = Convert.ToSingle(numGIA.Value)
                   
                });
                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                productservice.Suasanpahm(
                new Product
                {
                    MASANPHAM = Convert.ToUInt32(txtMASP.Text),
                    TENSANPHAM = txtTENSP.Text,
                    NHASANXUAT = txtNHASX.Text,
                    HANSUDUNG = dtHANSUDUNG.Value,
                    GIABAN = Convert.ToSingle(numGIA.Value)
                },txtMASP.Text);
            }
            dataGridView1.DataSource = productservice.GetAll();
            lock_text();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            if (txtMASP.Text != "")
            {
                unlock_text();
                txtMASP.Enabled = false;

            }
            else
            {
                MessageBox.Show("Vui lòng chọn ô cần cập nhật!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMASP.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTENSP.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtHANSUDUNG.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtNHASX.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                numGIA.Value = (decimal)Single.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Không có gì để chọn!");
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (txtMASP.Text != "")
            {
                productservice.Xoasanpham(txtMASP.Text);
                dataGridView1.DataSource = productservice.GetAll();
                MessageBox.Show("Xoá thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ô cần xoá!");
            }
        }
    }
}
