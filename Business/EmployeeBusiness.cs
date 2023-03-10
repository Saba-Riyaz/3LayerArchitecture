using DataLayer.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EmployeeBusiness
    {
        public int EmployeeId { get; private set; }

        public EmployeeBusiness ()
        {

        }
        public void SaveEmployee (EmployeeEntity entity)
        {
            EmployeeDBAccess obj = new EmployeeDBAccess();
            obj.SaveEmployee(entity);
        }

        public DataTable GetEmployee ()
        {
            EmployeeDBAccess dal = new EmployeeDBAccess();

            DataTable dt = dal.GetEmployee();
            return dt;
        }
        public void UpdateEmployee (EmployeeEntity entity)
        {
            EmployeeDBAccess obj = new EmployeeDBAccess();
            obj.UpdateEmployee(entity);

        }
        public void DeleteEmployee (int EmployeeId )
        {

            EmployeeDBAccess dal = new EmployeeDBAccess();

            dal.DeleteEmployee(EmployeeId);



        }
    }
}
