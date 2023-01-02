using Bussines.Layer.Customers.Contracts;
using Bussines.Layer.Customers.Services;
using Bussines.Layer.Invoice.Contracts;
using Bussines.Layer.Invoice.Services;
using Bussines.Layer.InvoiceRegisters.Contracts;
using Bussines.Layer.InvoiceRegisters.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCollection.Invoice
{
    public static class InvoiceServiceConfig
    {
        public static IServiceCollection InvoiceService(this IServiceCollection services)
        {
            services.AddScoped<IInvoiceServices,InvoiceServices>();

            services.AddScoped<ICustomerServices, CustomerServices>();
            services.AddScoped<IInvoiceRegisterServices, InvoiceRegisterServices>();

            return services;
        }
    }
}
