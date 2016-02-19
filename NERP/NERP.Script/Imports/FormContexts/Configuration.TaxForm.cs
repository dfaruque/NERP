
namespace NERP.Configuration
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class TaxForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Configuration.Tax";
    
        public TaxForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public DecimalEditor Rate { get { return ById<DecimalEditor>("Rate"); } }
        public BooleanEditor IsDefault { get { return ById<BooleanEditor>("IsDefault"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

