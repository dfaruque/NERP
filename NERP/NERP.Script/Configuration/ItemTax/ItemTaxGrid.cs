
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.ItemTax"), IdProperty(ItemTaxRow.IdProperty), NameProperty(ItemTaxRow.NameProperty), IsActiveProperty(ItemTaxRow.IsActiveProperty)]
    [DialogType(typeof(ItemTaxDialog)), LocalTextPrefix(ItemTaxRow.LocalTextPrefix), Service(ItemTaxService.BaseUrl)]
    public class ItemTaxGrid : EntityGrid<ItemTaxRow>
    {
        public ItemTaxGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}