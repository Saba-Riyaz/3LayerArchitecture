using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeDBAccess
    {
        SqlConnection Con = new SqlConnection("Data Source = CGPC17\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True");

        public EmployeeDBAccess()
        {


        }
        public void SaveEmployee (EmployeeEntity employeeentity )
        {

            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "Execute spInsertEmployee @CompanyId , @DepartmentId,@FirstName , @LastName, @Email, @Phone, @Salary , @Address";

            cmd.Parameters.Add("@CompanyId", SqlDbType.Int).Value = employeeentity.CompanyId;
            cmd.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = employeeentity.DepartmentId ;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = employeeentity.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = employeeentity.LastName;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = employeeentity.Email;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, int.MaxValue).Value = employeeentity.Phone;
            cmd.Parameters.Add("@Salary", SqlDbType.VarChar, int.MaxValue).Value = employeeentity.Salary;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar, int.MaxValue).Value = employeeentity.Address;


            Con.Open();

            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Record Inserted SuccessFully");




        }

        public DataTable GetEmployee ()
        {
            SqlCommand cmd = new SqlCommand("spshowEmployee", Con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public void UpdateEmployee (EmployeeEntity employeeentity )
        {
            SqlCommand cmd = new SqlCommand("spUpdateEmployee", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = employeeentity.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = employeeentity.LastName;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = employeeentity.Email;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, int.MaxValue).Value = employeeentity.Phone;
            cmd.Parameters.Add("@Salary", SqlDbType.VarChar, int.MaxValue).Value = employeeentity.Salary;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar, int.MaxValue).Value = employeeentity.Address;

            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Updated Successfully");
        }


        public void DeleteEmployee (int EmployeeId )
        {
            // Create a new SqlCommand object for the stored procedure
            SqlCommand cmd = new SqlCommand("spDeleteEmployee", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the parameters for the stored procedure
            cmd.Parameters.AddWithValue("@CompanyId", EmployeeId);




            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Deleted Successfully");
        }



    }
}
