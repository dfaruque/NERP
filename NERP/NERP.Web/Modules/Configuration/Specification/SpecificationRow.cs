
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

    [ConnectionKey("NERPDB"), DisplayName("Specification"), InstanceName("Specification"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Specification", Permission = "?")]

    public sealed class SpecificationRow : BaseRow
    {

        public static readonly RowFields Fields = new RowFields().Init();

        public SpecificationRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {

            public RowFields()
                : base("[Itm].[Specification]")
            {
                LocalTextPrefix = "Configuration.Specification";
            }
        }
    }
}