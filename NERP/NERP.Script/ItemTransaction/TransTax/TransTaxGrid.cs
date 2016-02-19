
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("ItemTransaction.TransTax"), IdProperty(TransTaxRow.IdProperty), NameProperty(TransTaxRow.NameProperty), IsActiveProperty(TransTaxRow.IsActiveProperty)]
    [DialogType(typeof(TransTaxDialog)), LocalTextPrefix(TransTaxRow.LocalTextPrefix), Service(TransTaxService.BaseUrl)]
    public class TransTaxGrid : EntityGrid<TransTaxRow>
    {
        public TransTaxGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}