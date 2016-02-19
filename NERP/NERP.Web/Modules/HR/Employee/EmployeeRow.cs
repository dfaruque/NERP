
namespace NERP.HR.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Employee"), InstanceName("Employee"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class EmployeeRow : Row, IIdRow, INameRow
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

        [DisplayName("User Group"), Column("User_Group_Id"), ForeignKey("[dbo].[User_Group]", "Id"), LeftJoin("jUserGroup"), TextualField("UserGroupCode")]
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

        [DisplayName("Project"), Column("Project_Id"), ForeignKey("[dbo].[Project]", "Id"), LeftJoin("jProject"), TextualField("ProjectCode")]
        public Int32? ProjectId
        {
            get { return Fields.ProjectId[this]; }
            set { Fields.ProjectId[this] = value; }
        }

        [DisplayName("Organogram"), Column("Organogram_Id"), ForeignKey("[dbo].[Organogram]", "Id"), LeftJoin("jOrganogram"), TextualField("OrganogramCode")]
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

        [DisplayName("Company"), Column("Company_Id"), ForeignKey("[dbo].[Company]", "Id"), LeftJoin("jCompany"), TextualField("CompanyCode")]
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

        [DisplayName("User Group Code"), Expression("jUserGroup.[Code]")]
        public String UserGroupCode
        {
            get { return Fields.UserGroupCode[this]; }
            set { Fields.UserGroupCode[this] = value; }
        }

        [DisplayName("User Group Name"), Expression("jUserGroup.[Name]")]
        public String UserGroupName
        {
            get { return Fields.UserGroupName[this]; }
            set { Fields.UserGroupName[this] = value; }
        }

        [DisplayName("User Group Description"), Expression("jUserGroup.[Description]")]
        public String UserGroupDescription
        {
            get { return Fields.UserGroupDescription[this]; }
            set { Fields.UserGroupDescription[this] = value; }
        }

        [DisplayName("User Group Note"), Expression("jUserGroup.[Note]")]
        public String UserGroupNote
        {
            get { return Fields.UserGroupNote[this]; }
            set { Fields.UserGroupNote[this] = value; }
        }

        [DisplayName("User Group Project Id"), Expression("jUserGroup.[Project_Id]")]
        public Int32? UserGroupProjectId
        {
            get { return Fields.UserGroupProjectId[this]; }
            set { Fields.UserGroupProjectId[this] = value; }
        }

        [DisplayName("User Group Organogram Id"), Expression("jUserGroup.[Organogram_Id]")]
        public Int32? UserGroupOrganogramId
        {
            get { return Fields.UserGroupOrganogramId[this]; }
            set { Fields.UserGroupOrganogramId[this] = value; }
        }

        [DisplayName("User Group Scope Id"), Expression("jUserGroup.[Scope_Id]")]
        public Int32? UserGroupScopeId
        {
            get { return Fields.UserGroupScopeId[this]; }
            set { Fields.UserGroupScopeId[this] = value; }
        }

        [DisplayName("User Group Company Id"), Expression("jUserGroup.[Company_Id]")]
        public Int32? UserGroupCompanyId
        {
            get { return Fields.UserGroupCompanyId[this]; }
            set { Fields.UserGroupCompanyId[this] = value; }
        }

        [DisplayName("User Group Status Id"), Expression("jUserGroup.[Status_Id]")]
        public Int32? UserGroupStatusId
        {
            get { return Fields.UserGroupStatusId[this]; }
            set { Fields.UserGroupStatusId[this] = value; }
        }

        [DisplayName("User Group Active On"), Expression("jUserGroup.[Active_On]")]
        public DateTime? UserGroupActiveOn
        {
            get { return Fields.UserGroupActiveOn[this]; }
            set { Fields.UserGroupActiveOn[this] = value; }
        }

        [DisplayName("User Group Inactive On"), Expression("jUserGroup.[Inactive_On]")]
        public DateTime? UserGroupInactiveOn
        {
            get { return Fields.UserGroupInactiveOn[this]; }
            set { Fields.UserGroupInactiveOn[this] = value; }
        }

        [DisplayName("User Group Is Active"), Expression("jUserGroup.[Is_Active]")]
        public Int16? UserGroupIsActive
        {
            get { return Fields.UserGroupIsActive[this]; }
            set { Fields.UserGroupIsActive[this] = value; }
        }

        [DisplayName("User Group Db Id"), Expression("jUserGroup.[Db_Id]")]
        public Int32? UserGroupDbId
        {
            get { return Fields.UserGroupDbId[this]; }
            set { Fields.UserGroupDbId[this] = value; }
        }

        [DisplayName("User Group Created By"), Expression("jUserGroup.[Created_By]")]
        public Int32? UserGroupCreatedBy
        {
            get { return Fields.UserGroupCreatedBy[this]; }
            set { Fields.UserGroupCreatedBy[this] = value; }
        }

        [DisplayName("User Group Created On"), Expression("jUserGroup.[Created_On]")]
        public DateTime? UserGroupCreatedOn
        {
            get { return Fields.UserGroupCreatedOn[this]; }
            set { Fields.UserGroupCreatedOn[this] = value; }
        }

        [DisplayName("User Group Created Pc"), Expression("jUserGroup.[Created_Pc]")]
        public String UserGroupCreatedPc
        {
            get { return Fields.UserGroupCreatedPc[this]; }
            set { Fields.UserGroupCreatedPc[this] = value; }
        }

        [DisplayName("User Group Updated By"), Expression("jUserGroup.[Updated_By]")]
        public Int32? UserGroupUpdatedBy
        {
            get { return Fields.UserGroupUpdatedBy[this]; }
            set { Fields.UserGroupUpdatedBy[this] = value; }
        }

        [DisplayName("User Group Updated On"), Expression("jUserGroup.[Updated_On]")]
        public DateTime? UserGroupUpdatedOn
        {
            get { return Fields.UserGroupUpdatedOn[this]; }
            set { Fields.UserGroupUpdatedOn[this] = value; }
        }

        [DisplayName("User Group Updated Pc"), Expression("jUserGroup.[Updated_Pc]")]
        public String UserGroupUpdatedPc
        {
            get { return Fields.UserGroupUpdatedPc[this]; }
            set { Fields.UserGroupUpdatedPc[this] = value; }
        }

        [DisplayName("User Group Deleted By"), Expression("jUserGroup.[Deleted_By]")]
        public Int32? UserGroupDeletedBy
        {
            get { return Fields.UserGroupDeletedBy[this]; }
            set { Fields.UserGroupDeletedBy[this] = value; }
        }

        [DisplayName("User Group Deleted On"), Expression("jUserGroup.[Deleted_On]")]
        public DateTime? UserGroupDeletedOn
        {
            get { return Fields.UserGroupDeletedOn[this]; }
            set { Fields.UserGroupDeletedOn[this] = value; }
        }

        [DisplayName("User Group Deleted Pc"), Expression("jUserGroup.[Deleted_Pc]")]
        public String UserGroupDeletedPc
        {
            get { return Fields.UserGroupDeletedPc[this]; }
            set { Fields.UserGroupDeletedPc[this] = value; }
        }

        [DisplayName("User Group Is Delete"), Expression("jUserGroup.[Is_Delete]")]
        public Int16? UserGroupIsDelete
        {
            get { return Fields.UserGroupIsDelete[this]; }
            set { Fields.UserGroupIsDelete[this] = value; }
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

        [DisplayName("Project Code"), Expression("jProject.[Code]")]
        public String ProjectCode
        {
            get { return Fields.ProjectCode[this]; }
            set { Fields.ProjectCode[this] = value; }
        }

        [DisplayName("Project Name"), Expression("jProject.[Name]")]
        public String ProjectName
        {
            get { return Fields.ProjectName[this]; }
            set { Fields.ProjectName[this] = value; }
        }

        [DisplayName("Project Description"), Expression("jProject.[Description]")]
        public String ProjectDescription
        {
            get { return Fields.ProjectDescription[this]; }
            set { Fields.ProjectDescription[this] = value; }
        }

        [DisplayName("Project Note"), Expression("jProject.[Note]")]
        public String ProjectNote
        {
            get { return Fields.ProjectNote[this]; }
            set { Fields.ProjectNote[this] = value; }
        }

        [DisplayName("Project Project Id"), Expression("jProject.[Project_Id]")]
        public Int32? ProjectProjectId
        {
            get { return Fields.ProjectProjectId[this]; }
            set { Fields.ProjectProjectId[this] = value; }
        }

        [DisplayName("Project Organogram Id"), Expression("jProject.[Organogram_Id]")]
        public Int32? ProjectOrganogramId
        {
            get { return Fields.ProjectOrganogramId[this]; }
            set { Fields.ProjectOrganogramId[this] = value; }
        }

        [DisplayName("Project Scope Id"), Expression("jProject.[Scope_Id]")]
        public Int32? ProjectScopeId
        {
            get { return Fields.ProjectScopeId[this]; }
            set { Fields.ProjectScopeId[this] = value; }
        }

        [DisplayName("Project Company Id"), Expression("jProject.[Company_Id]")]
        public Int32? ProjectCompanyId
        {
            get { return Fields.ProjectCompanyId[this]; }
            set { Fields.ProjectCompanyId[this] = value; }
        }

        [DisplayName("Project Status Id"), Expression("jProject.[Status_Id]")]
        public Int32? ProjectStatusId
        {
            get { return Fields.ProjectStatusId[this]; }
            set { Fields.ProjectStatusId[this] = value; }
        }

        [DisplayName("Project Active On"), Expression("jProject.[Active_On]")]
        public DateTime? ProjectActiveOn
        {
            get { return Fields.ProjectActiveOn[this]; }
            set { Fields.ProjectActiveOn[this] = value; }
        }

        [DisplayName("Project Inactive On"), Expression("jProject.[Inactive_On]")]
        public DateTime? ProjectInactiveOn
        {
            get { return Fields.ProjectInactiveOn[this]; }
            set { Fields.ProjectInactiveOn[this] = value; }
        }

        [DisplayName("Project Is Active"), Expression("jProject.[Is_Active]")]
        public Int16? ProjectIsActive
        {
            get { return Fields.ProjectIsActive[this]; }
            set { Fields.ProjectIsActive[this] = value; }
        }

        [DisplayName("Project Db Id"), Expression("jProject.[Db_Id]")]
        public Int32? ProjectDbId
        {
            get { return Fields.ProjectDbId[this]; }
            set { Fields.ProjectDbId[this] = value; }
        }

        [DisplayName("Project Created By"), Expression("jProject.[Created_By]")]
        public Int32? ProjectCreatedBy
        {
            get { return Fields.ProjectCreatedBy[this]; }
            set { Fields.ProjectCreatedBy[this] = value; }
        }

        [DisplayName("Project Created On"), Expression("jProject.[Created_On]")]
        public DateTime? ProjectCreatedOn
        {
            get { return Fields.ProjectCreatedOn[this]; }
            set { Fields.ProjectCreatedOn[this] = value; }
        }

        [DisplayName("Project Created Pc"), Expression("jProject.[Created_Pc]")]
        public String ProjectCreatedPc
        {
            get { return Fields.ProjectCreatedPc[this]; }
            set { Fields.ProjectCreatedPc[this] = value; }
        }

        [DisplayName("Project Updated By"), Expression("jProject.[Updated_By]")]
        public Int32? ProjectUpdatedBy
        {
            get { return Fields.ProjectUpdatedBy[this]; }
            set { Fields.ProjectUpdatedBy[this] = value; }
        }

        [DisplayName("Project Updated On"), Expression("jProject.[Updated_On]")]
        public DateTime? ProjectUpdatedOn
        {
            get { return Fields.ProjectUpdatedOn[this]; }
            set { Fields.ProjectUpdatedOn[this] = value; }
        }

        [DisplayName("Project Updated Pc"), Expression("jProject.[Updated_Pc]")]
        public String ProjectUpdatedPc
        {
            get { return Fields.ProjectUpdatedPc[this]; }
            set { Fields.ProjectUpdatedPc[this] = value; }
        }

        [DisplayName("Project Deleted By"), Expression("jProject.[Deleted_By]")]
        public Int32? ProjectDeletedBy
        {
            get { return Fields.ProjectDeletedBy[this]; }
            set { Fields.ProjectDeletedBy[this] = value; }
        }

        [DisplayName("Project Deleted On"), Expression("jProject.[Deleted_On]")]
        public DateTime? ProjectDeletedOn
        {
            get { return Fields.ProjectDeletedOn[this]; }
            set { Fields.ProjectDeletedOn[this] = value; }
        }

        [DisplayName("Project Deleted Pc"), Expression("jProject.[Deleted_Pc]")]
        public String ProjectDeletedPc
        {
            get { return Fields.ProjectDeletedPc[this]; }
            set { Fields.ProjectDeletedPc[this] = value; }
        }

        [DisplayName("Project Is Delete"), Expression("jProject.[Is_Delete]")]
        public Int16? ProjectIsDelete
        {
            get { return Fields.ProjectIsDelete[this]; }
            set { Fields.ProjectIsDelete[this] = value; }
        }

        [DisplayName("Organogram Code"), Expression("jOrganogram.[Code]")]
        public String OrganogramCode
        {
            get { return Fields.OrganogramCode[this]; }
            set { Fields.OrganogramCode[this] = value; }
        }

        [DisplayName("Organogram Name"), Expression("jOrganogram.[Name]")]
        public String OrganogramName
        {
            get { return Fields.OrganogramName[this]; }
            set { Fields.OrganogramName[this] = value; }
        }

        [DisplayName("Organogram Description"), Expression("jOrganogram.[Description]")]
        public String OrganogramDescription
        {
            get { return Fields.OrganogramDescription[this]; }
            set { Fields.OrganogramDescription[this] = value; }
        }

        [DisplayName("Organogram Parent Id"), Expression("jOrganogram.[Parent_Id]")]
        public Int32? OrganogramParentId
        {
            get { return Fields.OrganogramParentId[this]; }
            set { Fields.OrganogramParentId[this] = value; }
        }

        [DisplayName("Organogram Note"), Expression("jOrganogram.[Note]")]
        public String OrganogramNote
        {
            get { return Fields.OrganogramNote[this]; }
            set { Fields.OrganogramNote[this] = value; }
        }

        [DisplayName("Organogram Project Id"), Expression("jOrganogram.[Project_Id]")]
        public Int32? OrganogramProjectId
        {
            get { return Fields.OrganogramProjectId[this]; }
            set { Fields.OrganogramProjectId[this] = value; }
        }

        [DisplayName("Organogram Organogram Id"), Expression("jOrganogram.[Organogram_Id]")]
        public Int32? OrganogramOrganogramId
        {
            get { return Fields.OrganogramOrganogramId[this]; }
            set { Fields.OrganogramOrganogramId[this] = value; }
        }

        [DisplayName("Organogram Scope Id"), Expression("jOrganogram.[Scope_Id]")]
        public Int32? OrganogramScopeId
        {
            get { return Fields.OrganogramScopeId[this]; }
            set { Fields.OrganogramScopeId[this] = value; }
        }

        [DisplayName("Organogram Company Id"), Expression("jOrganogram.[Company_Id]")]
        public Int32? OrganogramCompanyId
        {
            get { return Fields.OrganogramCompanyId[this]; }
            set { Fields.OrganogramCompanyId[this] = value; }
        }

        [DisplayName("Organogram Status Id"), Expression("jOrganogram.[Status_Id]")]
        public Int32? OrganogramStatusId
        {
            get { return Fields.OrganogramStatusId[this]; }
            set { Fields.OrganogramStatusId[this] = value; }
        }

        [DisplayName("Organogram Active On"), Expression("jOrganogram.[Active_On]")]
        public DateTime? OrganogramActiveOn
        {
            get { return Fields.OrganogramActiveOn[this]; }
            set { Fields.OrganogramActiveOn[this] = value; }
        }

        [DisplayName("Organogram Inactive On"), Expression("jOrganogram.[Inactive_On]")]
        public DateTime? OrganogramInactiveOn
        {
            get { return Fields.OrganogramInactiveOn[this]; }
            set { Fields.OrganogramInactiveOn[this] = value; }
        }

        [DisplayName("Organogram Is Active"), Expression("jOrganogram.[Is_Active]")]
        public Int16? OrganogramIsActive
        {
            get { return Fields.OrganogramIsActive[this]; }
            set { Fields.OrganogramIsActive[this] = value; }
        }

        [DisplayName("Organogram Db Id"), Expression("jOrganogram.[Db_Id]")]
        public Int32? OrganogramDbId
        {
            get { return Fields.OrganogramDbId[this]; }
            set { Fields.OrganogramDbId[this] = value; }
        }

        [DisplayName("Organogram Created By"), Expression("jOrganogram.[Created_By]")]
        public Int32? OrganogramCreatedBy
        {
            get { return Fields.OrganogramCreatedBy[this]; }
            set { Fields.OrganogramCreatedBy[this] = value; }
        }

        [DisplayName("Organogram Created On"), Expression("jOrganogram.[Created_On]")]
        public DateTime? OrganogramCreatedOn
        {
            get { return Fields.OrganogramCreatedOn[this]; }
            set { Fields.OrganogramCreatedOn[this] = value; }
        }

        [DisplayName("Organogram Created Pc"), Expression("jOrganogram.[Created_Pc]")]
        public String OrganogramCreatedPc
        {
            get { return Fields.OrganogramCreatedPc[this]; }
            set { Fields.OrganogramCreatedPc[this] = value; }
        }

        [DisplayName("Organogram Updated By"), Expression("jOrganogram.[Updated_By]")]
        public Int32? OrganogramUpdatedBy
        {
            get { return Fields.OrganogramUpdatedBy[this]; }
            set { Fields.OrganogramUpdatedBy[this] = value; }
        }

        [DisplayName("Organogram Updated On"), Expression("jOrganogram.[Updated_On]")]
        public DateTime? OrganogramUpdatedOn
        {
            get { return Fields.OrganogramUpdatedOn[this]; }
            set { Fields.OrganogramUpdatedOn[this] = value; }
        }

        [DisplayName("Organogram Updated Pc"), Expression("jOrganogram.[Updated_Pc]")]
        public String OrganogramUpdatedPc
        {
            get { return Fields.OrganogramUpdatedPc[this]; }
            set { Fields.OrganogramUpdatedPc[this] = value; }
        }

        [DisplayName("Organogram Deleted By"), Expression("jOrganogram.[Deleted_By]")]
        public Int32? OrganogramDeletedBy
        {
            get { return Fields.OrganogramDeletedBy[this]; }
            set { Fields.OrganogramDeletedBy[this] = value; }
        }

        [DisplayName("Organogram Deleted On"), Expression("jOrganogram.[Deleted_On]")]
        public DateTime? OrganogramDeletedOn
        {
            get { return Fields.OrganogramDeletedOn[this]; }
            set { Fields.OrganogramDeletedOn[this] = value; }
        }

        [DisplayName("Organogram Deleted Pc"), Expression("jOrganogram.[Deleted_Pc]")]
        public String OrganogramDeletedPc
        {
            get { return Fields.OrganogramDeletedPc[this]; }
            set { Fields.OrganogramDeletedPc[this] = value; }
        }

        [DisplayName("Organogram Is Delete"), Expression("jOrganogram.[Is_Delete]")]
        public Int16? OrganogramIsDelete
        {
            get { return Fields.OrganogramIsDelete[this]; }
            set { Fields.OrganogramIsDelete[this] = value; }
        }

        [DisplayName("Company Code"), Expression("jCompany.[Code]")]
        public String CompanyCode
        {
            get { return Fields.CompanyCode[this]; }
            set { Fields.CompanyCode[this] = value; }
        }

        [DisplayName("Company Name"), Expression("jCompany.[Name]")]
        public String CompanyName
        {
            get { return Fields.CompanyName[this]; }
            set { Fields.CompanyName[this] = value; }
        }

        [DisplayName("Company Description"), Expression("jCompany.[Description]")]
        public String CompanyDescription
        {
            get { return Fields.CompanyDescription[this]; }
            set { Fields.CompanyDescription[this] = value; }
        }

        [DisplayName("Company Image Id"), Expression("jCompany.[Image_Id]")]
        public Int32? CompanyImageId
        {
            get { return Fields.CompanyImageId[this]; }
            set { Fields.CompanyImageId[this] = value; }
        }

        [DisplayName("Company Note"), Expression("jCompany.[Note]")]
        public String CompanyNote
        {
            get { return Fields.CompanyNote[this]; }
            set { Fields.CompanyNote[this] = value; }
        }

        [DisplayName("Company Project Id"), Expression("jCompany.[Project_Id]")]
        public Int32? CompanyProjectId
        {
            get { return Fields.CompanyProjectId[this]; }
            set { Fields.CompanyProjectId[this] = value; }
        }

        [DisplayName("Company Organogram Id"), Expression("jCompany.[Organogram_Id]")]
        public Int32? CompanyOrganogramId
        {
            get { return Fields.CompanyOrganogramId[this]; }
            set { Fields.CompanyOrganogramId[this] = value; }
        }

        [DisplayName("Company Scope Id"), Expression("jCompany.[Scope_Id]")]
        public Int32? CompanyScopeId
        {
            get { return Fields.CompanyScopeId[this]; }
            set { Fields.CompanyScopeId[this] = value; }
        }

        [DisplayName("Company Company Id"), Expression("jCompany.[Company_Id]")]
        public Int32? CompanyCompanyId
        {
            get { return Fields.CompanyCompanyId[this]; }
            set { Fields.CompanyCompanyId[this] = value; }
        }

        [DisplayName("Company Status Id"), Expression("jCompany.[Status_Id]")]
        public Int32? CompanyStatusId
        {
            get { return Fields.CompanyStatusId[this]; }
            set { Fields.CompanyStatusId[this] = value; }
        }

        [DisplayName("Company Active On"), Expression("jCompany.[Active_On]")]
        public DateTime? CompanyActiveOn
        {
            get { return Fields.CompanyActiveOn[this]; }
            set { Fields.CompanyActiveOn[this] = value; }
        }

        [DisplayName("Company Inactive On"), Expression("jCompany.[Inactive_On]")]
        public DateTime? CompanyInactiveOn
        {
            get { return Fields.CompanyInactiveOn[this]; }
            set { Fields.CompanyInactiveOn[this] = value; }
        }

        [DisplayName("Company Is Active"), Expression("jCompany.[Is_Active]")]
        public Int16? CompanyIsActive
        {
            get { return Fields.CompanyIsActive[this]; }
            set { Fields.CompanyIsActive[this] = value; }
        }

        [DisplayName("Company Db Id"), Expression("jCompany.[Db_Id]")]
        public Int32? CompanyDbId
        {
            get { return Fields.CompanyDbId[this]; }
            set { Fields.CompanyDbId[this] = value; }
        }

        [DisplayName("Company Created By"), Expression("jCompany.[Created_By]")]
        public Int32? CompanyCreatedBy
        {
            get { return Fields.CompanyCreatedBy[this]; }
            set { Fields.CompanyCreatedBy[this] = value; }
        }

        [DisplayName("Company Created On"), Expression("jCompany.[Created_On]")]
        public DateTime? CompanyCreatedOn
        {
            get { return Fields.CompanyCreatedOn[this]; }
            set { Fields.CompanyCreatedOn[this] = value; }
        }

        [DisplayName("Company Created Pc"), Expression("jCompany.[Created_Pc]")]
        public String CompanyCreatedPc
        {
            get { return Fields.CompanyCreatedPc[this]; }
            set { Fields.CompanyCreatedPc[this] = value; }
        }

        [DisplayName("Company Updated By"), Expression("jCompany.[Updated_By]")]
        public Int32? CompanyUpdatedBy
        {
            get { return Fields.CompanyUpdatedBy[this]; }
            set { Fields.CompanyUpdatedBy[this] = value; }
        }

        [DisplayName("Company Updated On"), Expression("jCompany.[Updated_On]")]
        public DateTime? CompanyUpdatedOn
        {
            get { return Fields.CompanyUpdatedOn[this]; }
            set { Fields.CompanyUpdatedOn[this] = value; }
        }

        [DisplayName("Company Updated Pc"), Expression("jCompany.[Updated_Pc]")]
        public String CompanyUpdatedPc
        {
            get { return Fields.CompanyUpdatedPc[this]; }
            set { Fields.CompanyUpdatedPc[this] = value; }
        }

        [DisplayName("Company Deleted By"), Expression("jCompany.[Deleted_By]")]
        public Int32? CompanyDeletedBy
        {
            get { return Fields.CompanyDeletedBy[this]; }
            set { Fields.CompanyDeletedBy[this] = value; }
        }

        [DisplayName("Company Deleted On"), Expression("jCompany.[Deleted_On]")]
        public DateTime? CompanyDeletedOn
        {
            get { return Fields.CompanyDeletedOn[this]; }
            set { Fields.CompanyDeletedOn[this] = value; }
        }

        [DisplayName("Company Deleted Pc"), Expression("jCompany.[Deleted_Pc]")]
        public String CompanyDeletedPc
        {
            get { return Fields.CompanyDeletedPc[this]; }
            set { Fields.CompanyDeletedPc[this] = value; }
        }

        [DisplayName("Company Is Delete"), Expression("jCompany.[Is_Delete]")]
        public Int16? CompanyIsDelete
        {
            get { return Fields.CompanyIsDelete[this]; }
            set { Fields.CompanyIsDelete[this] = value; }
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

        public EmployeeRow()
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

            public readonly StringField UserGroupCode;
            public readonly StringField UserGroupName;
            public readonly StringField UserGroupDescription;
            public readonly StringField UserGroupNote;
            public readonly Int32Field UserGroupProjectId;
            public readonly Int32Field UserGroupOrganogramId;
            public readonly Int32Field UserGroupScopeId;
            public readonly Int32Field UserGroupCompanyId;
            public readonly Int32Field UserGroupStatusId;
            public readonly DateTimeField UserGroupActiveOn;
            public readonly DateTimeField UserGroupInactiveOn;
            public readonly Int16Field UserGroupIsActive;
            public readonly Int32Field UserGroupDbId;
            public readonly Int32Field UserGroupCreatedBy;
            public readonly DateTimeField UserGroupCreatedOn;
            public readonly StringField UserGroupCreatedPc;
            public readonly Int32Field UserGroupUpdatedBy;
            public readonly DateTimeField UserGroupUpdatedOn;
            public readonly StringField UserGroupUpdatedPc;
            public readonly Int32Field UserGroupDeletedBy;
            public readonly DateTimeField UserGroupDeletedOn;
            public readonly StringField UserGroupDeletedPc;
            public readonly Int16Field UserGroupIsDelete;

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

            public readonly StringField ProjectCode;
            public readonly StringField ProjectName;
            public readonly StringField ProjectDescription;
            public readonly StringField ProjectNote;
            public readonly Int32Field ProjectProjectId;
            public readonly Int32Field ProjectOrganogramId;
            public readonly Int32Field ProjectScopeId;
            public readonly Int32Field ProjectCompanyId;
            public readonly Int32Field ProjectStatusId;
            public readonly DateTimeField ProjectActiveOn;
            public readonly DateTimeField ProjectInactiveOn;
            public readonly Int16Field ProjectIsActive;
            public readonly Int32Field ProjectDbId;
            public readonly Int32Field ProjectCreatedBy;
            public readonly DateTimeField ProjectCreatedOn;
            public readonly StringField ProjectCreatedPc;
            public readonly Int32Field ProjectUpdatedBy;
            public readonly DateTimeField ProjectUpdatedOn;
            public readonly StringField ProjectUpdatedPc;
            public readonly Int32Field ProjectDeletedBy;
            public readonly DateTimeField ProjectDeletedOn;
            public readonly StringField ProjectDeletedPc;
            public readonly Int16Field ProjectIsDelete;

            public readonly StringField OrganogramCode;
            public readonly StringField OrganogramName;
            public readonly StringField OrganogramDescription;
            public readonly Int32Field OrganogramParentId;
            public readonly StringField OrganogramNote;
            public readonly Int32Field OrganogramProjectId;
            public readonly Int32Field OrganogramOrganogramId;
            public readonly Int32Field OrganogramScopeId;
            public readonly Int32Field OrganogramCompanyId;
            public readonly Int32Field OrganogramStatusId;
            public readonly DateTimeField OrganogramActiveOn;
            public readonly DateTimeField OrganogramInactiveOn;
            public readonly Int16Field OrganogramIsActive;
            public readonly Int32Field OrganogramDbId;
            public readonly Int32Field OrganogramCreatedBy;
            public readonly DateTimeField OrganogramCreatedOn;
            public readonly StringField OrganogramCreatedPc;
            public readonly Int32Field OrganogramUpdatedBy;
            public readonly DateTimeField OrganogramUpdatedOn;
            public readonly StringField OrganogramUpdatedPc;
            public readonly Int32Field OrganogramDeletedBy;
            public readonly DateTimeField OrganogramDeletedOn;
            public readonly StringField OrganogramDeletedPc;
            public readonly Int16Field OrganogramIsDelete;

            public readonly StringField CompanyCode;
            public readonly StringField CompanyName;
            public readonly StringField CompanyDescription;
            public readonly Int32Field CompanyImageId;
            public readonly StringField CompanyNote;
            public readonly Int32Field CompanyProjectId;
            public readonly Int32Field CompanyOrganogramId;
            public readonly Int32Field CompanyScopeId;
            public readonly Int32Field CompanyCompanyId;
            public readonly Int32Field CompanyStatusId;
            public readonly DateTimeField CompanyActiveOn;
            public readonly DateTimeField CompanyInactiveOn;
            public readonly Int16Field CompanyIsActive;
            public readonly Int32Field CompanyDbId;
            public readonly Int32Field CompanyCreatedBy;
            public readonly DateTimeField CompanyCreatedOn;
            public readonly StringField CompanyCreatedPc;
            public readonly Int32Field CompanyUpdatedBy;
            public readonly DateTimeField CompanyUpdatedOn;
            public readonly StringField CompanyUpdatedPc;
            public readonly Int32Field CompanyDeletedBy;
            public readonly DateTimeField CompanyDeletedOn;
            public readonly StringField CompanyDeletedPc;
            public readonly Int16Field CompanyIsDelete;

            public RowFields()
                : base("[HRM].[Employee]")
            {
                LocalTextPrefix = "HR.Employee";
            }
        }
    }
}