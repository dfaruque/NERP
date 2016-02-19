
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
    public partial class SpecificationRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string NameProperty = "Name";
        [InlineConstant] public const string LocalTextPrefix = "Configuration.Specification";
        [InlineConstant] public const string LookupKey = "Configuration.Specification";
    
        public static Lookup<SpecificationRow> Lookup { [InlineCode("Q.getLookup('Configuration.Specification')")] get { return null; } }
    
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

