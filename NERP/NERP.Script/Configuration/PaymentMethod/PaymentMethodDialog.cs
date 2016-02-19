
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(PaymentMethodRow.IdProperty), NameProperty(PaymentMethodRow.NameProperty), IsActiveProperty(PaymentMethodRow.IsActiveProperty)]
    [FormKey("Configuration.PaymentMethod"), LocalTextPrefix(PaymentMethodRow.LocalTextPrefix), Service(PaymentMethodService.BaseUrl)]
    public class PaymentMethodDialog : EntityDialog<PaymentMethodRow>
    {
        protected PaymentMethodForm form;

        public PaymentMethodDialog()
        {
            form = new PaymentMethodForm(this.IdPrefix);
        }
    }
}