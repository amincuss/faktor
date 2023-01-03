using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntity.DtoModels
{
    public class UpdateInvoiceRegisterDto
    {
        public int InvoiceRegisterId { get; set; }

        public int InvoiceId { get; set; }
        public Boolean IsDeleted { get; set; }

        public string ProductName { get; set; }

        public int ProductNumber { get; set; }

        public int ProductCost { get; set; }
    }
}
