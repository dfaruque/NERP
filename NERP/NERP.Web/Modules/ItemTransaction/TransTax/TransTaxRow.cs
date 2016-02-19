
namespace NERP.ItemTransaction.Entities
{
    using NERP.Common;
using Newtonsoft.Json;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Trans_Tax"), InstanceName("Trans_Tax"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class TransTaxRow : BaseRow
    {
        [DisplayName("Trans"), Column("Trans_Id"), ForeignKey("[dbo].[Trans]", "Id"), LeftJoin("jTrans"), TextualField("TransCode")]
        public Int32? TransId
        {
            get { return Fields.TransId[this]; }
            set { Fields.TransId[this] = value; }
        }

        [DisplayName("Trans Detail"), Column("Trans_Detail_Id"), ForeignKey("[dbo].[Trans_Detail]", "Id"), LeftJoin("jTransDetail"), TextualField("TransDetailName")]
        public Int32? TransDetailId
        {
            get { return Fields.TransDetailId[this]; }
            set { Fields.TransDetailId[this] = value; }
        }

        [DisplayName("Tax"), Column("Tax_Id"), ForeignKey("[dbo].[Tax]", "Id"), LeftJoin("jTax"), TextualField("TaxName")]
        public Int32? TaxId
        {
            get { return Fields.TaxId[this]; }
            set { Fields.TaxId[this] = value; }
        }
        [DisplayName("Tax"), Expression("jTax.[Name]")]
        public string TaxName
        {
            get { return Fields.TaxName[this]; }
            set { Fields.TaxName[this] = value; }
        }

        [DisplayName("Rate"), Size(18), Scale(Statics.DecimalLength)]
        public Decimal? Rate
        {
            get { return Fields.Rate[this]; }
            set { Fields.Rate[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TransTaxRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public Int32Field TransId;
            public Int32Field TransDetailId;
            public Int32Field TaxId;
            public DecimalField Rate;

            public StringField TaxName;

            public RowFields()
                : base("[dbo].[Trans_Tax]")
            {
                LocalTextPrefix = "ItemTransaction.TransTax";
            }
        }
    }
}