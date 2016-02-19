
namespace NERP.Purchase.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Supplier"), InstanceName("Supplier"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class SupplierRow : Row, IIdRow, INameRow
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

        [DisplayName("User Type Id"), Column("User_Type_Id")]
        public Int32? UserTypeId
        {
            get { return Fields.UserTypeId[this]; }
            set { Fields.UserTypeId[this] = value; }
        }

        [DisplayName("User Group Id"), Column("User_Group_Id")]
        public Int32? UserGroupId
        {
            get { return Fields.UserGroupId[this]; }
            set { Fields.UserGroupId[this] = value; }
        }

        [DisplayName("First Name"), Column("First_Name"), Size(50)]
        public String FirstName
        {
            get { return Fields.FirstName[this]; }
            set { Fields.FirstName[this] = value; }
        }

        [DisplayName("Middle Name"), Column("Middle_Name"), Size(50)]
        public String MiddleName
        {
            get { return Fields.MiddleName[this]; }
            set { Fields.MiddleName[this] = value; }
        }

        [DisplayName("Last Name"), Column("Last_Name"), Size(50)]
        public String LastName
        {
            get { return Fields.LastName[this]; }
            set { Fields.LastName[this] = value; }
        }

        [DisplayName("Full Name"), Column("Full_Name"), Size(150)]
        public String FullName
        {
            get { return Fields.FullName[this]; }
            set { Fields.FullName[this] = value; }
        }

        [DisplayName("Image"), Column("Image_Id"), ForeignKey("[dbo].[Image]", "Id"), LeftJoin("jImage"), TextualField("ImageCode")]
        public Int32? ImageId
        {
            get { return Fields.ImageId[this]; }
            set { Fields.ImageId[this] = value; }
        }

        [DisplayName("Address1"), Size(100)]
        public String Address1
        {
            get { return Fields.Address1[this]; }
            set { Fields.Address1[this] = value; }
        }

        [DisplayName("Address2"), Size(100)]
        public String Address2
        {
            get { return Fields.Address2[this]; }
            set { Fields.Address2[this] = value; }
        }

        [DisplayName("Mobile"), Size(12)]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        [DisplayName("Email"), Size(50)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Date Of Birth"), Column("Date_Of_Birth")]
        public DateTime? DateOfBirth
        {
            get { return Fields.DateOfBirth[this]; }
            set { Fields.DateOfBirth[this] = value; }
        }

        [DisplayName("Login Name"), Column("Login_Name"), Size(50)]
        public String LoginName
        {
            get { return Fields.LoginName[this]; }
            set { Fields.LoginName[this] = value; }
        }

        [DisplayName("Password"), Size(50)]
        public String Password
        {
            get { return Fields.Password[this]; }
            set { Fields.Password[this] = value; }
        }

        [DisplayName("Is Taxable"), Column("Is_Taxable")]
        public Int16? IsTaxable
        {
            get { return Fields.IsTaxable[this]; }
            set { Fields.IsTaxable[this] = value; }
        }

        [DisplayName("Commission Rate"), Column("Commission_Rate"), Size(18), Scale(6), NotNull]
        public Decimal? CommissionRate
        {
            get { return Fields.CommissionRate[this]; }
            set { Fields.CommissionRate[this] = value; }
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

        [DisplayName("Image Code"), Expression("jImage.[Code]")]
        public String ImageCode
        {
            get { return Fields.ImageCode[this]; }
            set { Fields.ImageCode[this] = value; }
        }

        [DisplayName("Image Name"), Expression("jImage.[Name]")]
        public String ImageName
        {
            get { return Fields.ImageName[this]; }
            set { Fields.ImageName[this] = value; }
        }

        [DisplayName("Image Description"), Expression("jImage.[Description]")]
        public String ImageDescription
        {
            get { return Fields.ImageDescription[this]; }
            set { Fields.ImageDescription[this] = value; }
        }

        [DisplayName("Image Image Type Id"), Expression("jImage.[Image_Type_Id]")]
        public Int32? ImageImageTypeId
        {
            get { return Fields.ImageImageTypeId[this]; }
            set { Fields.ImageImageTypeId[this] = value; }
        }

        [DisplayName("Image Path"), Expression("jImage.[Path]")]
        public String ImagePath
        {
            get { return Fields.ImagePath[this]; }
            set { Fields.ImagePath[this] = value; }
        }

        [DisplayName("Image Size Kb"), Expression("jImage.[Size_Kb]")]
        public Decimal? ImageSizeKb
        {
            get { return Fields.ImageSizeKb[this]; }
            set { Fields.ImageSizeKb[this] = value; }
        }

        [DisplayName("Image Wide Pixel"), Expression("jImage.[Wide_Pixel]")]
        public Decimal? ImageWidePixel
        {
            get { return Fields.ImageWidePixel[this]; }
            set { Fields.ImageWidePixel[this] = value; }
        }

        [DisplayName("Image Height Pixel"), Expression("jImage.[Height_Pixel]")]
        public Decimal? ImageHeightPixel
        {
            get { return Fields.ImageHeightPixel[this]; }
            set { Fields.ImageHeightPixel[this] = value; }
        }

        [DisplayName("Image Note"), Expression("jImage.[Note]")]
        public String ImageNote
        {
            get { return Fields.ImageNote[this]; }
            set { Fields.ImageNote[this] = value; }
        }

        [DisplayName("Image Project Id"), Expression("jImage.[Project_Id]")]
        public Int32? ImageProjectId
        {
            get { return Fields.ImageProjectId[this]; }
            set { Fields.ImageProjectId[this] = value; }
        }

        [DisplayName("Image Organogram Id"), Expression("jImage.[Organogram_Id]")]
        public Int32? ImageOrganogramId
        {
            get { return Fields.ImageOrganogramId[this]; }
            set { Fields.ImageOrganogramId[this] = value; }
        }

        [DisplayName("Image Scope Id"), Expression("jImage.[Scope_Id]")]
        public Int32? ImageScopeId
        {
            get { return Fields.ImageScopeId[this]; }
            set { Fields.ImageScopeId[this] = value; }
        }

        [DisplayName("Image Company Id"), Expression("jImage.[Company_Id]")]
        public Int32? ImageCompanyId
        {
            get { return Fields.ImageCompanyId[this]; }
            set { Fields.ImageCompanyId[this] = value; }
        }

        [DisplayName("Image Status Id"), Expression("jImage.[Status_Id]")]
        public Int32? ImageStatusId
        {
            get { return Fields.ImageStatusId[this]; }
            set { Fields.ImageStatusId[this] = value; }
        }

        [DisplayName("Image Active On"), Expression("jImage.[Active_On]")]
        public DateTime? ImageActiveOn
        {
            get { return Fields.ImageActiveOn[this]; }
            set { Fields.ImageActiveOn[this] = value; }
        }

        [DisplayName("Image Inactive On"), Expression("jImage.[Inactive_On]")]
        public DateTime? ImageInactiveOn
        {
            get { return Fields.ImageInactiveOn[this]; }
            set { Fields.ImageInactiveOn[this] = value; }
        }

        [DisplayName("Image Is Active"), Expression("jImage.[Is_Active]")]
        public Int16? ImageIsActive
        {
            get { return Fields.ImageIsActive[this]; }
            set { Fields.ImageIsActive[this] = value; }
        }

        [DisplayName("Image Db Id"), Expression("jImage.[Db_Id]")]
        public Int32? ImageDbId
        {
            get { return Fields.ImageDbId[this]; }
            set { Fields.ImageDbId[this] = value; }
        }

        [DisplayName("Image Created By"), Expression("jImage.[Created_By]")]
        public Int32? ImageCreatedBy
        {
            get { return Fields.ImageCreatedBy[this]; }
            set { Fields.ImageCreatedBy[this] = value; }
        }

        [DisplayName("Image Created On"), Expression("jImage.[Created_On]")]
        public DateTime? ImageCreatedOn
        {
            get { return Fields.ImageCreatedOn[this]; }
            set { Fields.ImageCreatedOn[this] = value; }
        }

        [DisplayName("Image Created Pc"), Expression("jImage.[Created_Pc]")]
        public String ImageCreatedPc
        {
            get { return Fields.ImageCreatedPc[this]; }
            set { Fields.ImageCreatedPc[this] = value; }
        }

        [DisplayName("Image Updated By"), Expression("jImage.[Updated_By]")]
        public Int32? ImageUpdatedBy
        {
            get { return Fields.ImageUpdatedBy[this]; }
            set { Fields.ImageUpdatedBy[this] = value; }
        }

        [DisplayName("Image Updated On"), Expression("jImage.[Updated_On]")]
        public DateTime? ImageUpdatedOn
        {
            get { return Fields.ImageUpdatedOn[this]; }
            set { Fields.ImageUpdatedOn[this] = value; }
        }

        [DisplayName("Image Updated Pc"), Expression("jImage.[Updated_Pc]")]
        public String ImageUpdatedPc
        {
            get { return Fields.ImageUpdatedPc[this]; }
            set { Fields.ImageUpdatedPc[this] = value; }
        }

        [DisplayName("Image Deleted By"), Expression("jImage.[Deleted_By]")]
        public Int32? ImageDeletedBy
        {
            get { return Fields.ImageDeletedBy[this]; }
            set { Fields.ImageDeletedBy[this] = value; }
        }

        [DisplayName("Image Deleted On"), Expression("jImage.[Deleted_On]")]
        public DateTime? ImageDeletedOn
        {
            get { return Fields.ImageDeletedOn[this]; }
            set { Fields.ImageDeletedOn[this] = value; }
        }

        [DisplayName("Image Deleted Pc"), Expression("jImage.[Deleted_Pc]")]
        public String ImageDeletedPc
        {
            get { return Fields.ImageDeletedPc[this]; }
            set { Fields.ImageDeletedPc[this] = value; }
        }

        [DisplayName("Image Is Delete"), Expression("jImage.[Is_Delete]")]
        public Int16? ImageIsDelete
        {
            get { return Fields.ImageIsDelete[this]; }
            set { Fields.ImageIsDelete[this] = value; }
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

        public SupplierRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field Id;
            public readonly StringField Code;
            public readonly StringField Name;
            public readonly StringField Description;
            public readonly Int32Field UserTypeId;
            public readonly Int32Field UserGroupId;
            public readonly StringField FirstName;
            public readonly StringField MiddleName;
            public readonly StringField LastName;
            public readonly StringField FullName;
            public readonly Int32Field ImageId;
            public readonly StringField Address1;
            public readonly StringField Address2;
            public readonly StringField Mobile;
            public readonly StringField Email;
            public readonly DateTimeField DateOfBirth;
            public readonly StringField LoginName;
            public readonly StringField Password;
            public readonly Int16Field IsTaxable;
            public readonly DecimalField CommissionRate;
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

            public readonly StringField ImageCode;
            public readonly StringField ImageName;
            public readonly StringField ImageDescription;
            public readonly Int32Field ImageImageTypeId;
            public readonly StringField ImagePath;
            public readonly DecimalField ImageSizeKb;
            public readonly DecimalField ImageWidePixel;
            public readonly DecimalField ImageHeightPixel;
            public readonly StringField ImageNote;
            public readonly Int32Field ImageProjectId;
            public readonly Int32Field ImageOrganogramId;
            public readonly Int32Field ImageScopeId;
            public readonly Int32Field ImageCompanyId;
            public readonly Int32Field ImageStatusId;
            public readonly DateTimeField ImageActiveOn;
            public readonly DateTimeField ImageInactiveOn;
            public readonly Int16Field ImageIsActive;
            public readonly Int32Field ImageDbId;
            public readonly Int32Field ImageCreatedBy;
            public readonly DateTimeField ImageCreatedOn;
            public readonly StringField ImageCreatedPc;
            public readonly Int32Field ImageUpdatedBy;
            public readonly DateTimeField ImageUpdatedOn;
            public readonly StringField ImageUpdatedPc;
            public readonly Int32Field ImageDeletedBy;
            public readonly DateTimeField ImageDeletedOn;
            public readonly StringField ImageDeletedPc;
            public readonly Int16Field ImageIsDelete;

            public RowFields()
                : base("[Pur].[Supplier]")
            {
                LocalTextPrefix = "Purchase.Supplier";
            }
        }
    }
}