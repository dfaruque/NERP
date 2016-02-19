
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(ItemTaxRow.IdProperty), NameProperty(ItemTaxRow.NameProperty), IsActiveProperty(ItemTaxRow.IsActiveProperty)]
    [FormKey("Configuration.ItemTax"), LocalTextPrefix(ItemTaxRow.LocalTextPrefix), Service(ItemTaxService.BaseUrl)]
    public class ItemTaxDialog : EntityDialog<ItemTaxRow>
    {
        protected ItemTaxForm form;

        public ItemTaxDialog()
        {
            form = new ItemTaxForm(this.IdPrefix);
        }
    }
}