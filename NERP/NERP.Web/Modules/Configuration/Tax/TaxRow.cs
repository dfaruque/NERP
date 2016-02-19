
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

    [ConnectionKey("NERPDB"), DisplayName("Tax"), InstanceName("Tax"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class TaxRow : BaseRow
    {
        
        [DisplayName("Rate"), Size(18), Scale(Statics.DecimalLength)]
        public Decimal? Rate
        {
            get { return Fields.Rate[this]; }
            set { Fields.Rate[this] = value; }
        }

        [DisplayName("Is Default"), Column("Is_Default")]
        [BooleanEditor, BooleanFormatter]
        public Int16? IsDefault
        {
            get { return Fields.IsDefault[this]; }
            set { Fields.IsDefault[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public TaxRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly DecimalField Rate;
            public readonly Int16Field IsDefault;
            
            public RowFields()
                : base("[dbo].[Tax]")
            {
                LocalTextPrefix = "Configuration.Tax";
            }
        }
    }
}