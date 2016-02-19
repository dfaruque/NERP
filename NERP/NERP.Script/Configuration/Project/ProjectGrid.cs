
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Project"), IdProperty(ProjectRow.IdProperty), NameProperty(ProjectRow.NameProperty), IsActiveProperty(ProjectRow.IsActiveProperty)]
    [DialogType(typeof(ProjectDialog)), LocalTextPrefix(ProjectRow.LocalTextPrefix), Service(ProjectService.BaseUrl)]
    public class ProjectGrid : EntityGrid<ProjectRow>
    {
        public ProjectGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}