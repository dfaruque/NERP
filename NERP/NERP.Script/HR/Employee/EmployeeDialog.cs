
namespace NERP.HR
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(EmployeeRow.IdProperty), NameProperty(EmployeeRow.NameProperty), IsActiveProperty(EmployeeRow.IsActiveProperty)]
    [FormKey("HR.Employee"), LocalTextPrefix(EmployeeRow.LocalTextPrefix), Service(EmployeeService.BaseUrl)]
    public class EmployeeDialog : EntityDialog<EmployeeRow>
    {
        protected EmployeeForm form;

        public EmployeeDialog()
        {
            form = new EmployeeForm(this.IdPrefix);
        }
    }
}