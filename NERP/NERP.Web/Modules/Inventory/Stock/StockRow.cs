
namespace NERP.Inventory.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Stock"), InstanceName("Stock"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class StockRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), PrimaryKey]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Code"), Size(50), NotNull, QuickSearch]
        public String Code
        {
            get { return Fields.Code[this]; }
            set { Fields.Code[this] = value; }
        }

        [DisplayName("Name"), Size(50), NotNull]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Description"), Size(200)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Item Id"), Column("Item_Id"), Size(50), NotNull]
        public String ItemId
        {
            get { return Fields.ItemId[this]; }
            set { Fields.ItemId[this] = value; }
        }

        [DisplayName("Item Detail Id"), Column("Item_Detail_Id"), Size(10)]
        public String ItemDetailId
        {
            get { return Fields.ItemDetailId[this]; }
            set { Fields.ItemDetailId[this] = value; }
        }

        [DisplayName("Uom Id"), Column("Uom_Id"), Size(10)]
        public String UomId
        {
            get { return Fields.UomId[this]; }
            set { Fields.UomId[this] = value; }
        }

        [DisplayName("Opening Stock"), Column("Opening_Stock"), Size(18), Scale(4), NotNull]
        public Decimal? OpeningStock
        {
            get { return Fields.OpeningStock[this]; }
            set { Fields.OpeningStock[this] = value; }
        }

        [DisplayName("Opening Stock Val"), Column("Opening_Stock_Val"), Size(18), Scale(4)]
        public Decimal? OpeningStockVal
        {
            get { return Fields.OpeningStockVal[this]; }
            set { Fields.OpeningStockVal[this] = value; }
        }

        [DisplayName("Received Qty"), Column("Received_Qty"), Size(18), Scale(4), NotNull]
        public Decimal? ReceivedQty
        {
            get { return Fields.ReceivedQty[this]; }
            set { Fields.ReceivedQty[this] = value; }
        }

        [DisplayName("Received Val"), Column("Received_Val"), Size(18), Scale(4)]
        public Decimal? ReceivedVal
        {
            get { return Fields.ReceivedVal[this]; }
            set { Fields.ReceivedVal[this] = value; }
        }

        [DisplayName("Delivered Qty"), Column("Delivered_Qty"), Size(18), Scale(4), NotNull]
        public Decimal? DeliveredQty
        {
            get { return Fields.DeliveredQty[this]; }
            set { Fields.DeliveredQty[this] = value; }
        }

        [DisplayName("Delivered Val"), Column("Delivered_Val"), Size(18), Scale(4)]
        public Decimal? DeliveredVal
        {
            get { return Fields.DeliveredVal[this]; }
            set { Fields.DeliveredVal[this] = value; }
        }

        [DisplayName("Current Stock"), Column("Current_Stock"), Size(20), Scale(4)]
        public Decimal? CurrentStock
        {
            get { return Fields.CurrentStock[this]; }
            set { Fields.CurrentStock[this] = value; }
        }

        [DisplayName("Current Stock Val"), Column("Current_Stock_Val"), Size(20), Scale(4)]
        public Decimal? CurrentStockVal
        {
            get { return Fields.CurrentStockVal[this]; }
            set { Fields.CurrentStockVal[this] = value; }
        }

        [DisplayName("Opening Stock Date"), Column("Opening_Stock_Date")]
        public DateTime? OpeningStockDate
        {
            get { return Fields.OpeningStockDate[this]; }
            set { Fields.OpeningStockDate[this] = value; }
        }

        [DisplayName("Last Received Date"), Column("Last_Received_Date")]
        public DateTime? LastReceivedDate
        {
            get { return Fields.LastReceivedDate[this]; }
            set { Fields.LastReceivedDate[this] = value; }
        }

        [DisplayName("Last Delivered Date"), Column("Last_Delivered_Date")]
        public DateTime? LastDeliveredDate
        {
            get { return Fields.LastDeliveredDate[this]; }
            set { Fields.LastDeliveredDate[this] = value; }
        }

        [DisplayName("Note"), Size(200)]
        public String Note
        {
            get { return Fields.Note[this]; }
            set { Fields.Note[this] = value; }
        }

        [DisplayName("Project Id"), Column("Project_Id")]
        public Int32? ProjectId
        {
            get { return Fields.ProjectId[this]; }
            set { Fields.ProjectId[this] = value; }
        }

        [DisplayName("Organogram Id"), Column("Organogram_Id")]
        public Int32? OrganogramId
        {
            get { return Fields.OrganogramId[this]; }
            set { Fields.OrganogramId[this] = value; }
        }

        [DisplayName("Scope Id"), Column("Scope_Id")]
        public Int32? ScopeId
        {
            get { return Fields.ScopeId[this]; }
            set { Fields.ScopeId[this] = value; }
        }

        [DisplayName("Company Id"), Column("Company_Id")]
        public Int32? CompanyId
        {
            get { return Fields.CompanyId[this]; }
            set { Fields.CompanyId[this] = value; }
        }

        [DisplayName("Status Id"), Column("Status_Id")]
        public Int32? StatusId
        {
            get { return Fields.StatusId[this]; }
            set { Fields.StatusId[this] = value; }
        }

        [DisplayName("Active On"), Column("Active_On")]
        public DateTime? ActiveOn
        {
            get { return Fields.ActiveOn[this]; }
            set { Fields.ActiveOn[this] = value; }
        }

        [DisplayName("Inactive On"), Column("Inactive_On")]
        public DateTime? InactiveOn
        {
            get { return Fields.InactiveOn[this]; }
            set { Fields.InactiveOn[this] = value; }
        }

        [DisplayName("Is Active"), Column("Is_Active")]
        public Int16? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("Db Id"), Column("Db_Id")]
        public Int32? DbId
        {
            get { return Fields.DbId[this]; }
            set { Fields.DbId[this] = value; }
        }

        [DisplayName("Created By"), Column("Created_By")]
        public Int32? CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created On"), Column("Created_On")]
        public DateTime? CreatedOn
        {
            get { return Fields.CreatedOn[this]; }
            set { Fields.CreatedOn[this] = value; }
        }

        [DisplayName("Created Pc"), Column("Created_Pc"), Size(50)]
        public String CreatedPc
        {
            get { return Fields.CreatedPc[this]; }
            set { Fields.CreatedPc[this] = value; }
        }

        [DisplayName("Updated By"), Column("Updated_By")]
        public Int32? UpdatedBy
        {
            get { return Fields.UpdatedBy[this]; }
            set { Fields.UpdatedBy[this] = value; }
        }

        [DisplayName("Updated On"), Column("Updated_On")]
        public DateTime? UpdatedOn
        {
            get { return Fields.UpdatedOn[this]; }
            set { Fields.UpdatedOn[this] = value; }
        }

        [DisplayName("Updated Pc"), Column("Updated_Pc"), Size(50)]
        public String UpdatedPc
        {
            get { return Fields.UpdatedPc[this]; }
            set { Fields.UpdatedPc[this] = value; }
        }

        [DisplayName("Deleted By"), Column("Deleted_By")]
        public Int32? DeletedBy
        {
            get { return Fields.DeletedBy[this]; }
            set { Fields.DeletedBy[this] = value; }
        }

        [DisplayName("Deleted On"), Column("Deleted_On")]
        public DateTime? DeletedOn
        {
            get { return Fields.DeletedOn[this]; }
            set { Fields.DeletedOn[this] = value; }
        }

        [DisplayName("Deleted Pc"), Column("Deleted_Pc"), Size(50)]
        public String DeletedPc
        {
            get { return Fields.DeletedPc[this]; }
            set { Fields.DeletedPc[this] = value; }
        }

        [DisplayName("Is Delete"), Column("Is_Delete")]
        public Int16? IsDelete
        {
            get { return Fields.IsDelete[this]; }
            set { Fields.IsDelete[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public StockRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field Id;
            public readonly StringField Code;
            public readonly StringField Name;
            public readonly StringField Description;
            public readonly StringField ItemId;
            public readonly StringField ItemDetailId;
            public readonly StringField UomId;
            public readonly DecimalField OpeningStock;
            public readonly DecimalField OpeningStockVal;
            public readonly DecimalField ReceivedQty;
            public readonly DecimalField ReceivedVal;
            public readonly DecimalField DeliveredQty;
            public readonly DecimalField DeliveredVal;
            public readonly DecimalField CurrentStock;
            public readonly DecimalField CurrentStockVal;
            public readonly DateTimeField OpeningStockDate;
            public readonly DateTimeField LastReceivedDate;
            public readonly DateTimeField LastDeliveredDate;
            public readonly StringField Note;
            public readonly Int32Field ProjectId;
            public readonly Int32Field OrganogramId;
            public readonly Int32Field ScopeId;
            public readonly Int32Field CompanyId;
            public readonly Int32Field StatusId;
            public readonly DateTimeField ActiveOn;
            public readonly DateTimeField InactiveOn;
            public readonly Int16Field IsActive;
            public readonly Int32Field DbId;
            public readonly Int32Field CreatedBy;
            public readonly DateTimeField CreatedOn;
            public readonly StringField CreatedPc;
            public readonly Int32Field UpdatedBy; 
            public readonly DateTimeField UpdatedOn;
            public readonly StringField UpdatedPc;
            public readonly Int32Field DeletedBy;//
            public readonly DateTimeField DeletedOn;
            public readonly StringField DeletedPc;
            public readonly Int16Field IsDelete;

            public RowFields()
                : base("[Inv].[Stock]")
            {
                LocalTextPrefix = "Inventory.Stock";
            }
        }
    }
}