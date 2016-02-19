
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

    [ConnectionKey("NERPDB"), DisplayName("Brand"), InstanceName("Brand"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Brand",Permission="?")]
    public sealed class BrandRow : BaseRow
    {

        public static readonly RowFields Fields = new RowFields().Init();

        public BrandRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {

            public RowFields()
                : base("[Itm].[Brand]")
            {
                LocalTextPrefix = "Configuration.Brand";
            }
        }
    }
}