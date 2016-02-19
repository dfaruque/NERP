
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
        public LookupEditor UomId { get { return ById<LookupEditor>("UomId"); } }
        public LookupEditor SpecificationId { get { return ById<LookupEditor>("SpecificationId"); } }
        public LookupEditor ColorId { get { return ById<LookupEditor>("ColorId"); } }
        public LookupEditor SizeId { get { return ById<LookupEditor>("SizeId"); } }
        public LookupEditor ModelId { get { return ById<LookupEditor>("ModelId"); } }
        public LookupEditor StyleId { get { return ById<LookupEditor>("StyleId"); } }
        public LookupEditor BrandId { get { return ById<LookupEditor>("BrandId"); } }
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
    }
}

