
namespace NERP.Sales
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(CustomerRow.IdProperty), NameProperty(CustomerRow.NameProperty), IsActiveProperty(CustomerRow.IsActiveProperty)]
    [FormKey("Sales.Customer"), LocalTextPrefix(CustomerRow.LocalTextPrefix), Service(CustomerService.BaseUrl)]
    public class CustomerDialog : EntityDialog<CustomerRow>
    {
        protected CustomerForm form;

        public CustomerDialog()
        {
            form = new CustomerForm(this.IdPrefix);
        }
    }
}