
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(CurrencyRow.IdProperty), NameProperty(CurrencyRow.NameProperty), IsActiveProperty(CurrencyRow.IsActiveProperty)]
    [FormKey("Configuration.Currency"), LocalTextPrefix(CurrencyRow.LocalTextPrefix), Service(CurrencyService.BaseUrl)]
    public class CurrencyDialog : EntityDialog<CurrencyRow>
    {
        protected CurrencyForm form;

        public CurrencyDialog()
        {
            form = new CurrencyForm(this.IdPrefix);
        }
    }
}