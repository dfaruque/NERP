
namespace NERP.Configuration
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class OrganogramForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Configuration.Organogram";
    
        public OrganogramForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public LookupEditor ParentId { get { return ById<LookupEditor>("ParentId"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

