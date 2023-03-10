using DataLayer;
using DataLayer.Models;
using System.ComponentModel.Design;
using System.Data;

namespace Business
{
    public class CompanyBusiness
    {
        public int CompanyId { get; private set; }

        public CompanyBusiness()
        {

        }
        public void SaveCompany(CompanyEntity entity)
        {
            CompanyDBAccess obj = new CompanyDBAccess();
            obj.SaveComapny(entity);
        }

        public DataTable GetCompany()
        {
            CompanyDBAccess dal = new CompanyDBAccess();

            DataTable dt = dal.GetCompany();
            return dt;
        }
        public void UpdateCompany(CompanyEntity entity)
        {
            CompanyDBAccess obj = new CompanyDBAccess();
            obj.UpdateCompany(entity );

        }
        public void DeleteCompany(int ComapanyId)
        {

            CompanyDBAccess dal = new CompanyDBAccess();

            dal.DeleteCompany(CompanyId);



        }
    }

   
}