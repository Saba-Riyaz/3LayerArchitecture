using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class CompanyEntity
    {
       

        public int CompanyId  { get; set; }
       
        public String CompanyName  { get; set; }
        public String CompanyAddress { get; set; }
        public String CompanyCity  { get; set; }
        public String CompanyWebsite { get; set; }
        public String CompanyEmial  { get; set; }
        public string CompanyEmail { get; set; }
    }
}
