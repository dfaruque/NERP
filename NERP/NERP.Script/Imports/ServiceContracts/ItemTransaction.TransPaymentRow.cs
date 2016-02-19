
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
    public partial class TransPaymentRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string NameProperty = "Code";
        [InlineConstant] public const string IsActiveProperty = "IsActive";
        [InlineConstant] public const string LocalTextPrefix = "ItemTransaction.TransPayment";

        public Int32? Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Int32? TransId { get; set; }
        public Int32? PaymentMethodId { get; set; }
        public Decimal? PaymentAmt { get; set; }
        public String PaymentMeansNo { get; set; }
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
        public String TransCode { get; set; }
        public String TransName { get; set; }
        public String TransDescription { get; set; }
        public String TransDateTime { get; set; }
        public Int32? TransTransTypeId { get; set; }
        public String TransNote { get; set; }
        public Int32? TransProjectId { get; set; }
        public Int32? TransOrganogramId { get; set; }
        public Int32? TransScopeId { get; set; }
        public Int32? TransCompanyId { get; set; }
        public Int32? TransStatusId { get; set; }
        public String TransActiveOn { get; set; }
        public String TransInactiveOn { get; set; }
        public Int16? TransIsActive { get; set; }
        public Int32? TransDbId { get; set; }
        public Int32? TransCreatedBy { get; set; }
        public String TransCreatedOn { get; set; }
        public String TransCreatedPc { get; set; }
        public Int32? TransUpdatedBy { get; set; }
        public String TransUpdatedOn { get; set; }
        public String TransUpdatedPc { get; set; }
        public Int32? TransDeletedBy { get; set; }
        public String TransDeletedOn { get; set; }
        public String TransDeletedPc { get; set; }
        public Int16? TransIsDelete { get; set; }

        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Code = "Code";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string TransId = "TransId";
            [InlineConstant] public const string PaymentMethodId = "PaymentMethodId";
            [InlineConstant] public const string PaymentAmt = "PaymentAmt";
            [InlineConstant] public const string PaymentMeansNo = "PaymentMeansNo";
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
            [InlineConstant] public const string TransCode = "TransCode";
            [InlineConstant] public const string TransName = "TransName";
            [InlineConstant] public const string TransDescription = "TransDescription";
            [InlineConstant] public const string TransDateTime = "TransDateTime";
            [InlineConstant] public const string TransTransTypeId = "TransTransTypeId";
            [InlineConstant] public const string TransNote = "TransNote";
            [InlineConstant] public const string TransProjectId = "TransProjectId";
            [InlineConstant] public const string TransOrganogramId = "TransOrganogramId";
            [InlineConstant] public const string TransScopeId = "TransScopeId";
            [InlineConstant] public const string TransCompanyId = "TransCompanyId";
            [InlineConstant] public const string TransStatusId = "TransStatusId";
            [InlineConstant] public const string TransActiveOn = "TransActiveOn";
            [InlineConstant] public const string TransInactiveOn = "TransInactiveOn";
            [InlineConstant] public const string TransIsActive = "TransIsActive";
            [InlineConstant] public const string TransDbId = "TransDbId";
            [InlineConstant] public const string TransCreatedBy = "TransCreatedBy";
            [InlineConstant] public const string TransCreatedOn = "TransCreatedOn";
            [InlineConstant] public const string TransCreatedPc = "TransCreatedPc";
            [InlineConstant] public const string TransUpdatedBy = "TransUpdatedBy";
            [InlineConstant] public const string TransUpdatedOn = "TransUpdatedOn";
            [InlineConstant] public const string TransUpdatedPc = "TransUpdatedPc";
            [InlineConstant] public const string TransDeletedBy = "TransDeletedBy";
            [InlineConstant] public const string TransDeletedOn = "TransDeletedOn";
            [InlineConstant] public const string TransDeletedPc = "TransDeletedPc";
            [InlineConstant] public const string TransIsDelete = "TransIsDelete";
        }
    }
}