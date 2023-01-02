using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntity.DtoModels
{
  public class AddInvoiceRegisterDto
    {

        public int InvoiceNumber { get; set; }

      public int CustomerId { set; get; }
        public string ProductName { get; set; }

        public int ProductNumber { get; set; }

        public int ProductCost { get; set; }
    }
}
