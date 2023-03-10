namespace Company
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCompanies_Click(object sender, EventArgs e)
        {
            CompanyInfo form2 = new CompanyInfo();
            form2.Show();
            this.Hide();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {

            Department form2 = new Department();
            form2.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee form2 = new Employee();
            form2.Show();
            this.Hide();
        }
    }
}