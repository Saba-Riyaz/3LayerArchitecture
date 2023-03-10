using Business;
using DataLayer.Models;
using NetTopologySuite.Mathematics;
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

            DataTable DepartmentTable  = bal.GetDepartment();

            dgvDepartment.DataSource = DepartmentTable;

            if (dgvDepartment.Rows.Count > 0)
            {
                dgvDepartment.Rows[0].Selected = true;
            }

        }
        public void DeleteDepartment (int Departmentid )
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
            ShowRecord();
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
            //SQLHelper sqlConnect = new SQLHelper();
            //sqlConnect.DBConnection();
            //try
            //{
            //    if (sqlConnect.con.State == ConnectionState.Closed)
            //    {
            //        sqlConnect.con.Open();
            //    }

            //    SqlCommand cmd = new SqlCommand("SELECT Role FROM tbl_IT_RoleDescription", sqlConnect.con);

            //    using (SqlDataReader dr = cmd.ExecuteReader())
            //    {
            //        if (dr.HasRows)
            //        {
            //            while (dr.Read())
            //            {
            //                dd.Items.Add(dr["Role"].ToString());
            //            }
            //        }
            //        dr.Close();
            //    }
            //    sqlConnect.Con.Close();

            //    DD.SelectedIndex = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error : " + ex.Message + "\n\nSend this issue to EUC Dev Team?", "Intake Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //    sqlConnect.Con.Close();
            //    ;
            //}
        }
    }

    class SQLHelper
    {
        internal object con;

        internal void DBConnection()
        {
            throw new NotImplementedException();
        }
    }
}
