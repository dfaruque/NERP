
namespace NERP.Accounting
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Accounting.COA"), IdProperty(COARow.IdProperty), NameProperty(COARow.NameProperty), IsActiveProperty(COARow.IsActiveProperty)]
    [DialogType(typeof(COADialog)), LocalTextPrefix(COARow.LocalTextPrefix), Service(COAService.BaseUrl)]
    public class COAGrid : EntityGrid<COARow>
    {
        public COAGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}