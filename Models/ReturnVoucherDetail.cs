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
    
    public partial class ReturnVoucherDetail
    {
        public long ID { get; set; }
        public string LeaderPageNo { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string QTYUS { get; set; }
        public string QTYS { get; set; }
        public Nullable<long> ReturnVoucherID { get; set; }
    
        public virtual ReturnVoucher ReturnVoucher { get; set; }
    }
}
