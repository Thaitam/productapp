using Ontap.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ontap.Core.Models;

namespace Ontap.UI
{
    public partial class FrmMain : Form
    {
        private IEmployeeService employeeService;
        public FrmMain(IEmployeeService _service)
        {
            employeeService = _service;
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            un_lock_text();
            set_null();
            /*employeeService.AddEmployee(new Employee()
            {
                EmployeeCode = txtEmpCode.Text,
                Name = txtEmpName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                DateOfBirth = dtpDateOfBirth.Value
            });
            dataGridView1.DataSource = employeeService.GetAll();*/
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeService.GetAll();
            lock_text();
        }
        private void lock_text()
        {
            txtEmpCode.Enabled = false;
            txtEmpName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtEmail.Enabled = false;
            dtpDateOfBirth.Enabled = false;
            cmdSave.Enabled = false;
            cmdUpdate.Enabled = true;
            cmdAdd.Enabled = true;
        }
        private void un_lock_text()
        {
            txtEmpCode.Enabled = true;
            txtEmpName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtEmail.Enabled = true;
            dtpDateOfBirth.Enabled = true;
            cmdSave.Enabled = true;
            cmdUpdate.Enabled = false;
            cmdAdd.Enabled = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtEmpCode.Enabled == true)
            {
                employeeService.AddEmployee(new Employee()
                {
                    EmployeeCode = txtEmpCode.Text,
                    Name = txtEmpName.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    DateOfBirth = dtpDateOfBirth.Value
                });
            }
            else
            {
                employeeService.UpdateEmployee(
                new Employee
                {
                    EmployeeCode = txtEmpCode.Text,
                    Name = txtEmpName.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text
                }, txtEmpCode.Text);
            }
            dataGridView1.DataSource = employeeService.GetAll();
            lock_text();
        }
        private void set_null()
        {
            txtEmpCode.Text = "";
            txtEmpName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtEmpCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           txtEmpName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           dtpDateOfBirth.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if(txtEmpCode.Text != "")
            {
                un_lock_text();
                txtEmpCode.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select an employee from datagrid below");
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtEmpCode.Text != "")
            {
                employeeService.DeleteEmployee(txtEmpCode.Text);
                dataGridView1.DataSource = employeeService.GetAll();
            }
            else
            {
                MessageBox.Show("Please select an employee from datagrid below");
            }
        }
    }
}
