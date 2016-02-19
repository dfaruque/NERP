
namespace NERP.ItemTransaction
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class TransDetailRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string NameProperty = "Name";
        [InlineConstant] public const string LocalTextPrefix = "ItemTransaction.TransDetail";
    
        public Int32? TransId { get; set; }
        public Int32? TransTypeId { get; set; }
        public Int32? ItemId { get; set; }
        public Int32? ItemDetailId { get; set; }
        public Int32? UomId { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? SampleQty { get; set; }
        public Decimal? OverQty { get; set; }
        public Decimal? LineTotalQty { get; set; }
        public Decimal? MaxQty { get; set; }
        public Decimal? BalanceQty { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? TaxAmt { get; set; }
        public Decimal? DiscountAmt { get; set; }
        public Decimal? LineTotalAmt { get; set; }
        public Int16? IsReturn { get; set; }
        public Int16? IsOffer { get; set; }
        public Int32? OfferParentId { get; set; }
        public Int32? AccId { get; set; }
        public Int16? IsDebit { get; set; }
        public Decimal? DrAmt { get; set; }
        public Decimal? CrAmt { get; set; }
        public Int32? RefTypeId { get; set; }
        public Int32? RefId { get; set; }
        public Int32? RefDtlId { get; set; }
        public String RefCode { get; set; }
        public String RefNo { get; set; }
        public Int32? RefImgId { get; set; }
        public Int32? TransRefTypeId { get; set; }
        public Int32? TransRefId { get; set; }
        public Int32? TransRefDtlId { get; set; }
        public String TransRefCode { get; set; }
        public String TransRefNo { get; set; }
        public Int32? TransRefImgId { get; set; }
        public Int16? IsApproved { get; set; }
        public String ApprovedOn { get; set; }
        public String ItemName { get; set; }
        public String UomName { get; set; }
        public Int32? Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Note { get; set; }
        public Int32? ProjectId { get; set; }
        public String Project { get; set; }
        public Int32? OrganogramId { get; set; }
        public String Organogram { get; set; }
        public Int32? ScopeId { get; set; }
        public Int32? CompanyId { get; set; }
        public Int32? StatusId { get; set; }
        public String ActiveOn { get; set; }
        public String InactiveOn { get; set; }
        public Int16? IsActive { get; set; }
        public Int32? DbId { get; set; }
        public Int32? CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        public String CreatedPc { get; set; }
        public Int32? UpdatedBy { get; set; }
        public String UpdatedOn { get; set; }
        public String UpdatedPc { get; set; }
        public Int32? DeletedBy { get; set; }
        public String DeletedOn { get; set; }
        public String DeletedPc { get; set; }
        public Int16? IsDelete { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string TransId = "TransId";
            [InlineConstant] public const string TransTypeId = "TransTypeId";
            [InlineConstant] public const string ItemId = "ItemId";
            [InlineConstant] public const string ItemDetailId = "ItemDetailId";
            [InlineConstant] public const string UomId = "UomId";
            [InlineConstant] public const string Quantity = "Quantity";
            [InlineConstant] public const string SampleQty = "SampleQty";
            [InlineConstant] public const string OverQty = "OverQty";
            [InlineConstant] public const string LineTotalQty = "LineTotalQty";
            [InlineConstant] public const string MaxQty = "MaxQty";
            [InlineConstant] public const string BalanceQty = "BalanceQty";
            [InlineConstant] public const string UnitPrice = "UnitPrice";
            [InlineConstant] public const string Amount = "Amount";
            [InlineConstant] public const string TaxAmt = "TaxAmt";
            [InlineConstant] public const string DiscountAmt = "DiscountAmt";
            [InlineConstant] public const string LineTotalAmt = "LineTotalAmt";
            [InlineConstant] public const string IsReturn = "IsReturn";
            [InlineConstant] public const string IsOffer = "IsOffer";
            [InlineConstant] public const string OfferParentId = "OfferParentId";
            [InlineConstant] public const string AccId = "AccId";
            [InlineConstant] public const string IsDebit = "IsDebit";
            [InlineConstant] public const string DrAmt = "DrAmt";
            [InlineConstant] public const string CrAmt = "CrAmt";
            [InlineConstant] public const string RefTypeId = "RefTypeId";
            [InlineConstant] public const string RefId = "RefId";
            [InlineConstant] public const string RefDtlId = "RefDtlId";
            [InlineConstant] public const string RefCode = "RefCode";
            [InlineConstant] public const string RefNo = "RefNo";
            [InlineConstant] public const string RefImgId = "RefImgId";
            [InlineConstant] public const string TransRefTypeId = "TransRefTypeId";
            [InlineConstant] public const string TransRefId = "TransRefId";
            [InlineConstant] public const string TransRefDtlId = "TransRefDtlId";
            [InlineConstant] public const string TransRefCode = "TransRefCode";
            [InlineConstant] public const string TransRefNo = "TransRefNo";
            [InlineConstant] public const string TransRefImgId = "TransRefImgId";
            [InlineConstant] public const string IsApproved = "IsApproved";
            [InlineConstant] public const string ApprovedOn = "ApprovedOn";
            [InlineConstant] public const string ItemName = "ItemName";
            [InlineConstant] public const string UomName = "UomName";
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Code = "Code";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string Note = "Note";
            [InlineConstant] public const string ProjectId = "ProjectId";
            [InlineConstant] public const string Project = "Project";
            [InlineConstant] public const string OrganogramId = "OrganogramId";
            [InlineConstant] public const string Organogram = "Organogram";
            [InlineConstant] public const string ScopeId = "ScopeId";
            [InlineConstant] public const string CompanyId = "CompanyId";
            [InlineConstant] public const string StatusId = "StatusId";
            [InlineConstant] public const string ActiveOn = "ActiveOn";
            [InlineConstant] public const string InactiveOn = "InactiveOn";
            [InlineConstant] public const string IsActive = "IsActive";
            [InlineConstant] public const string DbId = "DbId";
            [InlineConstant] public const string CreatedBy = "CreatedBy";
            [InlineConstant] public const string CreatedOn = "CreatedOn";
            [InlineConstant] public const string CreatedPc = "CreatedPc";
            [InlineConstant] public const string UpdatedBy = "UpdatedBy";
            [InlineConstant] public const string UpdatedOn = "UpdatedOn";
            [InlineConstant] public const string UpdatedPc = "UpdatedPc";
            [InlineConstant] public const string DeletedBy = "DeletedBy";
            [InlineConstant] public const string DeletedOn = "DeletedOn";
            [InlineConstant] public const string DeletedPc = "DeletedPc";
            [InlineConstant] public const string IsDelete = "IsDelete";
        }
    }
    
}

