
namespace NERP.Sales
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class CustomerRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string NameProperty = "Name";
        [InlineConstant] public const string LocalTextPrefix = "Sales.Customer";
    
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
        public String ProjectName { get; set; }
        public String CompanyName { get; set; }
        public Int32? Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Note { get; set; }
        public Int32? ProjectId { get; set; }
        public String Project { get; set; }
        public Int32? OrganogramId { get; set; }
        public String Organogram { get; set; }
        public Int32? ScopeId { get; set; }
        public Int32? CompanyId { get; set; }
        public Int32? StatusId { get; set; }
        public String ActiveOn { get; set; }
        public String InactiveOn { get; set; }
        public Int16? IsActive { get; set; }
        public Int32? DbId { get; set; }
        public Int32? CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        public String CreatedPc { get; set; }
        public Int32? UpdatedBy { get; set; }
        public String UpdatedOn { get; set; }
        public String UpdatedPc { get; set; }
        public Int32? DeletedBy { get; set; }
        public String DeletedOn { get; set; }
        public String DeletedPc { get; set; }
        public Int16? IsDelete { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
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
            [InlineConstant] public const string ProjectName = "ProjectName";
            [InlineConstant] public const string CompanyName = "CompanyName";
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Code = "Code";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string Note = "Note";
            [InlineConstant] public const string ProjectId = "ProjectId";
            [InlineConstant] public const string Project = "Project";
            [InlineConstant] public const string OrganogramId = "OrganogramId";
            [InlineConstant] public const string Organogram = "Organogram";
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
        }
    }
    
}

