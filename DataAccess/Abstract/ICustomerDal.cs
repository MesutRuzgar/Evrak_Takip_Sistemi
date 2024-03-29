﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<CustomerDTO> GetCustomerDto(Expression<Func<CustomerDTO, bool>> filter = null);
     
    }
}
