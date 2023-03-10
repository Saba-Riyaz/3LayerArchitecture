using DataLayer.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CompanyDBAccess  
    {
        SqlConnection Con = new SqlConnection("Data Source = CGPC17\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True");

        public CompanyDBAccess ()
        {


        }
        public void SaveComapny(CompanyEntity companyentity)
        {

            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "Execute spInsertCompany @CompanyName,@CompanyAddress,@CompanyCity,@CompanyWebsite, CompanyEmail";

            cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar, 50).Value = companyentity.CompanyName;
            cmd.Parameters.Add("@CompanyAddress", SqlDbType.VarChar, int.MaxValue).Value = companyentity.CompanyAddress;
            cmd.Parameters.Add("@CompanyCity", SqlDbType.VarChar, 50).Value = companyentity.CompanyCity;
            cmd.Parameters.Add("@CompanyWebsite", SqlDbType.VarChar, int.MaxValue).Value = companyentity.CompanyWebsite;
            cmd.Parameters.Add("@CompanyEmail", SqlDbType.VarChar, int.MaxValue).Value = companyentity.CompanyEmail;


            Con.Open();

            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Record Inserted SuccessFully");




        }

        public DataTable GetCompany ()
        {
            SqlCommand cmd = new SqlCommand("spshowData", Con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public void UpdateCompany ( CompanyEntity companyentity )
        {
            SqlCommand cmd = new SqlCommand("spUpdateData", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CompanyId", SqlDbType.Int).Value = companyentity.CompanyId;

            cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar, 50).Value = companyentity.CompanyName;
            cmd.Parameters.Add("@CompanyAddress", SqlDbType.VarChar, int.MaxValue).Value = companyentity.CompanyAddress;
            cmd.Parameters.Add("@CompanyCity", SqlDbType.VarChar, 50).Value = companyentity.CompanyCity;
            cmd.Parameters.Add("@CompanyWebsite", SqlDbType.VarChar, int.MaxValue).Value = companyentity.CompanyWebsite;
            cmd.Parameters.Add("@CompanyEmail", SqlDbType.VarChar, int.MaxValue).Value = companyentity.CompanyEmail;

            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Updated Successfully");
        }


        public void DeleteCompany (int CompanyId )
        {
            // Create a new SqlCommand object for the stored procedure
            SqlCommand cmd = new SqlCommand("spDeleteData", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the parameters for the stored procedure
            cmd.Parameters.AddWithValue("@CompanyId", CompanyId);




            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Deleted Successfully");
        }

  
    }

  
}