
namespace NERP.ItemTransaction
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class TransDetailForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "ItemTransaction.TransDetail";

        public TransDetailForm(string idPrefix) : base(idPrefix) {}


        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public IntegerEditor TransId { get { return ById<IntegerEditor>("TransId"); } }
        public IntegerEditor TransTypeId { get { return ById<IntegerEditor>("TransTypeId"); } }
        public IntegerEditor ItemId { get { return ById<IntegerEditor>("ItemId"); } }
        public IntegerEditor ItemDetailId { get { return ById<IntegerEditor>("ItemDetailId"); } }
        public IntegerEditor UomId { get { return ById<IntegerEditor>("UomId"); } }
        public DecimalEditor Quantity { get { return ById<DecimalEditor>("Quantity"); } }
        public DecimalEditor SampleQty { get { return ById<DecimalEditor>("SampleQty"); } }
        public DecimalEditor OverQty { get { return ById<DecimalEditor>("OverQty"); } }
        public DecimalEditor SubTotalQty { get { return ById<DecimalEditor>("SubTotalQty"); } }
        public DecimalEditor MaxQty { get { return ById<DecimalEditor>("MaxQty"); } }
        public DecimalEditor BalanceQty { get { return ById<DecimalEditor>("BalanceQty"); } }
        public DecimalEditor UnitPrice { get { return ById<DecimalEditor>("UnitPrice"); } }
        public DecimalEditor Amount { get { return ById<DecimalEditor>("Amount"); } }
        public DecimalEditor TaxAmt { get { return ById<DecimalEditor>("TaxAmt"); } }
        public DecimalEditor DiscountAmt { get { return ById<DecimalEditor>("DiscountAmt"); } }
        public DecimalEditor LineTotalAmt { get { return ById<DecimalEditor>("LineTotalAmt"); } }
        public IntegerEditor IsReturn { get { return ById<IntegerEditor>("IsReturn"); } }
        public IntegerEditor IsOffer { get { return ById<IntegerEditor>("IsOffer"); } }
        public IntegerEditor OfferParentId { get { return ById<IntegerEditor>("OfferParentId"); } }
        public IntegerEditor AccId { get { return ById<IntegerEditor>("AccId"); } }
        public IntegerEditor IsDebit { get { return ById<IntegerEditor>("IsDebit"); } }
        public DecimalEditor DrAmt { get { return ById<DecimalEditor>("DrAmt"); } }
        public DecimalEditor CrAmt { get { return ById<DecimalEditor>("CrAmt"); } }
        public IntegerEditor RefTypeId { get { return ById<IntegerEditor>("RefTypeId"); } }
        public IntegerEditor RefId { get { return ById<IntegerEditor>("RefId"); } }
        public IntegerEditor RefDtlId { get { return ById<IntegerEditor>("RefDtlId"); } }
        public StringEditor RefCode { get { return ById<StringEditor>("RefCode"); } }
        public StringEditor RefNo { get { return ById<StringEditor>("RefNo"); } }
        public IntegerEditor RefImgId { get { return ById<IntegerEditor>("RefImgId"); } }
        public IntegerEditor TransRefTypeId { get { return ById<IntegerEditor>("TransRefTypeId"); } }
        public IntegerEditor TransRefId { get { return ById<IntegerEditor>("TransRefId"); } }
        public IntegerEditor TransRefDtlId { get { return ById<IntegerEditor>("TransRefDtlId"); } }
        public StringEditor TransRefCode { get { return ById<StringEditor>("TransRefCode"); } }
        public StringEditor TransRefNo { get { return ById<StringEditor>("TransRefNo"); } }
        public IntegerEditor TransRefImgId { get { return ById<IntegerEditor>("TransRefImgId"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
        public IntegerEditor ProjectId { get { return ById<IntegerEditor>("ProjectId"); } }
        public IntegerEditor OrganogramId { get { return ById<IntegerEditor>("OrganogramId"); } }
        public IntegerEditor ScopeId { get { return ById<IntegerEditor>("ScopeId"); } }
        public IntegerEditor CompanyId { get { return ById<IntegerEditor>("CompanyId"); } }
        public IntegerEditor StatusId { get { return ById<IntegerEditor>("StatusId"); } }
        public IntegerEditor IsApproved { get { return ById<IntegerEditor>("IsApproved"); } }
        public DateEditor ApprovedOn { get { return ById<DateEditor>("ApprovedOn"); } }
        public DateEditor ActiveOn { get { return ById<DateEditor>("ActiveOn"); } }
        public DateEditor InactiveOn { get { return ById<DateEditor>("InactiveOn"); } }
        public IntegerEditor IsActive { get { return ById<IntegerEditor>("IsActive"); } }
        public IntegerEditor DbId { get { return ById<IntegerEditor>("DbId"); } }
        public IntegerEditor CreatedBy { get { return ById<IntegerEditor>("CreatedBy"); } }
        public DateEditor CreatedOn { get { return ById<DateEditor>("CreatedOn"); } }
        public StringEditor CreatedPc { get { return ById<StringEditor>("CreatedPc"); } }
        public IntegerEditor UpdatedBy { get { return ById<IntegerEditor>("UpdatedBy"); } }
        public DateEditor UpdatedOn { get { return ById<DateEditor>("UpdatedOn"); } }
        public StringEditor UpdatedPc { get { return ById<StringEditor>("UpdatedPc"); } }
        public IntegerEditor DeletedBy { get { return ById<IntegerEditor>("DeletedBy"); } }
        public DateEditor DeletedOn { get { return ById<DateEditor>("DeletedOn"); } }
        public StringEditor DeletedPc { get { return ById<StringEditor>("DeletedPc"); } }
        public IntegerEditor IsDelete { get { return ById<IntegerEditor>("IsDelete"); } }
    }
}