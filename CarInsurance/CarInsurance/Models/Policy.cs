//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Policy
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Nullable<int> CarId { get; set; }
        public bool FullCoverage { get; set; }
        public Nullable<int> Tickets { get; set; }
        public bool DUI { get; set; }
    
        public virtual CarMake CarMake { get; set; }
        public virtual Person Person { get; set; }
    }
}