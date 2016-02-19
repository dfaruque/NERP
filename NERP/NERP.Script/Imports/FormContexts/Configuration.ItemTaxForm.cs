
namespace NERP.Configuration
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class ItemTaxForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Configuration.ItemTax";
    
        public ItemTaxForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public IntegerEditor ItemId { get { return ById<IntegerEditor>("ItemId"); } }
        public IntegerEditor TaxId { get { return ById<IntegerEditor>("TaxId"); } }
        public DecimalEditor Rate { get { return ById<DecimalEditor>("Rate"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

