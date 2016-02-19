
namespace NERP.Accounting.Entities
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

    [ConnectionKey("NERPDB"), DisplayName("COA"), InstanceName("COA"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class COARow : BaseRow
    {

        [DisplayName("Parent Id"), Column("Parent_Id")]
        public Int32? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public COARow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int32Field ParentId;

            public RowFields()
                : base("[Acc].[COA]")
            {
                LocalTextPrefix = "Accounting.COA";
            }
        }
    }
}