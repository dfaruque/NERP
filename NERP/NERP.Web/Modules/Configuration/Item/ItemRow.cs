
namespace NERP.Configuration.Entities
{
    using Serenity.Services; using NERP.Common;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Item"), InstanceName("Item"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Item", Permission = "?")]

    public sealed class ItemRow : BaseRow
    {

        [DisplayName("Item Group Id"), Column("Item_Group_Id")]
        public Int32? ItemGroupId
        {
            get { return Fields.ItemGroupId[this]; }
            set { Fields.ItemGroupId[this] = value; }
        }

        [DisplayName("Uom"), Column("Uom_Id"), ForeignKey("[dbo].[Uom]", "Id"), LeftJoin("jUom"), TextualField("UomCode")]
        [LookupEditor(typeof(UomRow),InplaceAdd=true)]
        public Int32? UomId
        {
            get { return Fields.UomId[this]; }
            set { Fields.UomId[this] = value; }
        }

        //[DisplayName("Image"), Column("Image_Id"), ForeignKey("[dbo].[Image]", "Id"), LeftJoin("jImage"), TextualField("ImageCode")]
        //public Int32? ImageId
        //{
        //    get { return Fields.ImageId[this]; }
        //    set { Fields.ImageId[this] = value; }
        //}

        [DisplayName("Specification"), Column("Specification_Id"), ForeignKey("[Itm].[Specification]", "Id"), LeftJoin("jSpecification"), TextualField("SpecificationCode")]
        [LookupEditor(typeof(SpecificationRow),InplaceAdd=true)]
        public Int32? SpecificationId
        {
            get { return Fields.SpecificationId[this]; }
            set { Fields.SpecificationId[this] = value; }
        }

        [DisplayName("Color"), Column("Color_Id"), ForeignKey("[Itm].[Color]", "Id"), LeftJoin("jColor"), TextualField("ColorCode")]
        [LookupEditor(typeof(ColorRow), InplaceAdd = true)]
        public Int32? ColorId
        {
            get { return Fields.ColorId[this]; }
            set { Fields.ColorId[this] = value; }
        }

        [DisplayName("Size"), Column("Size_Id"), ForeignKey("[Itm].[Size]", "Id"), LeftJoin("jSize"), TextualField("SizeCode")]
        [LookupEditor(typeof(SizeRow), InplaceAdd = true)]
        public Int32? SizeId
        {
            get { return Fields.SizeId[this]; }
            set { Fields.SizeId[this] = value; }
        }

        [DisplayName("Model"), Column("Model_Id"), ForeignKey("[Itm].[Model]", "Id"), LeftJoin("jModel"), TextualField("ModelCode")]
        [LookupEditor(typeof(ModelRow), InplaceAdd = true)]
        public Int32? ModelId
        {
            get { return Fields.ModelId[this]; }
            set { Fields.ModelId[this] = value; }
        }

        [DisplayName("Style"), Column("Style_Id"), ForeignKey("[Itm].[Style]", "Id"), LeftJoin("jStyle"), TextualField("StyleCode")]
        [LookupEditor(typeof(StyleRow), InplaceAdd = true)]
        public Int32? StyleId
        {
            get { return Fields.StyleId[this]; }
            set { Fields.StyleId[this] = value; }
        }

        [DisplayName("Brand"), Column("Brand_Id"), ForeignKey("[Itm].[Brand]", "Id"), LeftJoin("jBrand"), TextualField("BrandCode")]
        [LookupEditor(typeof(BrandRow), InplaceAdd = true)]
        public Int32? BrandId
        {
            get { return Fields.BrandId[this]; }
            set { Fields.BrandId[this] = value; }
        }

        [DisplayName("Country"), Column("Country_Id"), ForeignKey("[dbo].[Address_Country]", "Id"), LeftJoin("jCountry"), TextualField("CountryCode")]
        //[LookupEditor(typeof())]
        [Visible(false)]
        public Int32? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }

        [DisplayName("Season Id"), Column("Season_Id")]
        [Visible(false)]
        public Int32? SeasonId
        {
            get { return Fields.SeasonId[this]; }
            set { Fields.SeasonId[this] = value; }
        }

        [DisplayName("Purpose Id"), Column("Purpose_Id")]
        [Visible(false)]
        public Int32? PurposeId
        {
            get { return Fields.PurposeId[this]; }
            set { Fields.PurposeId[this] = value; }
        }

        [DisplayName("Supplier"), Column("Supplier_Id"), ForeignKey("[Pur].[Supplier]", "Id"), LeftJoin("jSupplier"), TextualField("SupplierCode")]
        [Visible(false)]
        public Int32? SupplierId
        {
            get { return Fields.SupplierId[this]; }
            set { Fields.SupplierId[this] = value; }
        }

        [DisplayName("Condition Id"), Column("Condition_Id")]
        [Visible(false)]
        public Int32? ConditionId
        {
            get { return Fields.ConditionId[this]; }
            set { Fields.ConditionId[this] = value; }
        }

        [DisplayName("Quality Id"), Column("Quality_Id")]
        [Visible(false)]
        public Int32? QualityId
        {
            get { return Fields.QualityId[this]; }
            set { Fields.QualityId[this] = value; }
        }

        [DisplayName("Year")]
        [Visible(false)]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
        }

        [DisplayName("Expire Date"), Column("Expire_Date")]
        [Visible(false)]
        public DateTime? ExpireDate
        {
            get { return Fields.ExpireDate[this]; }
            set { Fields.ExpireDate[this] = value; }
        }

        [DisplayName("Life Time"), Column("Life_Time")]
        [Visible(false)]
        public Int32? LifeTime
        {
            get { return Fields.LifeTime[this]; }
            set { Fields.LifeTime[this] = value; }
        }

        [DisplayName("Barcode"), Size(150)]
        public String Barcode
        {
            get { return Fields.Barcode[this]; }
            set { Fields.Barcode[this] = value; }
        }

        [DisplayName("Unit Weight"), Column("Unit_Weight"), Size(18), Scale(Statics.DecimalLength)]
        [Visible(false)]
        public Decimal? UnitWeight
        {
            get { return Fields.UnitWeight[this]; }
            set { Fields.UnitWeight[this] = value; }
        }

        [DisplayName("Weight Uom Id"), Column("Weight_Uom_Id")]
        [Visible(false)]
        public Int32? WeightUomId
        {
            get { return Fields.WeightUomId[this]; }
            set { Fields.WeightUomId[this] = value; }
        }

        [DisplayName("Reorder Level"), Column("Reorder_Level"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? ReorderLevel
        {
            get { return Fields.ReorderLevel[this]; }
            set { Fields.ReorderLevel[this] = value; }
        }

        [DisplayName("Cost Price"), Column("Cost_Price"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? CostPrice
        {
            get { return Fields.CostPrice[this]; }
            set { Fields.CostPrice[this] = value; }
        }

        [DisplayName("Selling Price"), Column("Selling_Price"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? SellingPrice
        {
            get { return Fields.SellingPrice[this]; }
            set { Fields.SellingPrice[this] = value; }
        }

        [DisplayName("Promo Price"), Column("Promo_Price"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? PromoPrice
        {
            get { return Fields.PromoPrice[this]; }
            set { Fields.PromoPrice[this] = value; }
        }

        [DisplayName("Promo Start Date"), Column("Promo_Start_Date")]
        [Visible(false)]
        public DateTime? PromoStartDate
        {
            get { return Fields.PromoStartDate[this]; }
            set { Fields.PromoStartDate[this] = value; }
        }

        [DisplayName("Promo End Date"), Column("Promo_End_Date")]
        [Visible(false)]
        public DateTime? PromoEndDate
        {
            get { return Fields.PromoEndDate[this]; }
            set { Fields.PromoEndDate[this] = value; }
        }

        [DisplayName("Commission Amt"), Column("Commission_Amt"), Size(18), Scale(Statics.DecimalLength)]
        [Visible(false)]
        public Decimal? CommissionAmt
        {
            get { return Fields.CommissionAmt[this]; }
            set { Fields.CommissionAmt[this] = value; }
        }

        [DisplayName("Is Commission Percent"), Column("Is_Commission_Percent")]
        [Visible(false)]
        public Int16? IsCommissionPercent
        {
            get { return Fields.IsCommissionPercent[this]; }
            set { Fields.IsCommissionPercent[this] = value; }
        }

        [DisplayName("Is Tax Include"), Column("Is_Tax_Include")]
        [Visible(false)]
        public Int16? IsTaxInclude
        {
            get { return Fields.IsTaxInclude[this]; }
            set { Fields.IsTaxInclude[this] = value; }
        }

        [DisplayName("Is Override Tax"), Column("Is_Override_Tax")]
        [Visible(false)]
        public Int16? IsOverrideTax
        {
            get { return Fields.IsOverrideTax[this]; }
            set { Fields.IsOverrideTax[this] = value; }
        }

        [DisplayName("Tax1"), Size(50)]
        [Visible(false)]
        public String Tax1
        {
            get { return Fields.Tax1[this]; }
            set { Fields.Tax1[this] = value; }
        }

        [DisplayName("Tax2"), Size(50)]
        [Visible(false)]
        public String Tax2
        {
            get { return Fields.Tax2[this]; }
            set { Fields.Tax2[this] = value; }
        }

        [DisplayName("Tax3"), Size(50)]
        [Visible(false)]
        public String Tax3
        {
            get { return Fields.Tax3[this]; }
            set { Fields.Tax3[this] = value; }
        }

        [DisplayName("Tax4"), Size(50)]
        [Visible(false)]
        public String Tax4
        {
            get { return Fields.Tax4[this]; }
            set { Fields.Tax4[this] = value; }
        }

        [DisplayName("Tax5"), Size(50)]
        [Visible(false)]
        public String Tax5
        {
            get { return Fields.Tax5[this]; }
            set { Fields.Tax5[this] = value; }
        }

        [DisplayName("Tax1 Rate"), Column("Tax1_Rate"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? Tax1Rate
        {
            get { return Fields.Tax1Rate[this]; }
            set { Fields.Tax1Rate[this] = value; }
        }

        [DisplayName("Tax2 Rate"), Column("Tax2_Rate"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? Tax2Rate
        {
            get { return Fields.Tax2Rate[this]; }
            set { Fields.Tax2Rate[this] = value; }
        }

        [DisplayName("Tax3 Rate"), Column("Tax3_Rate"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? Tax3Rate
        {
            get { return Fields.Tax3Rate[this]; }
            set { Fields.Tax3Rate[this] = value; }
        }

        [DisplayName("Tax4 Rate"), Column("Tax4_Rate"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? Tax4Rate
        {
            get { return Fields.Tax4Rate[this]; }
            set { Fields.Tax4Rate[this] = value; }
        }

        [DisplayName("Tax5 Rate"), Column("Tax5_Rate"), Size(18), Scale(Statics.DecimalLength), NotNull]
        [Visible(false)]
        public Decimal? Tax5Rate
        {
            get { return Fields.Tax5Rate[this]; }
            set { Fields.Tax5Rate[this] = value; }
        }

        [DisplayName("Default Qty"), Column("Default_Qty"), Size(18), Scale(Statics.DecimalLength)]
        [Visible(false)]
        public Decimal? DefaultQty
        {
            get { return Fields.DefaultQty[this]; }
            set { Fields.DefaultQty[this] = value; }
        }

        [DisplayName("Default Location At Store"), Column("Default_Location_At_Store"), Size(50)]
        [Visible(false)]
        public String DefaultLocationAtStore
        {
            get { return Fields.DefaultLocationAtStore[this]; }
            set { Fields.DefaultLocationAtStore[this] = value; }
        }

        [DisplayName("Uom"), Expression("jUom.[Name]")]
        public String UomName
        {
            get { return Fields.UomName[this]; }
            set { Fields.UomName[this] = value; }
        }

        [DisplayName("Specification"), Expression("jSpecification.[Name]")]
        public String SpecificationName
        {
            get { return Fields.SpecificationName[this]; }
            set { Fields.SpecificationName[this] = value; }
        }

        [DisplayName("Color"), Expression("jColor.[Name]")]
        public String ColorName
        {
            get { return Fields.ColorName[this]; }
            set { Fields.ColorName[this] = value; }
        }

        [DisplayName("Size"), Expression("jSize.[Name]")]
        public String SizeName
        {
            get { return Fields.SizeName[this]; }
            set { Fields.SizeName[this] = value; }
        }

        [DisplayName("Model"), Expression("jModel.[Name]")]
        public String ModelName
        {
            get { return Fields.ModelName[this]; }
            set { Fields.ModelName[this] = value; }
        }

        [DisplayName("Style"), Expression("jStyle.[Name]")]
        public String StyleName
        {
            get { return Fields.StyleName[this]; }
            set { Fields.StyleName[this] = value; }
        }

        [DisplayName("Brand"), Expression("jBrand.[Name]")]
        public String BrandName
        {
            get { return Fields.BrandName[this]; }
            set { Fields.BrandName[this] = value; }
        }


        [DisplayName("Country"), Expression("jCountry.[Name]")]
        public String CountryName
        {
            get { return Fields.CountryName[this]; }
            set { Fields.CountryName[this] = value; }
        }


        [DisplayName("Supplier"), Expression("jSupplier.[Name]")]
        public String SupplierName
        {
            get { return Fields.SupplierName[this]; }
            set { Fields.SupplierName[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public ItemRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int32Field ItemGroupId;
            public readonly Int32Field UomId;
            //public readonly Int32Field ImageId;
            public readonly Int32Field SpecificationId;
            public readonly Int32Field ColorId;
            public readonly Int32Field SizeId;
            public readonly Int32Field ModelId;
            public readonly Int32Field StyleId;
            public readonly Int32Field BrandId;
            public readonly Int32Field CountryId;
            public readonly Int32Field SeasonId;
            public readonly Int32Field PurposeId;
            public readonly Int32Field SupplierId;
            public readonly Int32Field ConditionId;
            public readonly Int32Field QualityId;
            public readonly Int32Field Year;
            public readonly DateTimeField ExpireDate;
            public readonly Int32Field LifeTime;
            public readonly StringField Barcode;
            public readonly DecimalField UnitWeight;
            public readonly Int32Field WeightUomId;
            public readonly DecimalField ReorderLevel;
            public readonly DecimalField CostPrice;
            public readonly DecimalField SellingPrice;
            public readonly DecimalField PromoPrice;
            public readonly DateTimeField PromoStartDate;
            public readonly DateTimeField PromoEndDate;
            public readonly DecimalField CommissionAmt;
            public readonly Int16Field IsCommissionPercent;
            public readonly Int16Field IsTaxInclude;
            public readonly Int16Field IsOverrideTax;
            public readonly StringField Tax1;
            public readonly StringField Tax2;
            public readonly StringField Tax3;
            public readonly StringField Tax4;
            public readonly StringField Tax5;
            public readonly DecimalField Tax1Rate;
            public readonly DecimalField Tax2Rate;
            public readonly DecimalField Tax3Rate;
            public readonly DecimalField Tax4Rate;
            public readonly DecimalField Tax5Rate;
            public readonly DecimalField DefaultQty;
            public readonly StringField DefaultLocationAtStore;

            public readonly StringField UomName;

            public readonly StringField SpecificationName;

            public readonly StringField ColorName;

            public readonly StringField SizeName;

            public readonly StringField ModelName;

            public readonly StringField StyleName;

            public readonly StringField BrandName;

            public readonly StringField CountryName;

            public readonly StringField SupplierName;
            public RowFields()
                : base("[dbo].[Item]")
            {
                LocalTextPrefix = "Configuration.Item";
            }
        }
    }
}