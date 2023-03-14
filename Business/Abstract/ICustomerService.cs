using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        bool CheckCustomerByTaxId(string taxId);
        List<Customer> GetAll(int id);
        List<CustomerDTO> GetCustomerDto();
        List<CustomerDTO> GetCustomerDto(string filter);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
