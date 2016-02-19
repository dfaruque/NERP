
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(TransTaxRow.IdProperty), NameProperty(TransTaxRow.NameProperty), IsActiveProperty(TransTaxRow.IsActiveProperty)]
    [FormKey("ItemTransaction.TransTax"), LocalTextPrefix(TransTaxRow.LocalTextPrefix), Service(TransTaxService.BaseUrl)]
    public class TransTaxDialog : EntityDialog<TransTaxRow>
    {
        protected TransTaxForm form;

        public TransTaxDialog()
        {
            form = new TransTaxForm(this.IdPrefix);
        }
    }
}