
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(ColorRow.IdProperty), NameProperty(ColorRow.NameProperty), IsActiveProperty(ColorRow.IsActiveProperty)]
    [FormKey("Configuration.Color"), LocalTextPrefix(ColorRow.LocalTextPrefix), Service(ColorService.BaseUrl)]
    public class ColorDialog : EntityDialog<ColorRow>
    {
        protected ColorForm form;

        public ColorDialog()
        {
            form = new ColorForm(this.IdPrefix);
        }
    }
}