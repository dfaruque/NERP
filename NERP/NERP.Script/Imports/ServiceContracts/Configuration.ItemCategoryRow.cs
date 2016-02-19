
namespace NERP.Configuration
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class ItemCategoryRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string NameProperty = "Code";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string LocalTextPrefix = "Configuration.ItemCategory";

        public Int32? Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Int32? ParentId { get; set; }
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
        public String ParentCode { get; set; }
        public String ParentName { get; set; }
        public String ParentDescription { get; set; }
        public Int32? ParentParentId { get; set; }
        public String ParentNote { get; set; }
        public Int32? ParentProjectId { get; set; }
        public Int32? ParentOrganogramId { get; set; }
        public Int32? ParentScopeId { get; set; }
        public Int32? ParentCompanyId { get; set; }
        public Int32? ParentStatusId { get; set; }
        public String ParentActiveOn { get; set; }
        public String ParentInactiveOn { get; set; }
        public Int16? ParentIsActive { get; set; }
        public Int32? ParentDbId { get; set; }
        public Int32? ParentCreatedBy { get; set; }
        public String ParentCreatedOn { get; set; }
        public String ParentCreatedPc { get; set; }
        public Int32? ParentUpdatedBy { get; set; }
        public String ParentUpdatedOn { get; set; }
        public String ParentUpdatedPc { get; set; }
        public Int32? ParentDeletedBy { get; set; }
        public String ParentDeletedOn { get; set; }
        public String ParentDeletedPc { get; set; }
        public Int16? ParentIsDelete { get; set; }

        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Code = "Code";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string ParentId = "ParentId";
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
            [InlineConstant] public const string ParentCode = "ParentCode";
            [InlineConstant] public const string ParentName = "ParentName";
            [InlineConstant] public const string ParentDescription = "ParentDescription";
            [InlineConstant] public const string ParentParentId = "ParentParentId";
            [InlineConstant] public const string ParentNote = "ParentNote";
            [InlineConstant] public const string ParentProjectId = "ParentProjectId";
            [InlineConstant] public const string ParentOrganogramId = "ParentOrganogramId";
            [InlineConstant] public const string ParentScopeId = "ParentScopeId";
            [InlineConstant] public const string ParentCompanyId = "ParentCompanyId";
            [InlineConstant] public const string ParentStatusId = "ParentStatusId";
            [InlineConstant] public const string ParentActiveOn = "ParentActiveOn";
            [InlineConstant] public const string ParentInactiveOn = "ParentInactiveOn";
            [InlineConstant] public const string ParentIsActive = "ParentIsActive";
            [InlineConstant] public const string ParentDbId = "ParentDbId";
            [InlineConstant] public const string ParentCreatedBy = "ParentCreatedBy";
            [InlineConstant] public const string ParentCreatedOn = "ParentCreatedOn";
            [InlineConstant] public const string ParentCreatedPc = "ParentCreatedPc";
            [InlineConstant] public const string ParentUpdatedBy = "ParentUpdatedBy";
            [InlineConstant] public const string ParentUpdatedOn = "ParentUpdatedOn";
            [InlineConstant] public const string ParentUpdatedPc = "ParentUpdatedPc";
            [InlineConstant] public const string ParentDeletedBy = "ParentDeletedBy";
            [InlineConstant] public const string ParentDeletedOn = "ParentDeletedOn";
            [InlineConstant] public const string ParentDeletedPc = "ParentDeletedPc";
            [InlineConstant] public const string ParentIsDelete = "ParentIsDelete";
        }
    }
}