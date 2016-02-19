
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(BrandRow.IdProperty), NameProperty(BrandRow.NameProperty), IsActiveProperty(BrandRow.IsActiveProperty)]
    [FormKey("Configuration.Brand"), LocalTextPrefix(BrandRow.LocalTextPrefix), Service(BrandService.BaseUrl)]
    public class BrandDialog : EntityDialog<BrandRow>
    {
        protected BrandForm form;

        public BrandDialog()
        {
            form = new BrandForm(this.IdPrefix);
        }
    }
}