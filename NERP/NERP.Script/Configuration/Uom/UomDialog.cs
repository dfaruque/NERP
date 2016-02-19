
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(UomRow.IdProperty), NameProperty(UomRow.NameProperty), IsActiveProperty(UomRow.IsActiveProperty)]
    [FormKey("Configuration.Uom"), LocalTextPrefix(UomRow.LocalTextPrefix), Service(UomService.BaseUrl)]
    public class UomDialog : EntityDialog<UomRow>
    {
        protected UomForm form;

        public UomDialog()
        {
            form = new UomForm(this.IdPrefix);
        }
    }
}