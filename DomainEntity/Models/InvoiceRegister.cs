// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomainEntity.Models;

public partial class InvoiceRegister
{
    [Key]
    public int InvoiceRegisterId { get; set; }

    public int InvoiceId { get; set; }

    [Required]
    [StringLength(50)]
    public string ProductName { get; set; }
    public Boolean IsDeleted { get; set; }
    public int ProductNumber { get; set; }
    public int ProductCost { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("InvoiceRegister")]
    public virtual Invoices Invoice { get; set; }
}