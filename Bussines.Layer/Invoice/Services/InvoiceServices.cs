using Bussines.Layer.Invoice.Contracts;
using DomainEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Layer.Invoice.Services
{
    
    public class InvoiceServices : IInvoiceServices
    {
        private readonly pishroContext _pishroContext;
        public InvoiceServices( pishroContext pishroContext)
        {
            _pishroContext= pishroContext;
        }
        public async Task<int> GenerateInvoiceNumber(string InvoiceName)
        {

            try

            {
                var add = new Invoices
                {

                    InvoiceName = InvoiceName,
                    InvoiceDate= DateTime.Now,
                };
              await  _pishroContext.Invoices.AddAsync(add);
             await   _pishroContext.SaveChangesAsync();
                int InvoiceId = add.InvoiceId;


                return InvoiceId ;

            }catch(Exception ex)
            {

                return 0;
            }
        }
    }
}
