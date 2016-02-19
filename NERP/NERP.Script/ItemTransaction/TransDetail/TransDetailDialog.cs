
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(TransDetailRow.IdProperty), NameProperty(TransDetailRow.NameProperty), IsActiveProperty(TransDetailRow.IsActiveProperty)]
    [FormKey("ItemTransaction.TransDetail"), LocalTextPrefix(TransDetailRow.LocalTextPrefix), Service(TransDetailService.BaseUrl)]
    public class TransDetailDialog : EntityDialog<TransDetailRow>
    {
        protected TransDetailForm form;

        public TransDetailDialog()
        {
            form = new TransDetailForm(this.IdPrefix);
        }
    }
}