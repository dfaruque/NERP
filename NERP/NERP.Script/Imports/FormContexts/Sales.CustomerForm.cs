
namespace NERP.Sales
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class CustomerForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Sales.Customer";

        public CustomerForm(string idPrefix) : base(idPrefix) {}


        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public IntegerEditor UserTypeId { get { return ById<IntegerEditor>("UserTypeId"); } }
        public IntegerEditor UserGroupId { get { return ById<IntegerEditor>("UserGroupId"); } }
        public StringEditor FirstName { get { return ById<StringEditor>("FirstName"); } }
        public StringEditor MiddleName { get { return ById<StringEditor>("MiddleName"); } }
        public StringEditor LastName { get { return ById<StringEditor>("LastName"); } }
        public StringEditor FullName { get { return ById<StringEditor>("FullName"); } }
        public IntegerEditor ImageId { get { return ById<IntegerEditor>("ImageId"); } }
        public StringEditor Address1 { get { return ById<StringEditor>("Address1"); } }
        public StringEditor Address2 { get { return ById<StringEditor>("Address2"); } }
        public StringEditor Mobile { get { return ById<StringEditor>("Mobile"); } }
        public StringEditor Email { get { return ById<StringEditor>("Email"); } }
        public DateEditor DateOfBirth { get { return ById<DateEditor>("DateOfBirth"); } }
        public StringEditor LoginName { get { return ById<StringEditor>("LoginName"); } }
        public StringEditor Password { get { return ById<StringEditor>("Password"); } }
        public IntegerEditor IsTaxable { get { return ById<IntegerEditor>("IsTaxable"); } }
        public DecimalEditor CommissionRate { get { return ById<DecimalEditor>("CommissionRate"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
        public IntegerEditor ProjectId { get { return ById<IntegerEditor>("ProjectId"); } }
        public IntegerEditor OrganogramId { get { return ById<IntegerEditor>("OrganogramId"); } }
        public IntegerEditor ScopeId { get { return ById<IntegerEditor>("ScopeId"); } }
        public IntegerEditor CompanyId { get { return ById<IntegerEditor>("CompanyId"); } }
        public IntegerEditor StatusId { get { return ById<IntegerEditor>("StatusId"); } }
        public DateEditor ActiveOn { get { return ById<DateEditor>("ActiveOn"); } }
        public DateEditor InactiveOn { get { return ById<DateEditor>("InactiveOn"); } }
        public IntegerEditor IsActive { get { return ById<IntegerEditor>("IsActive"); } }
        public IntegerEditor DbId { get { return ById<IntegerEditor>("DbId"); } }
        public IntegerEditor CreatedBy { get { return ById<IntegerEditor>("CreatedBy"); } }
        public DateEditor CreatedOn { get { return ById<DateEditor>("CreatedOn"); } }
        public StringEditor CreatedPc { get { return ById<StringEditor>("CreatedPc"); } }
        public IntegerEditor UpdatedBy { get { return ById<IntegerEditor>("UpdatedBy"); } }
        public DateEditor UpdatedOn { get { return ById<DateEditor>("UpdatedOn"); } }
        public StringEditor UpdatedPc { get { return ById<StringEditor>("UpdatedPc"); } }
        public IntegerEditor DeletedBy { get { return ById<IntegerEditor>("DeletedBy"); } }
        public DateEditor DeletedOn { get { return ById<DateEditor>("DeletedOn"); } }
        public StringEditor DeletedPc { get { return ById<StringEditor>("DeletedPc"); } }
        public IntegerEditor IsDelete { get { return ById<IntegerEditor>("IsDelete"); } }
    }
}