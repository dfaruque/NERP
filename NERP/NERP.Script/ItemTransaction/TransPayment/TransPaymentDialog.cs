
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(TransPaymentRow.IdProperty), NameProperty(TransPaymentRow.NameProperty), IsActiveProperty(TransPaymentRow.IsActiveProperty)]
    [FormKey("ItemTransaction.TransPayment"), LocalTextPrefix(TransPaymentRow.LocalTextPrefix), Service(TransPaymentService.BaseUrl)]
    public class TransPaymentDialog : EntityDialog<TransPaymentRow>
    {
        protected TransPaymentForm form;

        public TransPaymentDialog()
        {
            form = new TransPaymentForm(this.IdPrefix);
        }
    }
}