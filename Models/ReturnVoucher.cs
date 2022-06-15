//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReturnVoucher
    {
        public ReturnVoucher()
        {
            this.ReturnVoucherDetails = new HashSet<ReturnVoucherDetail>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> DesignationID { get; set; }
        public string Lab { get; set; }
        public string Project { get; set; }
        public string ReturnByName { get; set; }
        public string ReturnByDesignation { get; set; }
        public string CatByName { get; set; }
        public string CatByDesignation { get; set; }
        public string ReturnBySignature { get; set; }
    
        public virtual RefDesignation RefDesignation { get; set; }
        public virtual ICollection<ReturnVoucherDetail> ReturnVoucherDetails { get; set; }
    }
}
