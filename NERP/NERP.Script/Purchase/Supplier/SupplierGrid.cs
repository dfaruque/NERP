
namespace NERP.Purchase
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("Purchase.Supplier"), IdProperty(SupplierRow.IdProperty), NameProperty(SupplierRow.NameProperty), IsActiveProperty(SupplierRow.IsActiveProperty)]
    [DialogType(typeof(SupplierDialog)), LocalTextPrefix(SupplierRow.LocalTextPrefix), Service(SupplierService.BaseUrl)]

    public class SupplierGrid : EntityGrid<SupplierRow>
    {
        public SupplierGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}