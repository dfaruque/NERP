
namespace NERP.ItemTransaction
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class TransDetailForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "ItemTransaction.TransDetail";
    
        public TransDetailForm(string idPrefix) : base(idPrefix) {}
    
        public LookupEditor ItemId { get { return ById<LookupEditor>("ItemId"); } }
        public StringEditor ItemName { get { return ById<StringEditor>("ItemName"); } }
        public LookupEditor UomId { get { return ById<LookupEditor>("UomId"); } }
        public DecimalEditor Quantity { get { return ById<DecimalEditor>("Quantity"); } }
        public DecimalEditor UnitPrice { get { return ById<DecimalEditor>("UnitPrice"); } }
        public DecimalEditor Amount { get { return ById<DecimalEditor>("Amount"); } }
        public DecimalEditor TaxAmt { get { return ById<DecimalEditor>("TaxAmt"); } }
        public DecimalEditor DiscountAmt { get { return ById<DecimalEditor>("DiscountAmt"); } }
        public DecimalEditor LineTotalAmt { get { return ById<DecimalEditor>("LineTotalAmt"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

