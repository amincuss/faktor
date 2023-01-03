using Bussines.Layer.InvoiceRegisters.Contracts;
using DomainEntity.DtoModels;
using DomainEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Layer.InvoiceRegisters.Services
{
    public class InvoiceRegisterServices:IInvoiceRegisterServices
    {
        private readonly pishroContext _pishroContext;
        public InvoiceRegisterServices(pishroContext pishroContext)
        {
            _pishroContext = pishroContext;
        }

        public async Task<( int code, string message)> AddInvoiceProduct(AddInvoiceRegisterDto addInvoiceRegisterDto)
        {

            try
            {
                var add = new InvoiceRegister
                {
                    InvoiceId = addInvoiceRegisterDto.invoiceNumber,
                    ProductCost = addInvoiceRegisterDto.productCost,
                    ProductName = addInvoiceRegisterDto.productName,
                    ProductNumber = addInvoiceRegisterDto.productNumber,
                    IsDeleted = false,


                };
             await   _pishroContext.InvoiceRegister.AddAsync(add);
              await  _pishroContext.SaveChangesAsync();

            
                return (200, "Sucesss");


            }catch(Exception ex)
            {
                return (500, ex.InnerException.ToString());


            }
        }

        public async Task<(IQueryable list, int code, string message)> GetAllByInvoiceNumber(int InvoiceNumber)
        {
            try
            {
                var load=await _pishroContext.InvoiceRegister.
                    Where(x=>x.InvoiceId==InvoiceNumber).
                    AsNoTracking()
                    .ToListAsync();
                return (load.AsQueryable(), 200, "Success");

            }
            catch (Exception ex)
            {
                return (null, 500, ex.Message);


            }
        }

        public async Task<(IQueryable list, int code, string message)> GetAllInvoiceProduct()
        {
            try
            {
                var load = await _pishroContext.InvoiceRegister.Where(x=>x.IsDeleted==false).AsNoTracking().ToListAsync();
                
                  
               
                return (load.AsQueryable(), 200, "Success");

            }
            catch (Exception ex)
            {
                return (null, 500, ex.Message);


            }
        }

        public async Task<(int code, string message)> SubmitInvoiceToCustomer(int InvoiceNumber, int Customerid)
        {
            try
            {
              await  _pishroContext.InvoiceCustomer.AddAsync(new InvoiceCustomer
                {
                    CustomerId= Customerid,
                    InvoiceId= InvoiceNumber,


                });

             await   _pishroContext.SaveChangesAsync();
                return (200, "Sucesss");


            }
            catch (Exception ex)
            {
                return (500,ex.Message);


            }
        }

        public async Task<(int code, string message)> UpdateInvoiceProduct(UpdateInvoiceRegisterDto updateInvoiceRegisterDto)
        {
            try
            {
                var update = new InvoiceRegister
                {
                     InvoiceRegisterId= updateInvoiceRegisterDto.InvoiceRegisterId,
                       IsDeleted=updateInvoiceRegisterDto.IsDeleted,
                        ProductCost=updateInvoiceRegisterDto.ProductCost,
                         ProductName=updateInvoiceRegisterDto.ProductName,
                          ProductNumber = updateInvoiceRegisterDto.ProductNumber,
                          InvoiceId= updateInvoiceRegisterDto.InvoiceId,

                };
               _pishroContext.InvoiceRegister.Update(update);
             await   _pishroContext.SaveChangesAsync();

                return ( 200, "Success");

            }
            catch (Exception ex)
            {
                return (500, ex.Message);


            }
        }

        public async Task<(int code, string message)> DeleteInvoiceProduct(int invoiceRegisterId)
        {
            try
            {
           var updt=    await _pishroContext.InvoiceRegister.FindAsync(invoiceRegisterId);

                updt.IsDeleted=true;
                _pishroContext.Update(updt);
             await   _pishroContext.SaveChangesAsync();
              

                return (200, "Success");

            }
            catch (Exception ex)
            {
                return (500, ex.Message);


            }
        }

    }
}
