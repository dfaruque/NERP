
namespace NERP.Sales
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Sales.Customer"), IdProperty(CustomerRow.IdProperty), NameProperty(CustomerRow.NameProperty), IsActiveProperty(CustomerRow.IsActiveProperty)]
    [DialogType(typeof(CustomerDialog)), LocalTextPrefix(CustomerRow.LocalTextPrefix), Service(CustomerService.BaseUrl)]
    public class CustomerGrid : EntityGrid<CustomerRow>
    {
        public CustomerGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}