
namespace NERP.ItemTransaction
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class TransPaymentForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "ItemTransaction.TransPayment";
    
        public TransPaymentForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public IntegerEditor TransId { get { return ById<IntegerEditor>("TransId"); } }
        public IntegerEditor PaymentMethodId { get { return ById<IntegerEditor>("PaymentMethodId"); } }
        public DecimalEditor PaymentAmt { get { return ById<DecimalEditor>("PaymentAmt"); } }
        public StringEditor PaymentMeansNo { get { return ById<StringEditor>("PaymentMeansNo"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

