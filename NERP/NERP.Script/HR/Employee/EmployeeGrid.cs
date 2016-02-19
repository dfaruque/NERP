
namespace NERP.HR
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("HR.Employee"), IdProperty(EmployeeRow.IdProperty), NameProperty(EmployeeRow.NameProperty), IsActiveProperty(EmployeeRow.IsActiveProperty)]
    [DialogType(typeof(EmployeeDialog)), LocalTextPrefix(EmployeeRow.LocalTextPrefix), Service(EmployeeService.BaseUrl)]
    public class EmployeeGrid : EntityGrid<EmployeeRow>
    {
        public EmployeeGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}