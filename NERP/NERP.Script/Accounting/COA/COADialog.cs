
namespace NERP.Accounting
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(COARow.IdProperty), NameProperty(COARow.NameProperty), IsActiveProperty(COARow.IsActiveProperty)]
    [FormKey("Accounting.COA"), LocalTextPrefix(COARow.LocalTextPrefix), Service(COAService.BaseUrl)]
    public class COADialog : EntityDialog<COARow>
    {
        protected COAForm form;

        public COADialog()
        {
            form = new COAForm(this.IdPrefix);
        }
    }
}