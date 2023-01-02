using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntity.DtoModels
{
    public class UpdateCustomerDto
    {
        public string CustomerId { get; set;}
        public string Name { get; set; }
        public string Family { get; set; }
        public string CodeMeli { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }

    }
}
