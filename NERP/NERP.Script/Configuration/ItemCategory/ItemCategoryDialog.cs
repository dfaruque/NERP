
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(ItemCategoryRow.IdProperty), NameProperty(ItemCategoryRow.NameProperty), IsActiveProperty(ItemCategoryRow.IsActiveProperty)]
    [FormKey("Configuration.ItemCategory"), LocalTextPrefix(ItemCategoryRow.LocalTextPrefix), Service(ItemCategoryService.BaseUrl)]
    public class ItemCategoryDialog : EntityDialog<ItemCategoryRow>
    {
        protected ItemCategoryForm form;

        public ItemCategoryDialog()
        {
            form = new ItemCategoryForm(this.IdPrefix);
        }
        protected override void OnDialogOpen()
        {
            base.OnDialogOpen();

            var prior = J(".ui-dialog").Eq(-2);
            if (prior.Length > 0)
                if (prior.HasClass(this.GetCssClass()))
                    SubDialogHelper.Cascade(this, prior);
        }
    }
}