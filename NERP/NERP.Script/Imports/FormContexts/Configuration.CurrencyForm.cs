
namespace NERP.Configuration
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class CurrencyForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Configuration.Currency";

        public CurrencyForm(string idPrefix) : base(idPrefix) {}


        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public StringEditor Symbol { get { return ById<StringEditor>("Symbol"); } }
        public IntegerEditor DecimalPlaces { get { return ById<IntegerEditor>("DecimalPlaces"); } }
        public StringEditor DecimalSeparator { get { return ById<StringEditor>("DecimalSeparator"); } }
        public BooleanEditor IsThousandBase { get { return ById<BooleanEditor>("IsThousandBase"); } }
        public StringEditor ThousandSeparator { get { return ById<StringEditor>("ThousandSeparator"); } }
        public DecimalEditor RateToDollar { get { return ById<DecimalEditor>("RateToDollar"); } }
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