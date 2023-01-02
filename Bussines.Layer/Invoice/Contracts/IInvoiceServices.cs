using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Layer.Invoice.Contracts
{
   public interface IInvoiceServices
        
    {
        Task<int> GenerateInvoiceNumber(String InvoiceName);

    }
}
