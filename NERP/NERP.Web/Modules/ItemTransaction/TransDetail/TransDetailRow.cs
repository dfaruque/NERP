
namespace NERP.ItemTransaction.Entities
{
    using NERP.Common;
    using NERP.Configuration.Entities;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Trans_Detail"), InstanceName("Trans_Detail"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class TransDetailRow : BaseRow
    {
        [DisplayName("Id"), PrimaryKey, Identity]
        public new Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }
        public new String Name //Hide purpose
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        
        [DisplayName("Trans"), Column("Trans_Id"), ForeignKey("[dbo].[Trans]", "Id"), LeftJoin("jTrans"), TextualField("TransCode")]
        public Int32? TransId
        {
            get { return Fields.TransId[this]; }
            set { Fields.TransId[this] = value; }
        }

        [DisplayName("Trans Type Id"), Column("Trans_Type_Id")]
        public Int32? TransTypeId
        {
            get { return Fields.TransTypeId[this]; }
            set { Fields.TransTypeId[this] = value; }
        }

        [DisplayName("Item"), Column("Item_Id"), NotNull, ForeignKey("[dbo].[Item]", "Id"), LeftJoin("jItem")]
        [LookupEditor(typeof(ItemRow),InplaceAdd=true)]
        public Int32? ItemId
        {
            get { return Fields.ItemId[this]; }
            set { Fields.ItemId[this] = value; }
        }
        [DisplayName("Item"), Expression("jItem.[Name]"), MinSelectLevel(SelectLevel.List)]
        [EditLink]
        public string ItemName
        {
            get { return Fields.ItemName[this]; }
            set { Fields.ItemName[this] = value; }
        }

        [DisplayName("Item Detail Id"), Column("Item_Detail_Id")]
        [Visible(false)]
        public Int32? ItemDetailId
        {
            get { return Fields.ItemDetailId[this]; }
            set { Fields.ItemDetailId[this] = value; }
        }

        [DisplayName("Uom"), Column("Uom_Id"), ForeignKey("[dbo].[Uom]", "Id"), LeftJoin("jUom")]
        [LookupEditor(typeof(UomRow),InplaceAdd=true)]
        public Int32? UomId
        {
            get { return Fields.UomId[this]; }
            set { Fields.UomId[this] = value; }
        }
        [DisplayName("Uom"), Expression("jUom.[Name]"), MinSelectLevel(SelectLevel.List)]
        [Width(80)]
        public string UomName
        {
            get { return Fields.UomName[this]; }
            set { Fields.UomName[this] = value; }
        }

