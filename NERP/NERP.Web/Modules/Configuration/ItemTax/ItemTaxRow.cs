
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

    [ConnectionKey("NERPDB"), DisplayName("Item_Tax"), InstanceName("Item_Tax"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class ItemTaxRow : BaseRow
    {
        [DisplayName("Item"), Column("Item_Id"), ForeignKey("[dbo].[Item]", "Id"), LeftJoin("jItem"), TextualField("ItemName")]
        public Int32? ItemId
        {
            get { return Fields.ItemId[this]; }
            set { Fields.ItemId[this] = value; }
        }

        [DisplayName("Tax"), Column("Tax_Id"), ForeignKey("[dbo].[Tax]", "Id"), LeftJoin("jTax"), TextualField("ItemName")]
        public Int32? TaxId
        {
            get { return Fields.TaxId[this]; }
            set { Fields.TaxId[this] = value; }
        }

        [DisplayName("Rate"), Size(18), Scale(6)]
        public Decimal? Rate
        {
            get { return Fields.Rate[this]; }
            set { Fields.Rate[this] = value; }
        }

        [DisplayName("Item"), Expression("jItem.[Name]")]
        public String ItemName
        {
            get { return Fields.ItemName[this]; }
            set { Fields.ItemName[this] = value; }
        }


        [DisplayName("Tax"), Expression("jTax.[Name]")]
        public String Tax
        {
            get { return Fields.Tax[this]; }
            set { Fields.Tax[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public ItemTaxRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int32Field ItemId;
            public readonly Int32Field TaxId;
            public readonly DecimalField Rate;

            public readonly StringField ItemName;

            public readonly StringField Tax;

            public RowFields()
                : base("[dbo].[Item_Tax]")
            {
                LocalTextPrefix = "Configuration.ItemTax";
            }
        }
    }
}