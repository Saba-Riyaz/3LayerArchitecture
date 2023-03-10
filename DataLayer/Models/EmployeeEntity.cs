using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class EmployeeEntity
    {
        public int CompanyId { get; set; }
        public int DepartmentId  { get; set; }

        public int EmployeeId  { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Salary { get; set; }
        public String Address { get; set; }
     
    }
}
