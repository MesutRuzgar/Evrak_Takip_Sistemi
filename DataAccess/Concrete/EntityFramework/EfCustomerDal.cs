using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, dbAngunContext>, ICustomerDal
    {

        List<CustomerDTO> ICustomerDal.GetCustomerDto()
        {
            using (dbAngunContext context = new dbAngunContext())
            {
                var result = from c in context.Customers
                             select new CustomerDTO
                             {
                                 Id = c.Id,
                                 TaxIdentificationNumber = c.TaxIdentificationNumber,
                                 CompanyName = c.CompanyName,
                                 TaxPlateYear = c.TaxPlateYear,
                                 ActivityCertificateDate = c.ActivityCertificateDate,
                                 SignatureCircularDate = c.SignatureCircularDate,
                                 CompanyOfficials = c.CompanyOfficials,
                             };
                return result.ToList();
            }
        }
    }
}
