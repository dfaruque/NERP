
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Size"), IdProperty(SizeRow.IdProperty), NameProperty(SizeRow.NameProperty), IsActiveProperty(SizeRow.IsActiveProperty)]
    [DialogType(typeof(SizeDialog)), LocalTextPrefix(SizeRow.LocalTextPrefix), Service(SizeService.BaseUrl)]
    public class SizeGrid : EntityGrid<SizeRow>
    {
        public SizeGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}