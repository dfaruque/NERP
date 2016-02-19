
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(ItemRow.IdProperty), NameProperty(ItemRow.NameProperty), IsActiveProperty(ItemRow.IsActiveProperty)]
    [FormKey("Configuration.Item"), LocalTextPrefix(ItemRow.LocalTextPrefix), Service(ItemService.BaseUrl)]
    [Flexify, Maximizable]
    public class ItemDialog : EntityDialog<ItemRow>
    {
        protected ItemForm form;

        public ItemDialog()
        {
            form = new ItemForm(this.IdPrefix);
        }
    }
}