
namespace NERP.Configuration
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class GenericItemForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Configuration.GenericItem";
    
        public GenericItemForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public LookupEditor ItemCategoryId { get { return ById<LookupEditor>("ItemCategoryId"); } }
        public IntegerEditor ItemTypeId { get { return ById<IntegerEditor>("ItemTypeId"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

