
namespace NERP.HR
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class EmployeeForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "HR.Employee";
    
        public EmployeeForm(string idPrefix) : base(idPrefix) {}
    
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
    }
}

