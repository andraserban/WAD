//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WADserver.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderTable
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    
        public virtual ProductTable ProductTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
