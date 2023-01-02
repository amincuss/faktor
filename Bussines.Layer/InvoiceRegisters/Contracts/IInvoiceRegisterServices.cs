using DomainEntity.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Layer.InvoiceRegisters.Contracts
{
   public interface IInvoiceRegisterServices
    {
        Task<( int code, string message)> AddInvoiceProduct(AddInvoiceRegisterDto addInvoiceRegisterDto);
        Task<(int code, string message)> UpdateInvoiceProduct(UpdateInvoiceRegisterDto updateInvoiceRegisterDto);

        Task<(IQueryable list, int code, string message)> GetAllInvoiceProduct();
        Task<(IQueryable list, int code, string message)> GetAllByInvoiceNumber(int InvoiceNumber);

        Task<( int code, string message)> SubmitInvoiceToCustomer(int InvoiceNumber,int Customerid);
        public Task<(int code, string message)> DeleteInvoiceProduct(int invoiceRegisterId);



    }
}
