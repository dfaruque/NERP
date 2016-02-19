
namespace NERP.ItemTransaction
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class TransTaxForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "ItemTransaction.TransTax";
    
        public TransTaxForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public IntegerEditor TransId { get { return ById<IntegerEditor>("TransId"); } }
        public IntegerEditor TransDetailId { get { return ById<IntegerEditor>("TransDetailId"); } }
        public IntegerEditor TaxId { get { return ById<IntegerEditor>("TaxId"); } }
        public DecimalEditor Rate { get { return ById<DecimalEditor>("Rate"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

