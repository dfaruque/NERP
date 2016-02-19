
namespace NERP.Configuration.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;
    using Serenity.Services; using NERP.Common;

    [ConnectionKey("NERPDB"), DisplayName("Project"), InstanceName("Project"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Project")]
    public sealed class ProjectRow : BaseRow
    {
        public static readonly RowFields Fields = new RowFields().Init();

        public ProjectRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public RowFields()
                : base("[dbo].[Project]")
            {
                LocalTextPrefix = "Configuration.Project";
            }
        }
    }




}