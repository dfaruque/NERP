
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Model"), IdProperty(ModelRow.IdProperty), NameProperty(ModelRow.NameProperty), IsActiveProperty(ModelRow.IsActiveProperty)]
    [DialogType(typeof(ModelDialog)), LocalTextPrefix(ModelRow.LocalTextPrefix), Service(ModelService.BaseUrl)]
    public class ModelGrid : EntityGrid<ModelRow>
    {
        public ModelGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}