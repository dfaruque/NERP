
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

    [ConnectionKey("NERPDB"), DisplayName("Generic Item"), InstanceName("Generic_Item"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("Configuration.GenericItem")]
    public sealed class GenericItemRow : BaseRow
    {
        
        [DisplayName("Item Category"), Column("Item_Category_Id"), ForeignKey("[Itm].[Item_Category]", "Id"), LeftJoin("jItemCategory"), TextualField("ItemCategoryName")]
        [LookupEditor(typeof(ItemCategoryRow), InplaceAdd=true)]
        public Int32? ItemCategoryId
        {
            get { return Fields.ItemCategoryId[this]; }
            set { Fields.ItemCategoryId[this] = value; }
        }
        [DisplayName("ItemCategoryName"), Expression("jItemCategory.[Name]")]
        public string ItemCategoryName
        {
            get { return Fields.ItemCategoryName[this]; }
            set { Fields.ItemCategoryName[this] = value; }
        }

        [DisplayName("Item Type"), Column("Item_Type_Id"), ForeignKey("[Enm].[Item_Type]", "Id"), LeftJoin("jItemType"), TextualField("ItemTypeName")]
        public Int32? ItemTypeId
        {
            get { return Fields.ItemTypeId[this]; }
            set { Fields.ItemTypeId[this] = value; }
        }

        [DisplayName("Item Type"), Expression("jItemType.[Name]")]
        public string ItemTypeName
        {
            get { return Fields.ItemTypeName[this]; }
            set { Fields.ItemTypeName[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GenericItemRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int32Field ItemCategoryId;
            public readonly Int32Field ItemTypeId;

            public readonly StringField ItemCategoryName;
            public readonly StringField ItemTypeName;
            public RowFields()
                : base("[Itm].[Generic_Item]")
            {
                LocalTextPrefix = "Configuration.GenericItem";
            }
        }
    }
}