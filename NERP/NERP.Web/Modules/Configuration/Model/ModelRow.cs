
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

    [ConnectionKey("NERPDB"), DisplayName("Model"), InstanceName("Model"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Model", Permission = "?")]
    public sealed class ModelRow : BaseRow
    {

        public static readonly RowFields Fields = new RowFields().Init();

        public ModelRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {

            public RowFields()
                : base("[Itm].[Model]")
            {
                LocalTextPrefix = "Configuration.Model";
            }
        }
    }
}