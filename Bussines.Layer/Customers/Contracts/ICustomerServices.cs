using DomainEntity.DtoModels;
using DomainEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Layer.Customers.Contracts
{
    public interface ICustomerServices
    {
        Task<(int customerid, int code, string message)> AddCustomer(AddCustomerDto addCustomerDto);
        Task<(IQueryable list,int code,string message)> GetAllCustomer();
     



    }
}
