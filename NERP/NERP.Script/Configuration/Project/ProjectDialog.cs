
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(ProjectRow.IdProperty), NameProperty(ProjectRow.NameProperty), IsActiveProperty(ProjectRow.IsActiveProperty)]
    [FormKey("Configuration.Project"), LocalTextPrefix(ProjectRow.LocalTextPrefix), Service(ProjectService.BaseUrl)]
    public class ProjectDialog : EntityDialog<ProjectRow>
    {
        protected ProjectForm form;

        public ProjectDialog()
        {
            form = new ProjectForm(this.IdPrefix);
        }
    }
}