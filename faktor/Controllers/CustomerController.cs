using Bussines.Layer.Customers.Contracts;
using Bussines.Layer.Invoice.Contracts;
using Bussines.Layer.Invoice.Services;
using DomainEntity.DtoModels;
using DomainEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace faktor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly pishroContext _pishroContext;
        private readonly ICustomerServices _customerServices;
        public CustomerController(pishroContext pishroContext,ICustomerServices customerServices )
        {
            _pishroContext = pishroContext;
            _customerServices = customerServices;

        }
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(AddCustomerDto addCustomerDto)
        {
          
        var add=await    _customerServices.AddCustomer(addCustomerDto);

            return Ok(new { CustomerId = add.customerid,Code= add.code,Message= add.message });


        }
        [HttpPost("GetAllCustomer")]
        public async Task<IActionResult> GetAllCustomer()
        {

            var load = await _customerServices.GetAllCustomer();

            return Ok(new {Code = load.code, Message = load.message, CustomerId = load.list});


        }

    }
}
