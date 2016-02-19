
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

    [ConnectionKey("NERPDB"), DisplayName("Project"), InstanceName("Project"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("NERP.Project")]
    public sealed class ProjectRow : Row, IIdRow, INameRow
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

        [DisplayName("Note"), Size(200)]
        public String Note
        {
            get { return Fields.Note[this]; }
            set { Fields.Note[this] = value; }
        }

        [DisplayName("Project"), Column("Project_Id"), Visible(false), Hidden]
        [ForeignKey("Project", "Id"), LeftJoin("prj"), LookupEditor(typeof(ProjectRow))]
        public Int32? ProjectId
        {
            get { return Fields.ProjectId[this]; }
            set { Fields.ProjectId[this] = value; }
        }

        [DisplayName("Project"), Expression("prj.[Name]"), Visible(false), Hidden]
        public String Project
        {
            get { return Fields.Project[this]; }
            set { Fields.Project[this] = value; }
        }

        [DisplayName("Organogram"), Column("Organogram_Id"), Visible(false), Hidden]
        [ForeignKey("Organogram", "Id"), LeftJoin("org"), LookupEditor(typeof(OrganogramRow))]
        public Int32? OrganogramId
        {
            get { return Fields.OrganogramId[this]; }
            set { Fields.OrganogramId[this] = value; }
        }

        [DisplayName("Organogram"), Expression("org.[Name]"), Visible(false), Hidden]
        public String Organogram
        {
            get { return Fields.Organogram[this]; }
            set { Fields.Organogram[this] = value; }
        }

        [DisplayName("Scope Id"), Column("Scope_Id"), Visible(false), Hidden]
        [Hidden]
        public Int32? ScopeId
        {
            get { return Fields.ScopeId[this]; }
            set { Fields.ScopeId[this] = value; }
        }

        [DisplayName("Company Id"), Column("Company_Id"), Visible(false), Hidden]
        [Visible(false)]
        public Int32? CompanyId
        {
            get { return Fields.CompanyId[this]; }
            set { Fields.CompanyId[this] = value; }
        }

        [DisplayName("Status Id"), Column("Status_Id"), Visible(false), Hidden]
        public Int32? StatusId
        {
            get { return Fields.StatusId[this]; }
            set { Fields.StatusId[this] = value; }
        }

        [DisplayName("Active On"), Column("Active_On"), Visible(false), Hidden]
        public DateTime? ActiveOn
        {
            get { return Fields.ActiveOn[this]; }
            set { Fields.ActiveOn[this] = value; }
        }

        [DisplayName("Inactive On"), Column("Inactive_On"), Visible(false), Hidden]
        public DateTime? InactiveOn
        {
            get { return Fields.InactiveOn[this]; }
            set { Fields.InactiveOn[this] = value; }
        }

        [DisplayName("Is Active"), Column("Is_Active"), Visible(false), Hidden]
        public Int16? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("Db Id"), Column("Db_Id"), Visible(false), Hidden]
        public Int32? DbId
        {
            get { return Fields.DbId[this]; }
            set { Fields.DbId[this] = value; }
        }

        [DisplayName("Created By"), Column("Created_By"), Visible(false), Hidden]
        public Int32? CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created On"), Column("Created_On"), Visible(false), Hidden]
        public DateTime? CreatedOn
        {
            get { return Fields.CreatedOn[this]; }
            set { Fields.CreatedOn[this] = value; }
        }

        [DisplayName("Created Pc"), Column("Created_Pc"), Size(50), Visible(false), Hidden]
        public String CreatedPc
        {
            get { return Fields.CreatedPc[this]; }
            set { Fields.CreatedPc[this] = value; }
        }

        [DisplayName("Updated By"), Column("Updated_By"), Visible(false), Hidden]
        public Int32? UpdatedBy
        {
            get { return Fields.UpdatedBy[this]; }
            set { Fields.UpdatedBy[this] = value; }
        }

        [DisplayName("Updated On"), Column("Updated_On"), Visible(false), Hidden]
        public DateTime? UpdatedOn
        {
            get { return Fields.UpdatedOn[this]; }
            set { Fields.UpdatedOn[this] = value; }
        }

        [DisplayName("Updated Pc"), Column("Updated_Pc"), Size(50), Visible(false), Hidden]
        public String UpdatedPc
        {
            get { return Fields.UpdatedPc[this]; }
            set { Fields.UpdatedPc[this] = value; }
        }

        [DisplayName("Deleted By"), Column("Deleted_By"), Visible(false), Hidden]
        public Int32? DeletedBy
        {
            get { return Fields.DeletedBy[this]; }
            set { Fields.DeletedBy[this] = value; }
        }

        [DisplayName("Deleted On"), Column("Deleted_On"), Visible(false), Hidden]
        public DateTime? DeletedOn
        {
            get { return Fields.DeletedOn[this]; }
            set { Fields.DeletedOn[this] = value; }
        }

        [DisplayName("Deleted Pc"), Column("Deleted_Pc"), Size(50), Visible(false), Hidden]
        public String DeletedPc
        {
            get { return Fields.DeletedPc[this]; }
            set { Fields.DeletedPc[this] = value; }
        }

        [DisplayName("Is Delete"), Column("Is_Delete"), Visible(false), Hidden]
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

        public ProjectRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field Id;
            public readonly StringField Code;
            public readonly StringField Name;
            public readonly StringField Description;
            public readonly StringField Note;
            public readonly Int32Field ProjectId;
            public readonly StringField Project;
            public readonly Int32Field OrganogramId;
            public readonly StringField Organogram;
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
            public readonly Int32Field DeletedBy;
            public readonly DateTimeField DeletedOn;
            public readonly StringField DeletedPc;
            public readonly Int16Field IsDelete;


            public RowFields()
                : base("[dbo].[Project]")
            {
                LocalTextPrefix = "Configuration.Project";
            }
        }
    }


    public abstract class BaseRow : Row
    {
        protected BaseRow(RowFieldsBase fields)
            : base(fields)
        {
            loggingFields = (BaseRowFields)fields;
        }

        [NotNull, Insertable(false), Updatable(false)]
        public Int32? InsertUserId
        {
            get { return loggingFields.InsertUserId[this]; }
            set { loggingFields.InsertUserId[this] = value; }
        }

        [NotNull, Insertable(false), Updatable(false)]
        public DateTime? InsertDate
        {
            get { return loggingFields.InsertDate[this]; }
            set { loggingFields.InsertDate[this] = value; }
        }

        [Insertable(false), Updatable(false)]
        public Int32? UpdateUserId
        {
            get { return loggingFields.UpdateUserId[this]; }
            set { loggingFields.UpdateUserId[this] = value; }
        }

        [Insertable(false), Updatable(false)]
        public DateTime? UpdateDate
        {
            get { return loggingFields.UpdateDate[this]; }
            set { loggingFields.UpdateDate[this] = value; }
        }

        [NotNull, Insertable(false), Updatable(true)]
        public Int16? IsActive
        {
            get { return loggingFields.IsActive[this]; }
            set { loggingFields.IsActive[this] = value; }
        }


        private BaseRowFields loggingFields;

        public class BaseRowFields : RowFieldsBase
        {
            public readonly Int32Field Id;
            public readonly StringField Code;
            public readonly StringField Name;
            public readonly StringField Description;
            public readonly StringField Note;
            public readonly Int32Field ProjectId;
            public readonly StringField Project;
            public readonly Int32Field OrganogramId;
            public readonly StringField Organogram;
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
            public readonly Int32Field DeletedBy;
            public readonly DateTimeField DeletedOn;
            public readonly StringField DeletedPc;
            public readonly Int16Field IsDelete;

            public BaseRowFields(string tableName)
                : base(tableName)
            {
            }
        }
    }


}