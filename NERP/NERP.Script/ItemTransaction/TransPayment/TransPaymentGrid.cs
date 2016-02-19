
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("ItemTransaction.TransPayment"), IdProperty(TransPaymentRow.IdProperty), NameProperty(TransPaymentRow.NameProperty), IsActiveProperty(TransPaymentRow.IsActiveProperty)]
    [DialogType(typeof(TransPaymentDialog)), LocalTextPrefix(TransPaymentRow.LocalTextPrefix), Service(TransPaymentService.BaseUrl)]
    public class TransPaymentGrid : EntityGrid<TransPaymentRow>
    {
        public TransPaymentGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}