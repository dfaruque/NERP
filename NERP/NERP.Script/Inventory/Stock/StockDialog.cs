
namespace NERP.Inventory
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(StockRow.IdProperty), NameProperty(StockRow.NameProperty), IsActiveProperty(StockRow.IsActiveProperty)]
    [FormKey("Inventory.Stock"), LocalTextPrefix(StockRow.LocalTextPrefix), Service(StockService.BaseUrl)]
    public class StockDialog : EntityDialog<StockRow>
    {
        protected StockForm form;

        public StockDialog()
        {
            form = new StockForm(this.IdPrefix);
        }
    }
}