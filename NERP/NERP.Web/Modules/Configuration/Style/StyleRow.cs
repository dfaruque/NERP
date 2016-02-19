
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

    [ConnectionKey("NERPDB"), DisplayName("Style"), InstanceName("Style"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Style", Permission = "?")]

    public sealed class StyleRow : BaseRow
    {

        public static readonly RowFields Fields = new RowFields().Init();

        public StyleRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {

            public RowFields()
                : base("[Itm].[Style]")
            {
                LocalTextPrefix = "Configuration.Style";
            }
        }
    }
}