
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(SpecificationRow.IdProperty), NameProperty(SpecificationRow.NameProperty), IsActiveProperty(SpecificationRow.IsActiveProperty)]
    [FormKey("Configuration.Specification"), LocalTextPrefix(SpecificationRow.LocalTextPrefix), Service(SpecificationService.BaseUrl)]
    public class SpecificationDialog : EntityDialog<SpecificationRow>
    {
        protected SpecificationForm form;

        public SpecificationDialog()
        {
            form = new SpecificationForm(this.IdPrefix);
        }
    }
}