
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
    public partial class GenericItemRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string NameProperty = "Code";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string LocalTextPrefix = "Configuration.GenericItem";

        public Int32? Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Int32? ItemCategoryId { get; set; }
        public Int32? ItemTypeId { get; set; }
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
        public String ItemCategoryCode { get; set; }
        public String ItemCategoryName { get; set; }
        public String ItemCategoryDescription { get; set; }
        public Int32? ItemCategoryParentId { get; set; }
        public String ItemCategoryNote { get; set; }
        public Int32? ItemCategoryProjectId { get; set; }
        public Int32? ItemCategoryOrganogramId { get; set; }
        public Int32? ItemCategoryScopeId { get; set; }
        public Int32? ItemCategoryCompanyId { get; set; }
        public Int32? ItemCategoryStatusId { get; set; }
        public String ItemCategoryActiveOn { get; set; }
        public String ItemCategoryInactiveOn { get; set; }
        public Int16? ItemCategoryIsActive { get; set; }
        public Int32? ItemCategoryDbId { get; set; }
        public Int32? ItemCategoryCreatedBy { get; set; }
        public String ItemCategoryCreatedOn { get; set; }
        public String ItemCategoryCreatedPc { get; set; }
        public Int32? ItemCategoryUpdatedBy { get; set; }
        public String ItemCategoryUpdatedOn { get; set; }
        public String ItemCategoryUpdatedPc { get; set; }
        public Int32? ItemCategoryDeletedBy { get; set; }
        public String ItemCategoryDeletedOn { get; set; }
        public String ItemCategoryDeletedPc { get; set; }
        public Int16? ItemCategoryIsDelete { get; set; }
        public String ItemTypeCode { get; set; }
        public String ItemTypeName { get; set; }
        public String ItemTypeDescription { get; set; }
        public String ItemTypeNote { get; set; }
        public Int32? ItemTypeProjectId { get; set; }
        public Int32? ItemTypeOrganogramId { get; set; }
        public Int32? ItemTypeScopeId { get; set; }
        public Int32? ItemTypeCompanyId { get; set; }
        public Int32? ItemTypeStatusId { get; set; }
        public Int16? ItemTypeIsActive { get; set; }
        public String ItemTypeActiveOn { get; set; }
        public String ItemTypeInactiveOn { get; set; }
        public Int32? ItemTypeDbId { get; set; }
        public Int32? ItemTypeCreatedBy { get; set; }
        public String ItemTypeCreatedOn { get; set; }
        public String ItemTypeCreatedPc { get; set; }
        public Int32? ItemTypeUpdatedBy { get; set; }
        public String ItemTypeUpdatedOn { get; set; }
        public String ItemTypeUpdatedPc { get; set; }
        public Int32? ItemTypeDeletedBy { get; set; }
        public String ItemTypeDeletedOn { get; set; }
        public String ItemTypeDeletedPc { get; set; }
        public Int16? ItemTypeIsDelete { get; set; }

        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Code = "Code";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string ItemCategoryId = "ItemCategoryId";
            [InlineConstant] public const string ItemTypeId = "ItemTypeId";
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
            [InlineConstant] public const string ItemCategoryCode = "ItemCategoryCode";
            [InlineConstant] public const string ItemCategoryName = "ItemCategoryName";
            [InlineConstant] public const string ItemCategoryDescription = "ItemCategoryDescription";
            [InlineConstant] public const string ItemCategoryParentId = "ItemCategoryParentId";
            [InlineConstant] public const string ItemCategoryNote = "ItemCategoryNote";
            [InlineConstant] public const string ItemCategoryProjectId = "ItemCategoryProjectId";
            [InlineConstant] public const string ItemCategoryOrganogramId = "ItemCategoryOrganogramId";
            [InlineConstant] public const string ItemCategoryScopeId = "ItemCategoryScopeId";
            [InlineConstant] public const string ItemCategoryCompanyId = "ItemCategoryCompanyId";
            [InlineConstant] public const string ItemCategoryStatusId = "ItemCategoryStatusId";
            [InlineConstant] public const string ItemCategoryActiveOn = "ItemCategoryActiveOn";
            [InlineConstant] public const string ItemCategoryInactiveOn = "ItemCategoryInactiveOn";
            [InlineConstant] public const string ItemCategoryIsActive = "ItemCategoryIsActive";
            [InlineConstant] public const string ItemCategoryDbId = "ItemCategoryDbId";
            [InlineConstant] public const string ItemCategoryCreatedBy = "ItemCategoryCreatedBy";
            [InlineConstant] public const string ItemCategoryCreatedOn = "ItemCategoryCreatedOn";
            [InlineConstant] public const string ItemCategoryCreatedPc = "ItemCategoryCreatedPc";
            [InlineConstant] public const string ItemCategoryUpdatedBy = "ItemCategoryUpdatedBy";
            [InlineConstant] public const string ItemCategoryUpdatedOn = "ItemCategoryUpdatedOn";
            [InlineConstant] public const string ItemCategoryUpdatedPc = "ItemCategoryUpdatedPc";
            [InlineConstant] public const string ItemCategoryDeletedBy = "ItemCategoryDeletedBy";
            [InlineConstant] public const string ItemCategoryDeletedOn = "ItemCategoryDeletedOn";
            [InlineConstant] public const string ItemCategoryDeletedPc = "ItemCategoryDeletedPc";
            [InlineConstant] public const string ItemCategoryIsDelete = "ItemCategoryIsDelete";
            [InlineConstant] public const string ItemTypeCode = "ItemTypeCode";
            [InlineConstant] public const string ItemTypeName = "ItemTypeName";
            [InlineConstant] public const string ItemTypeDescription = "ItemTypeDescription";
            [InlineConstant] public const string ItemTypeNote = "ItemTypeNote";
            [InlineConstant] public const string ItemTypeProjectId = "ItemTypeProjectId";
            [InlineConstant] public const string ItemTypeOrganogramId = "ItemTypeOrganogramId";
            [InlineConstant] public const string ItemTypeScopeId = "ItemTypeScopeId";
            [InlineConstant] public const string ItemTypeCompanyId = "ItemTypeCompanyId";
            [InlineConstant] public const string ItemTypeStatusId = "ItemTypeStatusId";
            [InlineConstant] public const string ItemTypeIsActive = "ItemTypeIsActive";
            [InlineConstant] public const string ItemTypeActiveOn = "ItemTypeActiveOn";
            [InlineConstant] public const string ItemTypeInactiveOn = "ItemTypeInactiveOn";
            [InlineConstant] public const string ItemTypeDbId = "ItemTypeDbId";
            [InlineConstant] public const string ItemTypeCreatedBy = "ItemTypeCreatedBy";
            [InlineConstant] public const string ItemTypeCreatedOn = "ItemTypeCreatedOn";
            [InlineConstant] public const string ItemTypeCreatedPc = "ItemTypeCreatedPc";
            [InlineConstant] public const string ItemTypeUpdatedBy = "ItemTypeUpdatedBy";
            [InlineConstant] public const string ItemTypeUpdatedOn = "ItemTypeUpdatedOn";
            [InlineConstant] public const string ItemTypeUpdatedPc = "ItemTypeUpdatedPc";
            [InlineConstant] public const string ItemTypeDeletedBy = "ItemTypeDeletedBy";
            [InlineConstant] public const string ItemTypeDeletedOn = "ItemTypeDeletedOn";
            [InlineConstant] public const string ItemTypeDeletedPc = "ItemTypeDeletedPc";
            [InlineConstant] public const string ItemTypeIsDelete = "ItemTypeIsDelete";
        }
    }
}