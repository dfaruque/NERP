
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Style"), IdProperty(StyleRow.IdProperty), NameProperty(StyleRow.NameProperty), IsActiveProperty(StyleRow.IsActiveProperty)]
    [DialogType(typeof(StyleDialog)), LocalTextPrefix(StyleRow.LocalTextPrefix), Service(StyleService.BaseUrl)]
    public class StyleGrid : EntityGrid<StyleRow>
    {
        public StyleGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}