//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GRNApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HeaderDetail
    {
        public int InvoiceNumber { get; set; }
        public Nullable<int> CustomerInvoice { get; set; }
        public Nullable<int> RejectedUnits { get; set; }
        public Nullable<int> RecivedUnits { get; set; }
        public Nullable<decimal> RecivedAmounts { get; set; }
    }
}
