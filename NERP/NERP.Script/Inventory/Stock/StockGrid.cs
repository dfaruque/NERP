
namespace NERP.Inventory
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Inventory.Stock"), IdProperty(StockRow.IdProperty), NameProperty(StockRow.NameProperty)]
    [DialogType(typeof(StockDialog)), LocalTextPrefix(StockRow.LocalTextPrefix), Service(StockService.BaseUrl)]
    public class StockGrid : EntityGrid<StockRow>
    {
        public StockGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}