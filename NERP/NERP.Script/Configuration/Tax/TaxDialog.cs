
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(TaxRow.IdProperty), NameProperty(TaxRow.NameProperty), IsActiveProperty(TaxRow.IsActiveProperty)]
    [FormKey("Configuration.Tax"), LocalTextPrefix(TaxRow.LocalTextPrefix), Service(TaxService.BaseUrl)]
    public class TaxDialog : EntityDialog<TaxRow>
    {
        protected TaxForm form;

        public TaxDialog()
        {
            form = new TaxForm(this.IdPrefix);
        }
    }
}