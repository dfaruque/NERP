
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using NERP.Common;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(TransDetailRow.IdProperty), NameProperty(TransDetailRow.NameProperty), IsActiveProperty(TransDetailRow.IsActiveProperty)]
    [FormKey("ItemTransaction.TransDetail"), LocalTextPrefix(TransDetailRow.LocalTextPrefix)]
    //[Service(TransDetailService.BaseUrl)]
    public class TransDetailEditDialog : GridEditorDialog<TransDetailRow>
    {
        protected TransDetailForm form;

        public TransDetailEditDialog()
        {
            form = new TransDetailForm(this.IdPrefix);
        }

    }
}