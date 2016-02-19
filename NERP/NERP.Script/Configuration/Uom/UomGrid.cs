
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Uom"), IdProperty(UomRow.IdProperty), NameProperty(UomRow.NameProperty), IsActiveProperty(UomRow.IsActiveProperty)]
    [DialogType(typeof(UomDialog)), LocalTextPrefix(UomRow.LocalTextPrefix), Service(UomService.BaseUrl)]
    public class UomGrid : EntityGrid<UomRow>
    {
        public UomGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}