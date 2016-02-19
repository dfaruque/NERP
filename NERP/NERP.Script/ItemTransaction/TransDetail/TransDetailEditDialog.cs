
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using NERP.Common;
    using Serenity;
    using System.Collections.Generic;

    [NameProperty("ItemName"),FormKey("ItemTransaction.TransDetail"), LocalTextPrefix("ItemTransaction.TransDetail")]
    public class TransDetailEditDialog : GridEditorDialog<TransDetailRow>
    {
        protected TransDetailForm form;

        public TransDetailEditDialog()
        {
            form = new TransDetailForm(this.IdPrefix);

            form.Quantity.Change(e =>
            {
                form.Amount.Value = form.Quantity.Value * form.UnitPrice.Value;
            });

        }

    }
}