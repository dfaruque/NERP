﻿
namespace NERP.Purchase
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class SupplierRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string NameProperty = "Code";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string LocalTextPrefix = "Purchase.Supplier";

        public Int32? Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Int32? UserTypeId { get; set; }
        public Int32? UserGroupId { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String FullName { get; set; }
        public Int32? ImageId { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Mobile { get; set; }
        public String Email { get; set; }
        public String DateOfBirth { get; set; }
        public String LoginName { get; set; }
        public String Password { get; set; }
        public Int16? IsTaxable { get; set; }
        public Decimal? CommissionRate { get; set; }
        public String Note { get; set; }
        public Int32? ProjectId { get; set; }
        public Int32? OrganogramId { get; set; }
        public Int32? ScopeId { get; set; }
        public Int32? CompanyId { get; set; }
        public Int32? StatusId { get; set; }
        public String ActiveOn { get; set; }
        public String InactiveOn { get; set; }
        public Int16? IsActive { get; set; }
        public Int32? DbId { get; set; }
        public Int32? CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        //public String CreatedPc { get; set; }
        public Int32? UpdatedBy { get; set; }
        public String UpdatedOn { get; set; }
        //public String UpdatedPc { get; set; }
        public Int32? DeletedBy { get; set; }
        public String DeletedOn { get; set; }
        //public String DeletedPc { get; set; }
        public Int16? IsDelete { get; set; }
        public String ImageCode { get; set; }
        public String ImageName { get; set; }
        public String ImageDescription { get; set; }
        public Int32? ImageImageTypeId { get; set; }
        public String ImagePath { get; set; }
        public Decimal? ImageSizeKb { get; set; }
        public Decimal? ImageWidePixel { get; set; }
        public Decimal? ImageHeightPixel { get; set; }
        public String ImageNote { get; set; }
        public Int32? ImageProjectId { get; set; }
        public Int32? ImageOrganogramId { get; set; }
        public Int32? ImageScopeId { get; set; }
        public Int32? ImageCompanyId { get; set; }
        public Int32? ImageStatusId { get; set; }
        public String ImageActiveOn { get; set; }
        public String ImageInactiveOn { get; set; }
        public Int16? ImageIsActive { get; set; }
        public Int32? ImageDbId { get; set; }
        public Int32? ImageCreatedBy { get; set; }
        public String ImageCreatedOn { get; set; }
        public String ImageCreatedPc { get; set; }
        public Int32? ImageUpdatedBy { get; set; }
        public String ImageUpdatedOn { get; set; }
        public String ImageUpdatedPc { get; set; }
        public Int32? ImageDeletedBy { get; set; }
        public String ImageDeletedOn { get; set; }
        public String ImageDeletedPc { get; set; }
        public Int16? ImageIsDelete { get; set; }

        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Code = "Code";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string UserTypeId = "UserTypeId";
            [InlineConstant] public const string UserGroupId = "UserGroupId";
            [InlineConstant] public const string FirstName = "FirstName";
            [InlineConstant] public const string MiddleName = "MiddleName";
            [InlineConstant] public const string LastName = "LastName";
            [InlineConstant] public const string FullName = "FullName";
            [InlineConstant] public const string ImageId = "ImageId";
            [InlineConstant] public const string Address1 = "Address1";
            [InlineConstant] public const string Address2 = "Address2";
            [InlineConstant] public const string Mobile = "Mobile";
            [InlineConstant] public const string Email = "Email";
            [InlineConstant] public const string DateOfBirth = "DateOfBirth";
            [InlineConstant] public const string LoginName = "LoginName";
            [InlineConstant] public const string Password = "Password";
            [InlineConstant] public const string IsTaxable = "IsTaxable";
            [InlineConstant] public const string CommissionRate = "CommissionRate";
            [InlineConstant] public const string Note = "Note";
            [InlineConstant] public const string ProjectId = "ProjectId";
            [InlineConstant] public const string OrganogramId = "OrganogramId";
            [InlineConstant] public const string ScopeId = "ScopeId";
            [InlineConstant] public const string CompanyId = "CompanyId";
            [InlineConstant] public const string StatusId = "StatusId";
            [InlineConstant] public const string ActiveOn = "ActiveOn";
            [InlineConstant] public const string InactiveOn = "InactiveOn";
            [InlineConstant] public const string IsActive = "IsActive";
            [InlineConstant] public const string DbId = "DbId";
            [InlineConstant] public const string CreatedBy = "CreatedBy";
            [InlineConstant] public const string CreatedOn = "CreatedOn";
            [InlineConstant] public const string CreatedPc = "CreatedPc";
            [InlineConstant] public const string UpdatedBy = "UpdatedBy";
            [InlineConstant] public const string UpdatedOn = "UpdatedOn";
            [InlineConstant] public const string UpdatedPc = "UpdatedPc";
            [InlineConstant] public const string DeletedBy = "DeletedBy";
            [InlineConstant] public const string DeletedOn = "DeletedOn";
            [InlineConstant] public const string DeletedPc = "DeletedPc";
            [InlineConstant] public const string IsDelete = "IsDelete";
            [InlineConstant] public const string ImageCode = "ImageCode";
            [InlineConstant] public const string ImageName = "ImageName";
            [InlineConstant] public const string ImageDescription = "ImageDescription";
            [InlineConstant] public const string ImageImageTypeId = "ImageImageTypeId";
            [InlineConstant] public const string ImagePath = "ImagePath";
            [InlineConstant] public const string ImageSizeKb = "ImageSizeKb";
            [InlineConstant] public const string ImageWidePixel = "ImageWidePixel";
            [InlineConstant] public const string ImageHeightPixel = "ImageHeightPixel";
            [InlineConstant] public const string ImageNote = "ImageNote";
            [InlineConstant] public const string ImageProjectId = "ImageProjectId";
            [InlineConstant] public const string ImageOrganogramId = "ImageOrganogramId";
            [InlineConstant] public const string ImageScopeId = "ImageScopeId";
            [InlineConstant] public const string ImageCompanyId = "ImageCompanyId";
            [InlineConstant] public const string ImageStatusId = "ImageStatusId";
            [InlineConstant] public const string ImageActiveOn = "ImageActiveOn";
            [InlineConstant] public const string ImageInactiveOn = "ImageInactiveOn";
            [InlineConstant] public const string ImageIsActive = "ImageIsActive";
            [InlineConstant] public const string ImageDbId = "ImageDbId";
            [InlineConstant] public const string ImageCreatedBy = "ImageCreatedBy";
            [InlineConstant] public const string ImageCreatedOn = "ImageCreatedOn";
            [InlineConstant] public const string ImageCreatedPc = "ImageCreatedPc";
            [InlineConstant] public const string ImageUpdatedBy = "ImageUpdatedBy";
            [InlineConstant] public const string ImageUpdatedOn = "ImageUpdatedOn";
            [InlineConstant] public const string ImageUpdatedPc = "ImageUpdatedPc";
            [InlineConstant] public const string ImageDeletedBy = "ImageDeletedBy";
            [InlineConstant] public const string ImageDeletedOn = "ImageDeletedOn";
            [InlineConstant] public const string ImageDeletedPc = "ImageDeletedPc";
            [InlineConstant] public const string ImageIsDelete = "ImageIsDelete";
        }
    }
}