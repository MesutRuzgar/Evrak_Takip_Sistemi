﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService

    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

       
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public bool CheckCustomerByTaxId(string taxId)
        {
            var customer = _customerDal.GetAll().FirstOrDefault(c=>c.TaxIdentificationNumber == taxId);
            return customer != null;
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }
              

        public List<Customer> GetAll(int id)
        {
            return _customerDal.GetAll(c => c.Id == id);
        }     

        public List<CustomerDTO> GetCustomerDto()
        {
            return _customerDal.GetCustomerDto();
        }

        public List<CustomerDTO> GetCustomerDto(string filter)
        {
            return _customerDal.GetCustomerDto(c=>c.CompanyName.Contains(filter));
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
