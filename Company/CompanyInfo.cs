using Business;
using DataLayer.Models;
using System.Data;

namespace Company
{
    public partial class CompanyInfo : Form
    {
        private object CompanyTable;

        public int CompanyId { get; private set; }

        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            ShowRecord();
        }
        public void SaveCompany ()
        {
            CompanyEntity entity = new CompanyEntity ();
            entity.CompanyName = txtCompanyName.Text;
            entity.CompanyAddress = txtCompanyAddress.Text;
            entity.CompanyCity = txtCompanyCity.Text;
            entity.CompanyWebsite = txtCompanyWebsite.Text;
            entity.CompanyEmail = txtCompanyEmail.Text;


            CompanyBusiness obj = new CompanyBusiness();
            obj.SaveCompany(entity);
        }

     

      

        public void clear()
        {
            txtCompanyId.Text = "";
            txtCompanyName.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyCity.Text = "";
            txtCompanyWebsite.Text = "";
            txtCompanyEmail.Text = "";

        }
        public void ShowRecord()
        {
            CompanyBusiness bal = new CompanyBusiness();

            DataTable CompanyTable  = bal.GetCompany();

            dgvCompany.DataSource = CompanyTable ;

            if (dgvCompany.Rows.Count > 0)
            {
                dgvCompany.Rows[0].Selected = true;
            }

        }


        public void DeleteCompany (int Studentid)
        {
            CompanyInfo bal = new CompanyInfo();

            bal.DeleteCompany(CompanyId );
        }

      

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            CompanyEntity entity = new CompanyEntity();
            entity.CompanyId = Convert.ToInt32(txtCompanyId.Text);
            entity.CompanyName = txtCompanyName.Text;
            entity.CompanyAddress = txtCompanyAddress.Text;
            entity.CompanyCity = txtCompanyCity.Text;
            entity.CompanyWebsite = txtCompanyWebsite.Text;
            entity.CompanyEmail = txtCompanyEmail.Text;



            CompanyBusiness obj = new CompanyBusiness();
            obj.UpdateCompany(entity);

            ShowRecord();
            clear();
        }

        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCompany.Rows[e.RowIndex];
               row.Selected = true;
               txtCompanyId.Text = row.Cells[0].Value.ToString();
                txtCompanyName.Text = row.Cells[1].Value.ToString();
                txtCompanyAddress.Text = row.Cells[2].Value.ToString();
                txtCompanyCity.Text = row.Cells[3].Value.ToString();
                txtCompanyWebsite.Text = row.Cells[4].Value.ToString();
                txtCompanyEmail.Text = row.Cells[5].Value.ToString();

            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            DeleteCompany(Convert.ToInt32(txtCompanyId.Text));

            ShowRecord();
            clear();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveCompany();
            ShowRecord();
            clear();
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmmain = new FrmMain();
            frmmain.Show();
            this.Hide();
        }

       

     
    }

    //internal class companyentity
    //{
    //    public companyentity()
    //    {
    //    }
    //}

    //class CompanyBusiness
    //{
    //    internal void DeleteCompany(int companyId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    internal DataTable GetCompany()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    internal void SaveCompany(CompanyEntity entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    internal void UpdateCompany(CompanyEntity entity)
    //    {
    //        throw new NotImplementedException();
    //    }          
    //}


}

    

