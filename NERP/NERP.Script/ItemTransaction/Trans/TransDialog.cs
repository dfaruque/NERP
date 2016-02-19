
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(TransRow.IdProperty), NameProperty(TransRow.NameProperty), IsActiveProperty(TransRow.IsActiveProperty)]
    [FormKey("ItemTransaction.Trans"), LocalTextPrefix(TransRow.LocalTextPrefix), Service(TransService.BaseUrl)]
    [Flexify, Maximizable]
    public class TransDialog : EntityDialog<TransRow>
    {
        protected TransForm form;

        public TransDialog()
        {
            form = new TransForm(this.IdPrefix);
        }
    }
}