
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
    }
}

