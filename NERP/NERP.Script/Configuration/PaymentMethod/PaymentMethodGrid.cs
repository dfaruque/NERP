
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.PaymentMethod"), IdProperty(PaymentMethodRow.IdProperty), NameProperty(PaymentMethodRow.NameProperty), IsActiveProperty(PaymentMethodRow.IsActiveProperty)]
    [DialogType(typeof(PaymentMethodDialog)), LocalTextPrefix(PaymentMethodRow.LocalTextPrefix), Service(PaymentMethodService.BaseUrl)]
    public class PaymentMethodGrid : EntityGrid<PaymentMethodRow>
    {
        public PaymentMethodGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}