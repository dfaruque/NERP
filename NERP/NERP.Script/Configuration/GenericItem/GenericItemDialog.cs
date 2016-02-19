
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(GenericItemRow.IdProperty), NameProperty(GenericItemRow.NameProperty), IsActiveProperty(GenericItemRow.IsActiveProperty)]
    [FormKey("Configuration.GenericItem"), LocalTextPrefix(GenericItemRow.LocalTextPrefix), Service(GenericItemService.BaseUrl)]
    public class GenericItemDialog : EntityDialog<GenericItemRow>
    {
        protected GenericItemForm form;

        public GenericItemDialog()
        {
            form = new GenericItemForm(this.IdPrefix);
        }
    }
}