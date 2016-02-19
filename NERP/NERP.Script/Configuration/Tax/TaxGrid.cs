
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Tax"), IdProperty(TaxRow.IdProperty), NameProperty(TaxRow.NameProperty), IsActiveProperty(TaxRow.IsActiveProperty)]
    [DialogType(typeof(TaxDialog)), LocalTextPrefix(TaxRow.LocalTextPrefix), Service(TaxService.BaseUrl)]
    public class TaxGrid : EntityGrid<TaxRow>
    {
        public TaxGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}