
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(ModelRow.IdProperty), NameProperty(ModelRow.NameProperty), IsActiveProperty(ModelRow.IsActiveProperty)]
    [FormKey("Configuration.Model"), LocalTextPrefix(ModelRow.LocalTextPrefix), Service(ModelService.BaseUrl)]
    public class ModelDialog : EntityDialog<ModelRow>
    {
        protected ModelForm form;

        public ModelDialog()
        {
            form = new ModelForm(this.IdPrefix);
        }
    }
}