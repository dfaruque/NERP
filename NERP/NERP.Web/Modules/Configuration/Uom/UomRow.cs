
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

    [ConnectionKey("NERPDB"), DisplayName("Uom"), InstanceName("Uom"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Uom", Permission = "?")]

    public sealed class UomRow : BaseRow
    {

        [DisplayName("Uom Tyep Id"), Column("Uom_Tyep_Id")]
        public Int32? UomTyepId
        {
            get { return Fields.UomTyepId[this]; }
            set { Fields.UomTyepId[this] = value; }
        }

        [DisplayName("Rate To Standard"), Column("Rate_To_Standard"), Size(18), Scale(4), NotNull]
        public Decimal? RateToStandard
        {
            get { return Fields.RateToStandard[this]; }
            set { Fields.RateToStandard[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UomRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int32Field UomTyepId;
            public readonly DecimalField RateToStandard;

            public RowFields()
                : base("[dbo].[Uom]")
            {
                LocalTextPrefix = "Configuration.Uom";
            }
        }
    }
}