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

        public int invoiceNumber { get; set; }

        public string productName { get; set; }

        public int productNumber { get; set; }

        public int productCost { get; set; }
    }
}
