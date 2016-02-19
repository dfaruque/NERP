
using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace NERP.Northwind
{
    public partial class EmployeeFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "NERP.Northwind.EmployeeFormatter";

        public EmployeeFormatterAttribute()
            : base(Key)
        {
        }

        public String GenderProperty
        {
            get { return GetOption<String>("genderProperty"); }
            set { SetOption("genderProperty", value); }
        }
    }

    public partial class FreightFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "NERP.Northwind.FreightFormatter";

        public FreightFormatterAttribute()
            : base(Key)
        {
        }
    }

    public partial class ShipperFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "NERP.Northwind.ShipperFormatter";

        public ShipperFormatterAttribute()
            : base(Key)
        {
        }
    }
}

