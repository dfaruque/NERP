
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

    [ConnectionKey("NERPDB"), DisplayName("Organogram"), InstanceName("Organogram"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.Organogram")]
    public sealed class OrganogramRow : BaseRow
    {
        [DisplayName("Parent"), Column("Parent_Id"), ForeignKey("[dbo].[Organogram]", "Id"), LeftJoin("jParent"), TextualField("ParentCode")]
        [LookupEditor(typeof(OrganogramRow),InplaceAdd=true)]
        public Int32? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("Parent"), Expression("jParent.[Name]")]
        public String ParentName
        {
            get { return Fields.ParentName[this]; }
            set { Fields.ParentName[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrganogramRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int32Field ParentId;

            public readonly StringField ParentName;

            public RowFields()
                : base("[dbo].[Organogram]")
            {
                LocalTextPrefix = "Configuration.Organogram";
            }
        }
    }
}