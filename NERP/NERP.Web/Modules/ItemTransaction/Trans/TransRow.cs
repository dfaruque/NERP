
namespace NERP.ItemTransaction.Entities
{
    using NERP.Common;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Trans"), InstanceName("Trans"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class TransRow : BaseRow
    {
        public new String Name //Hide purpose
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Date Time"), Column("Date_Time")]
        public DateTime? DateTime
        {
            get { return Fields.DateTime[this]; }
            set { Fields.DateTime[this] = value; }
        }

        [DisplayName("Trans Type Id"), Column("Trans_Type_Id")]
        public Int32? TransTypeId
        {
            get { return Fields.TransTypeId[this]; }
            set { Fields.TransTypeId[this] = value; }
        }

        [DisplayName("Detail"), MasterDetailRelation(foreignKey: "TransId"), ClientSide]
        public List<Entities.TransDetailRow> TransDetailRows
        {
            get { return Fields.TransDetailRows[this]; }
            set { Fields.TransDetailRows[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public TransRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public DateTimeField DateTime;
            public Int32Field TransTypeId;

            public RowListField<Entities.TransDetailRow> TransDetailRows;
            public RowFields()
                : base("[dbo].[Trans]")
            {
                LocalTextPrefix = "ItemTransaction.Trans";
            }
        }
    }
}