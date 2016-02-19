
namespace NERP.Configuration.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Configuration.Item")]
    [BasedOnRow(typeof(Entities.ItemRow))]
    public class ItemColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId")]
        public Int32 Id { get; set; }
        [EditLink]
        public String Code { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String Description { get; set; }
        public Int32 ItemGroupId { get; set; }
        public Int32 UomId { get; set; }
        public Int32 ImageId { get; set; }
        public Int32 SpecificationId { get; set; }
        public Int32 ColorId { get; set; }
        public Int32 SizeId { get; set; }
        public Int32 ModelId { get; set; }
        public Int32 StyleId { get; set; }
        public Int32 BrandId { get; set; }
        public Int32 CountryId { get; set; }
        public Int32 SeasonId { get; set; }
        public Int32 PurposeId { get; set; }
        public Int32 SupplierId { get; set; }
        public Int32 ConditionId { get; set; }
        public Int32 QualityId { get; set; }
        public Int32 Year { get; set; }
        public DateTime ExpireDate { get; set; }
        public Int32 LifeTime { get; set; }
        public String Barcode { get; set; }
        public Decimal UnitWeight { get; set; }
        public Int32 WeightUomId { get; set; }
        public Decimal ReorderLevel { get; set; }
        public Decimal CostPrice { get; set; }
        public Decimal SellingPrice { get; set; }
        public Decimal PromoPrice { get; set; }
        public DateTime PromoStartDate { get; set; }
        public DateTime PromoEndDate { get; set; }
        public Decimal CommissionAmt { get; set; }
        public Int16 IsCommissionPercent { get; set; }
        public Int16 IsTaxInclude { get; set; }
        public Int16 IsOverrideTax { get; set; }
        public String Tax1 { get; set; }
        public String Tax2 { get; set; }
        public String Tax3 { get; set; }
        public String Tax4 { get; set; }
        public String Tax5 { get; set; }
        public Decimal Tax1Rate { get; set; }
        public Decimal Tax2Rate { get; set; }
        public Decimal Tax3Rate { get; set; }
        public Decimal Tax4Rate { get; set; }
        public Decimal Tax5Rate { get; set; }
        public Decimal DefaultQty { get; set; }
        public String DefaultLocationAtStore { get; set; }
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