﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomainEntity.Models;

public partial class Invoices
{
    [Key]
    public int InvoiceId { get; set; }

    [Required]
    [StringLength(50)]
    public string InvoiceName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceCustomer> InvoiceCustomer { get; } = new List<InvoiceCustomer>();

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceRegister> InvoiceRegister { get; } = new List<InvoiceRegister>();
}