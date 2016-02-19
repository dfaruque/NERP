
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Item"), IdProperty(ItemRow.IdProperty), NameProperty(ItemRow.NameProperty), IsActiveProperty(ItemRow.IsActiveProperty)]
    [DialogType(typeof(ItemDialog)), LocalTextPrefix(ItemRow.LocalTextPrefix), Service(ItemService.BaseUrl)]
    public class ItemGrid : EntityGrid<ItemRow>
    {
        public ItemGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}