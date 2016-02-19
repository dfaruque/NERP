
namespace NERP.Accounting
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class COAForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Accounting.COA";
    
        public COAForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public IntegerEditor ParentId { get { return ById<IntegerEditor>("ParentId"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

