
namespace NERP.ItemTransaction
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class TransRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string NameProperty = "Code";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string LocalTextPrefix = "ItemTransaction.Trans";

        public Int32? Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String DateTime { get; set; }
        public Int32? TransTypeId { get; set; }
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
        public String CreatedPc { get; set; }
        public Int32? UpdatedBy { get; set; }
        public String UpdatedOn { get; set; }
        public String UpdatedPc { get; set; }
        public Int32? DeletedBy { get; set; }
        public String DeletedOn { get; set; }
        public String DeletedPc { get; set; }
        public Int16? IsDelete { get; set; }
        public String ProjectCode { get; set; }
        public String ProjectName { get; set; }
        public String ProjectDescription { get; set; }
        public String ProjectNote { get; set; }
        public Int32? ProjectProjectId { get; set; }
        public Int32? ProjectOrganogramId { get; set; }
        public Int32? ProjectScopeId { get; set; }
        public Int32? ProjectCompanyId { get; set; }
        public Int32? ProjectStatusId { get; set; }
        public String ProjectActiveOn { get; set; }
        public String ProjectInactiveOn { get; set; }
        public Int16? ProjectIsActive { get; set; }
        public Int32? ProjectDbId { get; set; }
        public Int32? ProjectCreatedBy { get; set; }
        public String ProjectCreatedOn { get; set; }
        public String ProjectCreatedPc { get; set; }
        public Int32? ProjectUpdatedBy { get; set; }
        public String ProjectUpdatedOn { get; set; }
        public String ProjectUpdatedPc { get; set; }
        public Int32? ProjectDeletedBy { get; set; }
        public String ProjectDeletedOn { get; set; }
        public String ProjectDeletedPc { get; set; }
        public Int16? ProjectIsDelete { get; set; }
        public String OrganogramCode { get; set; }
        public String OrganogramName { get; set; }
        public String OrganogramDescription { get; set; }
        public Int32? OrganogramParentId { get; set; }
        public String OrganogramNote { get; set; }
        public Int32? OrganogramProjectId { get; set; }
        public Int32? OrganogramOrganogramId { get; set; }
        public Int32? OrganogramScopeId { get; set; }
        public Int32? OrganogramCompanyId { get; set; }
        public Int32? OrganogramStatusId { get; set; }
        public String OrganogramActiveOn { get; set; }
        public String OrganogramInactiveOn { get; set; }
        public Int16? OrganogramIsActive { get; set; }
        public Int32? OrganogramDbId { get; set; }
        public Int32? OrganogramCreatedBy { get; set; }
        public String OrganogramCreatedOn { get; set; }
        public String OrganogramCreatedPc { get; set; }
        public Int32? OrganogramUpdatedBy { get; set; }
        public String OrganogramUpdatedOn { get; set; }
        public String OrganogramUpdatedPc { get; set; }
        public Int32? OrganogramDeletedBy { get; set; }
        public String OrganogramDeletedOn { get; set; }
        public String OrganogramDeletedPc { get; set; }
        public Int16? OrganogramIsDelete { get; set; }

        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Code = "Code";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string DateTime = "DateTime";
            [InlineConstant] public const string TransTypeId = "TransTypeId";
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
            [InlineConstant] public const string ProjectCode = "ProjectCode";
            [InlineConstant] public const string ProjectName = "ProjectName";
            [InlineConstant] public const string ProjectDescription = "ProjectDescription";
            [InlineConstant] public const string ProjectNote = "ProjectNote";
            [InlineConstant] public const string ProjectProjectId = "ProjectProjectId";
            [InlineConstant] public const string ProjectOrganogramId = "ProjectOrganogramId";
            [InlineConstant] public const string ProjectScopeId = "ProjectScopeId";
            [InlineConstant] public const string ProjectCompanyId = "ProjectCompanyId";
            [InlineConstant] public const string ProjectStatusId = "ProjectStatusId";
            [InlineConstant] public const string ProjectActiveOn = "ProjectActiveOn";
            [InlineConstant] public const string ProjectInactiveOn = "ProjectInactiveOn";
            [InlineConstant] public const string ProjectIsActive = "ProjectIsActive";
            [InlineConstant] public const string ProjectDbId = "ProjectDbId";
            [InlineConstant] public const string ProjectCreatedBy = "ProjectCreatedBy";
            [InlineConstant] public const string ProjectCreatedOn = "ProjectCreatedOn";
            [InlineConstant] public const string ProjectCreatedPc = "ProjectCreatedPc";
            [InlineConstant] public const string ProjectUpdatedBy = "ProjectUpdatedBy";
            [InlineConstant] public const string ProjectUpdatedOn = "ProjectUpdatedOn";
            [InlineConstant] public const string ProjectUpdatedPc = "ProjectUpdatedPc";
            [InlineConstant] public const string ProjectDeletedBy = "ProjectDeletedBy";
            [InlineConstant] public const string ProjectDeletedOn = "ProjectDeletedOn";
            [InlineConstant] public const string ProjectDeletedPc = "ProjectDeletedPc";
            [InlineConstant] public const string ProjectIsDelete = "ProjectIsDelete";
            [InlineConstant] public const string OrganogramCode = "OrganogramCode";
            [InlineConstant] public const string OrganogramName = "OrganogramName";
            [InlineConstant] public const string OrganogramDescription = "OrganogramDescription";
            [InlineConstant] public const string OrganogramParentId = "OrganogramParentId";
            [InlineConstant] public const string OrganogramNote = "OrganogramNote";
            [InlineConstant] public const string OrganogramProjectId = "OrganogramProjectId";
            [InlineConstant] public const string OrganogramOrganogramId = "OrganogramOrganogramId";
            [InlineConstant] public const string OrganogramScopeId = "OrganogramScopeId";
            [InlineConstant] public const string OrganogramCompanyId = "OrganogramCompanyId";
            [InlineConstant] public const string OrganogramStatusId = "OrganogramStatusId";
            [InlineConstant] public const string OrganogramActiveOn = "OrganogramActiveOn";
            [InlineConstant] public const string OrganogramInactiveOn = "OrganogramInactiveOn";
            [InlineConstant] public const string OrganogramIsActive = "OrganogramIsActive";
            [InlineConstant] public const string OrganogramDbId = "OrganogramDbId";
            [InlineConstant] public const string OrganogramCreatedBy = "OrganogramCreatedBy";
            [InlineConstant] public const string OrganogramCreatedOn = "OrganogramCreatedOn";
            [InlineConstant] public const string OrganogramCreatedPc = "OrganogramCreatedPc";
            [InlineConstant] public const string OrganogramUpdatedBy = "OrganogramUpdatedBy";
            [InlineConstant] public const string OrganogramUpdatedOn = "OrganogramUpdatedOn";
            [InlineConstant] public const string OrganogramUpdatedPc = "OrganogramUpdatedPc";
            [InlineConstant] public const string OrganogramDeletedBy = "OrganogramDeletedBy";
            [InlineConstant] public const string OrganogramDeletedOn = "OrganogramDeletedOn";
            [InlineConstant] public const string OrganogramDeletedPc = "OrganogramDeletedPc";
            [InlineConstant] public const string OrganogramIsDelete = "OrganogramIsDelete";
        }
    }
}