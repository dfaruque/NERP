
namespace NERP.Inventory.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventory.Stock")]
    [BasedOnRow(typeof(Entities.StockRow))]
    public class StockForm
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String ItemId { get; set; }
        public String ItemDetailId { get; set; }
        public String UomId { get; set; }
        public Decimal OpeningStock { get; set; }
        public Decimal OpeningStockVal { get; set; }
        public Decimal ReceivedQty { get; set; }
        public Decimal ReceivedVal { get; set; }
        public Decimal DeliveredQty { get; set; }
        public Decimal DeliveredVal { get; set; }
        public Decimal CurrentStock { get; set; }
        public Decimal CurrentStockVal { get; set; }
        public DateTime OpeningStockDate { get; set; }
        public DateTime LastReceivedDate { get; set; }
        public DateTime LastDeliveredDate { get; set; }
        public String Note { get; set; }
        //public Int32 ProjectId { get; set; }
        //public Int32 OrganogramId { get; set; }
        //public Int32 ScopeId { get; set; }
        //public Int32 CompanyId { get; set; }
        //public Int32 StatusId { get; set; }
        //public DateTime ActiveOn { get; set; }
        //public DateTime InactiveOn { get; set; }
        //public Int16 IsActive { get; set; }
        //public Int32 DbId { get; set; }
        //public Int32 CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public String CreatedPc { get; set; }
        //public Int32 UpdatedBy { get; set; }
        //public DateTime UpdatedOn { get; set; }
        //public String UpdatedPc { get; set; }
        //public Int32 DeletedBy { get; set; }
        //public DateTime DeletedOn { get; set; }
        //public String DeletedPc { get; set; }
        //public Int16 IsDelete { get; set; }
    }
}