        [DisplayName("Quantity"), Size(18), Scale(Statics.DecimalLength), NotNull, DefaultValue(0)]
        [AlignRight]
        public Decimal? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }

        [DisplayName("Sample Qty"), Column("Sample_Qty"), Size(18), Scale(Statics.DecimalLength), DefaultValue(0)]
        [AlignRight, Visible(false)]
        public Decimal? SampleQty
        {
            get { return Fields.SampleQty[this]; }
            set { Fields.SampleQty[this] = value; }
        }

        [DisplayName("Over Qty"), Column("Over_Qty"), Size(18), Scale(Statics.DecimalLength), DefaultValue(0)]
        [AlignRight]
        [Visible(false)]
        public Decimal? OverQty
        {
            get { return Fields.OverQty[this]; }
            set { Fields.OverQty[this] = value; }
        }

        [DisplayName("Line Total Qty"), Expression("(t0.[Quantity]+t0.[Sample_Qty])+t0.[Over_Qty]")]
        [Visible(false)]
        [AlignRight]

        public Decimal? LineTotalQty
        {
            get { return Fields.LineTotalQty[this]; }
            set { Fields.LineTotalQty[this] = value; }
        }

        [DisplayName("Max Qty"), Column("Max_Qty"), Size(18), Scale(Statics.DecimalLength), DefaultValue(0)]
        [Visible(false)]
        [AlignRight]

        public Decimal? MaxQty
        {
            get { return Fields.MaxQty[this]; }
            set { Fields.MaxQty[this] = value; }
        }

        [DisplayName("Balance Qty"), Expression("((t0.[Quantity]+t0.[Sample_Qty])+t0.[Over_Qty])-t0.[Max_Qty]")]
        [Visible(false)]
        [AlignRight]

        public Decimal? BalanceQty
        {
            get { return Fields.BalanceQty[this]; }
            set { Fields.BalanceQty[this] = value; }
        }

        [DisplayName("Unit Price"), Column("Unit_Price"), Size(18), Scale(Statics.DecimalLength), DefaultValue(0)]
        [AlignRight]
        public Decimal? UnitPrice
        {
            get { return Fields.UnitPrice[this]; }
            set { Fields.UnitPrice[this] = value; }
        }

        [AlignRight]
        [DisplayName("Amount"), Expression("(t0.[Quantity]+t0.[Over_Qty])*t0.[Unit_Price]")]
        public Decimal? Amount
        {
            get { return Fields.Amount[this]; }
            set { Fields.Amount[this] = value; }
        }

        [DisplayName("Tax Amt"), Column("Tax_Amt"), Size(18), Scale(Statics.DecimalLength), DefaultValue(0)]
        [AlignRight]
        public Decimal? TaxAmt
        {
            get { return Fields.TaxAmt[this]; }
            set { Fields.TaxAmt[this] = value; }
        }

        [DisplayName("Discount Amt"), Column("Discount_Amt"), Size(18), Scale(Statics.DecimalLength), DefaultValue(0)]
        [AlignRight]
        public Decimal? DiscountAmt
        {
            get { return Fields.DiscountAmt[this]; }
            set { Fields.DiscountAmt[this] = value; }
        }

        [DisplayName("Line Total Amt"), Expression("(t0.[Quantity]*t0.[Unit_Price]+t0.[Tax_Amt])+t0.[Discount_Amt]")]
        [AlignRight]
        public Decimal? LineTotalAmt
        {
            get { return Fields.LineTotalAmt[this]; }
            set { Fields.LineTotalAmt[this] = value; }
        }

        [DisplayName("Is Return"), Column("Is_Return")]
        [Visible(false)]
        public Int16? IsReturn
        {
            get { return Fields.IsReturn[this]; }
            set { Fields.IsReturn[this] = value; }
        }

        [DisplayName("Is Offer"), Column("Is_Offer")]
        [Visible(false)]
        public Int16? IsOffer
        {
            get { return Fields.IsOffer[this]; }
            set { Fields.IsOffer[this] = value; }
        }

        [DisplayName("Offer Parent Id"), Column("Offer_Parent_Id")]
        [Visible(false)]
        public Int32? OfferParentId
        {
            get { return Fields.OfferParentId[this]; }
            set { Fields.OfferParentId[this] = value; }
        }

        [DisplayName("Acc Id"), Column("Acc_Id")]
        [Visible(false)]
        public Int32? AccId
        {
            get { return Fields.AccId[this]; }
            set { Fields.AccId[this] = value; }
        }

        [DisplayName("Is Debit"), Column("Is_Debit")]
        [Visible(false)]
        public Int16? IsDebit
        {
            get { return Fields.IsDebit[this]; }
            set { Fields.IsDebit[this] = value; }
        }

        [DisplayName("Dr Amt"), Column("Dr_Amt"), Size(18), Scale(Statics.DecimalLength), DefaultValue(0)]
        [Visible(false)]
        public Decimal? DrAmt
        {
            get { return Fields.DrAmt[this]; }
            set { Fields.DrAmt[this] = value; }
        }

        [DisplayName("Cr Amt"), Column("Cr_Amt"), Size(18), Scale(Statics.DecimalLength), DefaultValue(0)]
        [Visible(false)]
        public Decimal? CrAmt
        {
            get { return Fields.CrAmt[this]; }
            set { Fields.CrAmt[this] = value; }
        }

        [DisplayName("Ref Type Id"), Column("Ref_Type_Id")]
        [Visible(false)]
        public Int32? RefTypeId
        {
            get { return Fields.RefTypeId[this]; }
            set { Fields.RefTypeId[this] = value; }
        }

        [DisplayName("Ref Id"), Column("Ref_Id")]
        [Visible(false)]
        public Int32? RefId
        {
            get { return Fields.RefId[this]; }
            set { Fields.RefId[this] = value; }
        }

        [DisplayName("Ref Dtl Id"), Column("Ref_Dtl_Id")]
        [Visible(false)]
        public Int32? RefDtlId
        {
            get { return Fields.RefDtlId[this]; }
            set { Fields.RefDtlId[this] = value; }
        }

        [DisplayName("Ref Code"), Column("Ref_Code"), Size(50)]
        [Visible(false)]
        public String RefCode
        {
            get { return Fields.RefCode[this]; }
            set { Fields.RefCode[this] = value; }
        }

        [DisplayName("Ref No"), Column("Ref_No"), Size(50)]
        [Visible(false)]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Ref Img Id"), Column("Ref_Img_Id")]
        [Visible(false)]
        public Int32? RefImgId
        {
            get { return Fields.RefImgId[this]; }
            set { Fields.RefImgId[this] = value; }
        }

        [DisplayName("Trans Ref Type Id"), Column("Trans_Ref_Type_Id")]
        [Visible(false)]
        public Int32? TransRefTypeId
        {
            get { return Fields.TransRefTypeId[this]; }
            set { Fields.TransRefTypeId[this] = value; }
        }

        [DisplayName("Trans Ref Id"), Column("Trans_Ref_Id")]
        [Visible(false)]
        public Int32? TransRefId
        {
            get { return Fields.TransRefId[this]; }
            set { Fields.TransRefId[this] = value; }
        }

        [DisplayName("Trans Ref Dtl Id"), Column("Trans_Ref_Dtl_Id")]
        [Visible(false)]
        public Int32? TransRefDtlId
        {
            get { return Fields.TransRefDtlId[this]; }
            set { Fields.TransRefDtlId[this] = value; }
        }

        [DisplayName("Trans Ref Code"), Column("Trans_Ref_Code"), Size(50)]
        [Visible(false)]
        public String TransRefCode
        {
            get { return Fields.TransRefCode[this]; }
            set { Fields.TransRefCode[this] = value; }
        }

        [DisplayName("Trans Ref No"), Column("Trans_Ref_No"), Size(50)]
        [Visible(false)]
        public String TransRefNo
        {
            get { return Fields.TransRefNo[this]; }
            set { Fields.TransRefNo[this] = value; }
        }

        [DisplayName("Trans Ref Img Id"), Column("Trans_Ref_Img_Id")]
        [Visible(false)]
        public Int32? TransRefImgId
        {
            get { return Fields.TransRefImgId[this]; }
            set { Fields.TransRefImgId[this] = value; }
        }

        [DisplayName("Is Approved"), Column("Is_Approved")]
        [Visible(false)]
        public Int16? IsApproved
        {
            get { return Fields.IsApproved[this]; }
            set { Fields.IsApproved[this] = value; }
        }

        [DisplayName("Approved On"), Column("Approved_On")]
        [Visible(false)]
        public DateTime? ApprovedOn
        {
            get { return Fields.ApprovedOn[this]; }
            set { Fields.ApprovedOn[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TransDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public Int32Field TransId;
            public Int32Field TransTypeId;
            public Int32Field ItemId;
            public Int32Field ItemDetailId;
            public Int32Field UomId;
            public DecimalField Quantity;
            public DecimalField SampleQty;
            public DecimalField OverQty;
            public DecimalField LineTotalQty;
            public DecimalField MaxQty;
            public DecimalField BalanceQty;
            public DecimalField UnitPrice;
            public DecimalField Amount;
            public DecimalField TaxAmt;
            public DecimalField DiscountAmt;
            public DecimalField LineTotalAmt;
            public Int16Field IsReturn;
            public Int16Field IsOffer;
            public Int32Field OfferParentId;
            public Int32Field AccId;
            public Int16Field IsDebit;
            public DecimalField DrAmt;
            public DecimalField CrAmt;
            public Int32Field RefTypeId;
            public Int32Field RefId;
            public Int32Field RefDtlId;
            public StringField RefCode;
            public StringField RefNo;
            public Int32Field RefImgId;
            public Int32Field TransRefTypeId;
            public Int32Field TransRefId;
            public Int32Field TransRefDtlId;
            public StringField TransRefCode;
            public StringField TransRefNo;
            public Int32Field TransRefImgId;

            public Int16Field IsApproved;
            public DateTimeField ApprovedOn;

            public StringField ItemName;

            public StringField UomName;

            public RowFields()
                : base("[dbo].[Trans_Detail]")
            {
                LocalTextPrefix = "ItemTransaction.TransDetail";
            }
        }
    }
}