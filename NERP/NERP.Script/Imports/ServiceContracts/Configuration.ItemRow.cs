
namespace NERP.Configuration
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class ItemRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string NameProperty = "Name";
        [InlineConstant] public const string LocalTextPrefix = "Configuration.Item";
        [InlineConstant] public const string LookupKey = "Configuration.Item";
    
        public static Lookup<ItemRow> Lookup { [InlineCode("Q.getLookup('Configuration.Item')")] get { return null; } }
    
        public Int32? ItemGroupId { get; set; }
        public Int32? UomId { get; set; }
        public Int32? SpecificationId { get; set; }
        public Int32? ColorId { get; set; }
        public Int32? SizeId { get; set; }
        public Int32? ModelId { get; set; }
        public Int32? StyleId { get; set; }
        public Int32? BrandId { get; set; }
        public Int32? CountryId { get; set; }
        public Int32? SeasonId { get; set; }
        public Int32? PurposeId { get; set; }
        public Int32? SupplierId { get; set; }
        public Int32? ConditionId { get; set; }
        public Int32? QualityId { get; set; }
        public Int32? Year { get; set; }
        public String ExpireDate { get; set; }
        public Int32? LifeTime { get; set; }
        public String Barcode { get; set; }
        public Decimal? UnitWeight { get; set; }
        public Int32? WeightUomId { get; set; }
        public Decimal? ReorderLevel { get; set; }
        public Decimal? CostPrice { get; set; }
        public Decimal? SellingPrice { get; set; }
        public Decimal? PromoPrice { get; set; }
        public String PromoStartDate { get; set; }
        public String PromoEndDate { get; set; }
        public Decimal? CommissionAmt { get; set; }
        public Int16? IsCommissionPercent { get; set; }
        public Int16? IsTaxInclude { get; set; }
        public Int16? IsOverrideTax { get; set; }
        public String Tax1 { get; set; }
        public String Tax2 { get; set; }
        public String Tax3 { get; set; }
        public String Tax4 { get; set; }
        public String Tax5 { get; set; }
        public Decimal? Tax1Rate { get; set; }
        public Decimal? Tax2Rate { get; set; }
        public Decimal? Tax3Rate { get; set; }
        public Decimal? Tax4Rate { get; set; }
        public Decimal? Tax5Rate { get; set; }
        public Decimal? DefaultQty { get; set; }
        public String DefaultLocationAtStore { get; set; }
        public String UomName { get; set; }
        public String SpecificationName { get; set; }
        public String ColorName { get; set; }
        public String SizeName { get; set; }
        public String ModelName { get; set; }
        public String StyleName { get; set; }
        public String BrandName { get; set; }
        public String CountryName { get; set; }
        public String SupplierName { get; set; }
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
            [InlineConstant] public const string ItemGroupId = "ItemGroupId";
            [InlineConstant] public const string UomId = "UomId";
            [InlineConstant] public const string SpecificationId = "SpecificationId";
            [InlineConstant] public const string ColorId = "ColorId";
            [InlineConstant] public const string SizeId = "SizeId";
            [InlineConstant] public const string ModelId = "ModelId";
            [InlineConstant] public const string StyleId = "StyleId";
            [InlineConstant] public const string BrandId = "BrandId";
            [InlineConstant] public const string CountryId = "CountryId";
            [InlineConstant] public const string SeasonId = "SeasonId";
            [InlineConstant] public const string PurposeId = "PurposeId";
            [InlineConstant] public const string SupplierId = "SupplierId";
            [InlineConstant] public const string ConditionId = "ConditionId";
            [InlineConstant] public const string QualityId = "QualityId";
            [InlineConstant] public const string Year = "Year";
            [InlineConstant] public const string ExpireDate = "ExpireDate";
            [InlineConstant] public const string LifeTime = "LifeTime";
            [InlineConstant] public const string Barcode = "Barcode";
            [InlineConstant] public const string UnitWeight = "UnitWeight";
            [InlineConstant] public const string WeightUomId = "WeightUomId";
            [InlineConstant] public const string ReorderLevel = "ReorderLevel";
            [InlineConstant] public const string CostPrice = "CostPrice";
            [InlineConstant] public const string SellingPrice = "SellingPrice";
            [InlineConstant] public const string PromoPrice = "PromoPrice";
            [InlineConstant] public const string PromoStartDate = "PromoStartDate";
            [InlineConstant] public const string PromoEndDate = "PromoEndDate";
            [InlineConstant] public const string CommissionAmt = "CommissionAmt";
            [InlineConstant] public const string IsCommissionPercent = "IsCommissionPercent";
            [InlineConstant] public const string IsTaxInclude = "IsTaxInclude";
            [InlineConstant] public const string IsOverrideTax = "IsOverrideTax";
            [InlineConstant] public const string Tax1 = "Tax1";
            [InlineConstant] public const string Tax2 = "Tax2";
            [InlineConstant] public const string Tax3 = "Tax3";
            [InlineConstant] public const string Tax4 = "Tax4";
            [InlineConstant] public const string Tax5 = "Tax5";
            [InlineConstant] public const string Tax1Rate = "Tax1Rate";
            [InlineConstant] public const string Tax2Rate = "Tax2Rate";
            [InlineConstant] public const string Tax3Rate = "Tax3Rate";
            [InlineConstant] public const string Tax4Rate = "Tax4Rate";
            [InlineConstant] public const string Tax5Rate = "Tax5Rate";
            [InlineConstant] public const string DefaultQty = "DefaultQty";
            [InlineConstant] public const string DefaultLocationAtStore = "DefaultLocationAtStore";
            [InlineConstant] public const string UomName = "UomName";
            [InlineConstant] public const string SpecificationName = "SpecificationName";
            [InlineConstant] public const string ColorName = "ColorName";
            [InlineConstant] public const string SizeName = "SizeName";
            [InlineConstant] public const string ModelName = "ModelName";
            [InlineConstant] public const string StyleName = "StyleName";
            [InlineConstant] public const string BrandName = "BrandName";
            [InlineConstant] public const string CountryName = "CountryName";
            [InlineConstant] public const string SupplierName = "SupplierName";
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

