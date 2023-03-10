using DataLayer.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sitecore.FakeDb;

namespace Business
{
    public class DepartmentBusiness
    {
        public int DepartmentId  { get; private set; }

        public DepartmentBusiness ()
        {

        }
        public void getRole(ComboBox cmbUserRole)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT Role FROM tbl_IT_RoleDescription";
            //Db.exeReader(cmd);
        }
        public void SaveDepartment (DepartmentEntity entity)
        {
            DepartmentDBAccess obj = new DepartmentDBAccess();
            obj.SaveDepartment(entity);
        }

        public DataTable GetDepartment ()
        {
            DepartmentDBAccess dal = new DepartmentDBAccess();

            DataTable dt = dal.GetDepartment();
            return dt;
        }
        public void UpdateDepartment (DepartmentEntity entity)
        {
            DepartmentDBAccess obj = new DepartmentDBAccess();
            obj.UpdateDepartment(entity);

        }
        public void DeleteDepartment  (int DepartmentId)
        {

            DepartmentDBAccess dal = new DepartmentDBAccess();

            dal.DeleteDepartment(DepartmentId);



        }
    }
}

