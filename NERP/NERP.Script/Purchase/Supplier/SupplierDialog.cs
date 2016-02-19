
namespace NERP.Purchase
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(SupplierRow.IdProperty), NameProperty(SupplierRow.NameProperty), IsActiveProperty(SupplierRow.IsActiveProperty)]
    [FormKey("Purchase.Supplier"), LocalTextPrefix(SupplierRow.LocalTextPrefix), Service(SupplierService.BaseUrl)]
    public class SupplierDialog : EntityDialog<SupplierRow>
    {
        protected SupplierForm form;

        public SupplierDialog()
        {
            form = new SupplierForm(this.IdPrefix);
        }
    }
}