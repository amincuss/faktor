using Bussines.Layer.Customers.Contracts;
using DomainEntity.DtoModels;
using DomainEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Layer.Customers.Services
{
    public class CustomerServices:ICustomerServices
    {
        private readonly pishroContext _pishroContext;
        public CustomerServices(pishroContext pishroContext)
        {
            _pishroContext = pishroContext;
        }

        public async Task<(int customerid, int code, string message)> AddCustomer(AddCustomerDto addCustomerDto)
        {
            try
            {

    

                      var add = new Customer { 
      Name = addCustomerDto.Name,
                Address = addCustomerDto.Address,
                CodeMelli = addCustomerDto.CodeMeli,
                 Family= addCustomerDto.Family,
                 IsDeleted=false,
                 Mobile=addCustomerDto.Mobile,

            };
          await  _pishroContext.Customer.AddAsync(add);
         await   _pishroContext.SaveChangesAsync();
            int customerid = add.CustomerId;
            return (customerid, 200, "Sucesss");
            }
                catch(Exception ex)
            {
                return (0, 500, ex.Message);

            }
        
                
                }

        public async Task<(IQueryable list, int code, string message)> GetAllCustomer()
        {
            try
            {
 var load=await  _pishroContext.Customer.ToListAsync();
            return (load.AsQueryable(), 200, "Success");


            }catch(Exception ex)
            {

                return (null, 500, ex.Message);


            }


        }
    }
}
