
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

    [ConnectionKey("NERPDB"), DisplayName("Item Category"), InstanceName("Item_Category"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.ItemCategory", Permission = "?")]
    public sealed class ItemCategoryRow : BaseRow
    {
        
        [DisplayName("Parent"), Column("Parent_Id"), ForeignKey("[Itm].[Item_Category]", "Id"), LeftJoin("jParent"), TextualField("ParentCode")]
        [LookupEditor(typeof(ItemCategoryRow), InplaceAdd=true)]
        public Int32? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("Parent"), Expression("jParent.[Name]")]
        public String Parent
        {
            get { return Fields.Parent[this]; }
            set { Fields.Parent[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ItemCategoryRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int32Field ParentId;

            public readonly StringField Parent;

            public RowFields()
                : base("[Itm].[Item_Category]")
            {
                LocalTextPrefix = "Configuration.ItemCategory";
            }
        }
    }
}