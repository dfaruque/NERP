
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(OrganogramRow.IdProperty), NameProperty(OrganogramRow.NameProperty), IsActiveProperty(OrganogramRow.IsActiveProperty)]
    [FormKey("Configuration.Organogram"), LocalTextPrefix(OrganogramRow.LocalTextPrefix), Service(OrganogramService.BaseUrl)]
    public class OrganogramDialog : EntityDialog<OrganogramRow>
    {
        protected OrganogramForm form;

        public OrganogramDialog()
        {
            form = new OrganogramForm(this.IdPrefix);
        }
    }
}