
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

    [ConnectionKey("NERPDB"), DisplayName("Currency"), InstanceName("Currency"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Currency", Permission = "?")]
    public sealed class CurrencyRow : BaseRow
    {
        
        [DisplayName("Symbol"), Size(5), NotNull]
        public String Symbol
        {
            get { return Fields.Symbol[this]; }
            set { Fields.Symbol[this] = value; }
        }

        [DisplayName("Decimal Places"), Column("Decimal_Places"), NotNull]
        public Int16? DecimalPlaces
        {
            get { return Fields.DecimalPlaces[this]; }
            set { Fields.DecimalPlaces[this] = value; }
        }

        [DisplayName("Decimal Separator"), Column("Decimal_Separator"), Size(5), NotNull]
        public String DecimalSeparator
        {
            get { return Fields.DecimalSeparator[this]; }
            set { Fields.DecimalSeparator[this] = value; }
        }

        [DisplayName("Is Thousand Base"), Column("Is_Thousand_Base"), NotNull]
        public Boolean? IsThousandBase
        {
            get { return Fields.IsThousandBase[this]; }
            set { Fields.IsThousandBase[this] = value; }
        }

        [DisplayName("Thousand Separator"), Column("Thousand_Separator"), Size(5), NotNull]
        public String ThousandSeparator
        {
            get { return Fields.ThousandSeparator[this]; }
            set { Fields.ThousandSeparator[this] = value; }
        }

        [DisplayName("Rate To Dollar"), Column("Rate_To_Dollar"), Size(18), Scale(Statics.DecimalLength), NotNull]
        public Decimal? RateToDollar
        {
            get { return Fields.RateToDollar[this]; }
            set { Fields.RateToDollar[this] = value; }
        }

        
        public static readonly RowFields Fields = new RowFields().Init();

        public CurrencyRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly StringField Symbol;
            public readonly Int16Field DecimalPlaces;
            public readonly StringField DecimalSeparator;
            public readonly BooleanField IsThousandBase;
            public readonly StringField ThousandSeparator;
            public readonly DecimalField RateToDollar;

            public RowFields()
                : base("[dbo].[Currency]")
            {
                LocalTextPrefix = "Configuration.Currency";
            }
        }
    }
}