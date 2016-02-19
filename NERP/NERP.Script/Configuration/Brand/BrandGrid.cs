
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Brand"), IdProperty(BrandRow.IdProperty), NameProperty(BrandRow.NameProperty), IsActiveProperty(BrandRow.IsActiveProperty)]
    [DialogType(typeof(BrandDialog)), LocalTextPrefix(BrandRow.LocalTextPrefix), Service(BrandService.BaseUrl)]
    public class BrandGrid : EntityGrid<BrandRow>
    {
        public BrandGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}