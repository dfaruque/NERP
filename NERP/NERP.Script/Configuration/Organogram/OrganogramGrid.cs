
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Configuration.Organogram"), IdProperty(OrganogramRow.IdProperty), NameProperty(OrganogramRow.NameProperty), IsActiveProperty(OrganogramRow.IsActiveProperty)]
    [DialogType(typeof(OrganogramDialog)), LocalTextPrefix(OrganogramRow.LocalTextPrefix), Service(OrganogramService.BaseUrl)]
    public class OrganogramGrid : EntityGrid<OrganogramRow>
    {
        public OrganogramGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}