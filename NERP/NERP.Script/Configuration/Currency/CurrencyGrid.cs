
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Currency"), IdProperty(CurrencyRow.IdProperty), NameProperty(CurrencyRow.NameProperty), IsActiveProperty(CurrencyRow.IsActiveProperty)]
    [DialogType(typeof(CurrencyDialog)), LocalTextPrefix(CurrencyRow.LocalTextPrefix), Service(CurrencyService.BaseUrl)]
    public class CurrencyGrid : EntityGrid<CurrencyRow>
    {
        public CurrencyGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}