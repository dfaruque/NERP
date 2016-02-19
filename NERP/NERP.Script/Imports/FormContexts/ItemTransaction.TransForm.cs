
namespace NERP.ItemTransaction
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class TransForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "ItemTransaction.Trans";
    
        public TransForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public DateEditor DateTime { get { return ById<DateEditor>("DateTime"); } }
        public IntegerEditor TransTypeId { get { return ById<IntegerEditor>("TransTypeId"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
        public TransDetailEditor TransDetailRows { get { return ById<TransDetailEditor>("TransDetailRows"); } }
    }
}

