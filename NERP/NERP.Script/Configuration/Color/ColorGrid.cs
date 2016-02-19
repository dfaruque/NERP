
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Color"), IdProperty(ColorRow.IdProperty), NameProperty(ColorRow.NameProperty), IsActiveProperty(ColorRow.IsActiveProperty)]
    [DialogType(typeof(ColorDialog)), LocalTextPrefix(ColorRow.LocalTextPrefix), Service(ColorService.BaseUrl)]
    public class ColorGrid : EntityGrid<ColorRow>
    {
        public ColorGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}