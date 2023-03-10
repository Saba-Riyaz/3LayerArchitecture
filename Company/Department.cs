using Business;
using DataLayer.Models;
using NetTopologySuite.Mathematics;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        public void SaveDepartment()
        {
            DepartmentEntity entity = new DepartmentEntity();
            entity.DepartmentName = txtdepartmentName.Text;



            DepartmentBusiness obj = new DepartmentBusiness();
            obj.SaveDepartment(entity);
        }





        public void clear()
        {
            txtDepartmentId.Text = "";
            txtdepartmentName.Text = "";


        }
        public void ShowRecord()
        {
            DepartmentBusiness bal = new DepartmentBusiness();

            DataTable DepartmentTable = bal.GetDepartment();

            dgvDepartment.DataSource = DepartmentTable;

            if (dgvDepartment.Rows.Count > 0)
            {
                dgvDepartment.Rows[0].Selected = true;
            }

        }
        public void DeleteDepartment(int Departmentid)
        {
            Department bal = new Department();

            bal.DeleteDepartment(Departmentid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepartmentEntity entity = new DepartmentEntity();
            entity.DepartmentId = Convert.ToInt32(txtDepartmentId.Text);
            entity.DepartmentName = txtdepartmentName.Text;


            DepartmentBusiness obj = new DepartmentBusiness();
            obj.UpdateDepartment(entity);

            ShowRecord();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveDepartment();
            ShowRecord();
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteDepartment(Convert.ToInt32(txtDepartmentId.Text));

            ShowRecord();
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmmain = new FrmMain();
            frmmain.Show();
            this.Hide();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            PopulateCompanyDropdown();
            ShowRecord();
        }
        public void PopulateCompanyDropdown()
        {
            CompanyBusiness bal = new CompanyBusiness();
            DataTable CompanyTable = bal.GetCompany();
            DataRow newRow = CompanyTable.NewRow();
            newRow["CompanyId"] = 0;
            newRow["CompanyName"] = "Please Select Company";
            CompanyTable.Rows.InsertAt(newRow, 0);
            cmbCompany.DataSource = CompanyTable;
            cmbCompany.DisplayMember = "CompanyName";
            cmbCompany.ValueMember = "CompanyId";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDepartment.Rows[e.RowIndex];
                row.Selected = true;
                txtDepartmentId.Text = row.Cells[0].Value.ToString();
                txtdepartmentName.Text = row.Cells[1].Value.ToString();


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

