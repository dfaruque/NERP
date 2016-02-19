
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(SizeRow.IdProperty), NameProperty(SizeRow.NameProperty), IsActiveProperty(SizeRow.IsActiveProperty)]
    [FormKey("Configuration.Size"), LocalTextPrefix(SizeRow.LocalTextPrefix), Service(SizeService.BaseUrl)]
    public class SizeDialog : EntityDialog<SizeRow>
    {
        protected SizeForm form;

        public SizeDialog()
        {
            form = new SizeForm(this.IdPrefix);
        }
    }
}