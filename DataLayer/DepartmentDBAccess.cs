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
    public class DepartmentDBAccess
    {
        SqlConnection Con = new SqlConnection("Data Source = CGPC17\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True");

        public DepartmentDBAccess()
        {


        }
        public void SaveDepartment (DepartmentEntity departmententity)
        {

            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "Execute spInsertDepartment @DepartmentName";

            cmd.Parameters.Add("@DepartmentName", SqlDbType.VarChar, 50).Value = departmententity.DepartmentName;
           


            Con.Open();

            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Record Inserted SuccessFully");




        }

        public DataTable GetDepartment ()
        {
            SqlCommand cmd = new SqlCommand("spshowDepartment", Con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public void UpdateDepartment (DepartmentEntity departmententity)
        {
            SqlCommand cmd = new SqlCommand("spUpdateDepartment", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@DepartmentName", SqlDbType.VarChar, 50).Value = departmententity.DepartmentName;
           

            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Updated Successfully");
        }


        public void DeleteDepartment (int DepartmentId )
        {
            // Create a new SqlCommand object for the stored procedure
            SqlCommand cmd = new SqlCommand("spDeleteDepartment", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the parameters for the stored procedure
            cmd.Parameters.AddWithValue("@", DepartmentId);
            cmd.Parameters.AddWithValue("@DepartmentId", DepartmentId);




            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Deleted Successfully");
        }


    }
}

