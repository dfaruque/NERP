
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

    [ConnectionKey("NERPDB"), DisplayName("Size"), InstanceName("Size"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Size", Permission = "?")]

    public sealed class SizeRow : BaseRow
    {

        public static readonly RowFields Fields = new RowFields().Init();

        public SizeRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {

            public RowFields()
                : base("[Itm].[Size]")
            {
                LocalTextPrefix = "Configuration.Size";
            }
        }
    }
}