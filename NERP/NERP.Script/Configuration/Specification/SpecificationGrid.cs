
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Specification"), IdProperty(SpecificationRow.IdProperty), NameProperty(SpecificationRow.NameProperty), IsActiveProperty(SpecificationRow.IsActiveProperty)]
    [DialogType(typeof(SpecificationDialog)), LocalTextPrefix(SpecificationRow.LocalTextPrefix), Service(SpecificationService.BaseUrl)]
    public class SpecificationGrid : EntityGrid<SpecificationRow>
    {
        public SpecificationGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}