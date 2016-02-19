
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(StyleRow.IdProperty), NameProperty(StyleRow.NameProperty), IsActiveProperty(StyleRow.IsActiveProperty)]
    [FormKey("Configuration.Style"), LocalTextPrefix(StyleRow.LocalTextPrefix), Service(StyleService.BaseUrl)]
    public class StyleDialog : EntityDialog<StyleRow>
    {
        protected StyleForm form;

        public StyleDialog()
        {
            form = new StyleForm(this.IdPrefix);
        }
    }
}