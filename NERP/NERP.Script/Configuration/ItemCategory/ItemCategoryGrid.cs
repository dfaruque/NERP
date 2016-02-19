
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.ItemCategory"), IdProperty(ItemCategoryRow.IdProperty), NameProperty(ItemCategoryRow.NameProperty), IsActiveProperty(ItemCategoryRow.IsActiveProperty)]
    [DialogType(typeof(ItemCategoryDialog)), LocalTextPrefix(ItemCategoryRow.LocalTextPrefix), Service(ItemCategoryService.BaseUrl)]
    public class ItemCategoryGrid : EntityGrid<ItemCategoryRow>
    {
        public ItemCategoryGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}