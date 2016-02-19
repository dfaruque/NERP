
namespace NERP.Configuration
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class ItemForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Configuration.Item";

        public ItemForm(string idPrefix) : base(idPrefix) {}


        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public IntegerEditor ItemGroupId { get { return ById<IntegerEditor>("ItemGroupId"); } }
        public IntegerEditor UomId { get { return ById<IntegerEditor>("UomId"); } }
        public IntegerEditor ImageId { get { return ById<IntegerEditor>("ImageId"); } }
        public IntegerEditor SpecificationId { get { return ById<IntegerEditor>("SpecificationId"); } }
        public IntegerEditor ColorId { get { return ById<IntegerEditor>("ColorId"); } }
        public IntegerEditor SizeId { get { return ById<IntegerEditor>("SizeId"); } }
        public IntegerEditor ModelId { get { return ById<IntegerEditor>("ModelId"); } }
        public IntegerEditor StyleId { get { return ById<IntegerEditor>("StyleId"); } }
        public IntegerEditor BrandId { get { return ById<IntegerEditor>("BrandId"); } }
        public IntegerEditor CountryId { get { return ById<IntegerEditor>("CountryId"); } }
        public IntegerEditor SeasonId { get { return ById<IntegerEditor>("SeasonId"); } }
        public IntegerEditor PurposeId { get { return ById<IntegerEditor>("PurposeId"); } }
        public IntegerEditor SupplierId { get { return ById<IntegerEditor>("SupplierId"); } }
        public IntegerEditor ConditionId { get { return ById<IntegerEditor>("ConditionId"); } }
        public IntegerEditor QualityId { get { return ById<IntegerEditor>("QualityId"); } }
        public IntegerEditor Year { get { return ById<IntegerEditor>("Year"); } }
        public DateEditor ExpireDate { get { return ById<DateEditor>("ExpireDate"); } }
        public IntegerEditor LifeTime { get { return ById<IntegerEditor>("LifeTime"); } }
        public StringEditor Barcode { get { return ById<StringEditor>("Barcode"); } }
        public DecimalEditor UnitWeight { get { return ById<DecimalEditor>("UnitWeight"); } }
        public IntegerEditor WeightUomId { get { return ById<IntegerEditor>("WeightUomId"); } }
        public DecimalEditor ReorderLevel { get { return ById<DecimalEditor>("ReorderLevel"); } }
        public DecimalEditor CostPrice { get { return ById<DecimalEditor>("CostPrice"); } }
        public DecimalEditor SellingPrice { get { return ById<DecimalEditor>("SellingPrice"); } }
        public DecimalEditor PromoPrice { get { return ById<DecimalEditor>("PromoPrice"); } }
        public DateEditor PromoStartDate { get { return ById<DateEditor>("PromoStartDate"); } }
        public DateEditor PromoEndDate { get { return ById<DateEditor>("PromoEndDate"); } }
        public DecimalEditor CommissionAmt { get { return ById<DecimalEditor>("CommissionAmt"); } }
        public IntegerEditor IsCommissionPercent { get { return ById<IntegerEditor>("IsCommissionPercent"); } }
        public IntegerEditor IsTaxInclude { get { return ById<IntegerEditor>("IsTaxInclude"); } }
        public IntegerEditor IsOverrideTax { get { return ById<IntegerEditor>("IsOverrideTax"); } }
        public StringEditor Tax1 { get { return ById<StringEditor>("Tax1"); } }
        public StringEditor Tax2 { get { return ById<StringEditor>("Tax2"); } }
        public StringEditor Tax3 { get { return ById<StringEditor>("Tax3"); } }
        public StringEditor Tax4 { get { return ById<StringEditor>("Tax4"); } }
        public StringEditor Tax5 { get { return ById<StringEditor>("Tax5"); } }
        public DecimalEditor Tax1Rate { get { return ById<DecimalEditor>("Tax1Rate"); } }
        public DecimalEditor Tax2Rate { get { return ById<DecimalEditor>("Tax2Rate"); } }
        public DecimalEditor Tax3Rate { get { return ById<DecimalEditor>("Tax3Rate"); } }
        public DecimalEditor Tax4Rate { get { return ById<DecimalEditor>("Tax4Rate"); } }
        public DecimalEditor Tax5Rate { get { return ById<DecimalEditor>("Tax5Rate"); } }
        public DecimalEditor DefaultQty { get { return ById<DecimalEditor>("DefaultQty"); } }
        public StringEditor DefaultLocationAtStore { get { return ById<StringEditor>("DefaultLocationAtStore"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
        public IntegerEditor ProjectId { get { return ById<IntegerEditor>("ProjectId"); } }
        public IntegerEditor OrganogramId { get { return ById<IntegerEditor>("OrganogramId"); } }
        public IntegerEditor ScopeId { get { return ById<IntegerEditor>("ScopeId"); } }
        public IntegerEditor CompanyId { get { return ById<IntegerEditor>("CompanyId"); } }
        public IntegerEditor StatusId { get { return ById<IntegerEditor>("StatusId"); } }
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