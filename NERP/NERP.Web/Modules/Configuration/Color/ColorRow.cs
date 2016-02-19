
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

    [ConnectionKey("NERPDB"), DisplayName("Color"), InstanceName("Color"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Color", Permission = "?")]

    public sealed class ColorRow : BaseRow
    {
        [DisplayName("Hex Value"), Column("Hex_Value"), Size(7)]
        public String HexValue
        {
            get { return Fields.HexValue[this]; }
            set { Fields.HexValue[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ColorRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly StringField HexValue;

            public RowFields()
                : base("[Itm].[Color]")
            {
                LocalTextPrefix = "Configuration.Color";
            }
        }
    }
}