
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.GenericItem"), IdProperty(GenericItemRow.IdProperty), NameProperty(GenericItemRow.NameProperty), IsActiveProperty(GenericItemRow.IsActiveProperty)]
    [DialogType(typeof(GenericItemDialog)), LocalTextPrefix(GenericItemRow.LocalTextPrefix), Service(GenericItemService.BaseUrl)]
    public class GenericItemGrid : EntityGrid<GenericItemRow>
    {
        public GenericItemGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}