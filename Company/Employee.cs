﻿using Business;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmmain = new FrmMain();
            frmmain.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEmployee();
            ShowRecord();
            clear();
        }
        public void SaveEmployee ()
        {
            EmployeeEntity entity = new EmployeeEntity();
            entity.FirstName = txtFirstName.Text;
            entity.LastName = txtLastName.Text;
            entity.Email = txtEmail.Text;
            entity.Phone = txtPhone.Text;
            entity.Salary = txtSalary.Text;
            entity.Address = txtAddress.Text;


            EmployeeBusiness obj = new EmployeeBusiness();
            obj.SaveEmployee(entity);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeEntity entity = new EmployeeEntity();
            entity.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            entity.FirstName = txtFirstName.Text;
            entity.LastName = txtLastName.Text;
            entity.Email = txtEmail.Text;
            entity.Phone = txtPhone.Text;
            entity.Salary = txtSalary.Text;
            entity.Address = txtAddress.Text;



            EmployeeBusiness obj = new EmployeeBusiness();
            obj.UpdateEmployee(entity);

            ShowRecord();
            clear();
        }
        public void clear()
        {
            txtEmployeeId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            txtAddress.Text = "";

        }
        public void ShowRecord()
        {
            EmployeeBusiness bal = new EmployeeBusiness();

            DataTable EmployeeTable = bal.GetEmployee();

            dgvEmployee.DataSource = EmployeeTable;

            if (dgvEmployee.Rows.Count > 0)
            {
                dgvEmployee.Rows[0].Selected = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee(Convert.ToInt32(txtEmployeeId.Text));

            ShowRecord();
            clear();
        }
        public void DeleteEmployee (int Employeeid)
        {
            Employee bal = new Employee();

            bal.DeleteEmployee(Employeeid);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            PopulateCompanyDropdown();
            PopulateDepartmentDropdown();
          
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
            cboCompanyId.DataSource = CompanyTable;
            cboCompanyId.DisplayMember = "CompanyName";
            cboCompanyId.ValueMember = "CompanyId";
        }
        public void PopulateDepartmentDropdown ()
        {
            DepartmentBusiness bal = new DepartmentBusiness();
            DataTable DepartmentTable  = bal.GetDepartment();
            DataRow newRow = DepartmentTable.NewRow();
            newRow["DepartmentId"] = 0;
            newRow["DepartmentName"] = "Please Select Department";
            DepartmentTable.Rows.InsertAt(newRow, 0);
            cboDepartmentId.DataSource = DepartmentTable;
            cboDepartmentId.DisplayMember = "DepartmentName";
            cboDepartmentId.ValueMember = "DepartmentId";
        }
       

    }
}
