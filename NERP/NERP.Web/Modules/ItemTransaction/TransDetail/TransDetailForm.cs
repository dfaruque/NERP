
namespace NERP.ItemTransaction.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ItemTransaction.TransDetail")]
    [BasedOnRow(typeof(Entities.TransDetailRow))]
    public class TransDetailForm
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Int32 TransId { get; set; }
        public Int32 TransTypeId { get; set; }
        public Int32 ItemId { get; set; }
        public Int32 ItemDetailId { get; set; }
        public Int32 UomId { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal SampleQty { get; set; }
        public Decimal OverQty { get; set; }
        public Decimal LineTotalQty { get; set; }
        public Decimal MaxQty { get; set; }
        public Decimal BalanceQty { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal Amount { get; set; }
        public Decimal TaxAmt { get; set; }
        public Decimal DiscountAmt { get; set; }
        public Decimal LineTotalAmt { get; set; }
        public Int16 IsReturn { get; set; }
        public Int16 IsOffer { get; set; }
        public Int32 OfferParentId { get; set; }
        public Int32 AccId { get; set; }
        public Int16 IsDebit { get; set; }
        public Decimal DrAmt { get; set; }
        public Decimal CrAmt { get; set; }
        public Int32 RefTypeId { get; set; }
        public Int32 RefId { get; set; }
        public Int32 RefDtlId { get; set; }
        public String RefCode { get; set; }
        public String RefNo { get; set; }
        public Int32 RefImgId { get; set; }
        public Int32 TransRefTypeId { get; set; }
        public Int32 TransRefId { get; set; }
        public Int32 TransRefDtlId { get; set; }
        public String TransRefCode { get; set; }
        public String TransRefNo { get; set; }
        public Int32 TransRefImgId { get; set; }
        public String Note { get; set; }
        //public Int32 ProjectId { get; set; }
        //public Int32 OrganogramId { get; set; }
        //public Int32 ScopeId { get; set; }
        //public Int32 CompanyId { get; set; }
        //public Int32 StatusId { get; set; }
        //public Int16 IsApproved { get; set; }
        //public DateTime ApprovedOn { get; set; }
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