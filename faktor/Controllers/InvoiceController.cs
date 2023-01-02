using Bussines.Layer.Invoice.Contracts;
using Bussines.Layer.InvoiceRegisters.Contracts;
using DomainEntity.DtoModels;
using DomainEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace faktor.Controllers
{
    //
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly pishroContext _pishroContext;
        private readonly IInvoiceServices _invoiceServices;
        private readonly IInvoiceRegisterServices _invoiceRegisterServices;
        public InvoiceController( pishroContext pishroContext,IInvoiceServices invoiceServices,IInvoiceRegisterServices invoiceRegisterServices)
        {
            _pishroContext = pishroContext;
            _invoiceServices = invoiceServices;
            _invoiceRegisterServices = invoiceRegisterServices;

        }
        [HttpGet("GenerateInvoiceNumber")]
       public async Task<IActionResult> GenerateInvoiceNumber(string InvoiceName)
        {
         int InvoiceNumber=await   _invoiceServices.GenerateInvoiceNumber(InvoiceName);
            if (InvoiceNumber == 0)
            {
            return Ok(new { InvoiceNumber = 0,Message="server error" });


            }
            return Ok(new { InvoiceNumber = InvoiceNumber, Message = "Success" });


        }
        [HttpPost("AddInvoiceProduct")]
        public async Task<IActionResult> AddInvoice(AddInvoiceRegisterDto addInvoiceRegisterDto)
        {
          var add = await _invoiceRegisterServices.AddInvoiceProduct(addInvoiceRegisterDto);
            return Ok(new { code = add.code, Message = add.message});


        }
        [HttpPost("UpdateInvoiceProduct")]
        public async Task<IActionResult> UpdateInvoiceProduct(UpdateInvoiceRegisterDto updateInvoiceRegisterDto)
        {
            var add = await _invoiceRegisterServices.UpdateInvoiceProduct(updateInvoiceRegisterDto);
            return Ok(new { code = add.code, Message = add.message });


        }
        [HttpDelete("DeleteInvoiceProduct")]
        public async Task<IActionResult> DeleteInvoiceProduct(int invoiceRegisterId)
        {
            var Submit = await _invoiceRegisterServices.DeleteInvoiceProduct(invoiceRegisterId);
            return Ok(new { code = Submit.code, Message = Submit.message });


        }

        [HttpGet("GetAllInvoiceProduct")]
        public async Task<IActionResult> GetAllInvoiceProduct()
        {
            var load = await _invoiceRegisterServices.GetAllInvoiceProduct();
            return Ok(new {load.list, code = load.code, Message = load.message });


        }
        [HttpGet("GetAllByInvoiceNumber")]
        public async Task<IActionResult> GetAllByInvoiceNumber(int invoiceNumber)
        {
            var load = await _invoiceRegisterServices.GetAllByInvoiceNumber(invoiceNumber);
            return Ok(new { load.list, code = load.code, Message = load.message });


        }

        [HttpGet("SubmitInvoiceToCustomer")]
        public async Task<IActionResult> SubmitInvoiceToCustomer(int InvoiceNumber, int Customerid)
        {
            var Submit = await _invoiceRegisterServices.SubmitInvoiceToCustomer(InvoiceNumber,Customerid);
            return Ok(new { code = Submit.code, Message = Submit.message });


        }
       
    }
    
    


}
