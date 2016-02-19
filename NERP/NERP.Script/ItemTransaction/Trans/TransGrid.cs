
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("ItemTransaction.Trans"), IdProperty(TransRow.IdProperty), NameProperty(TransRow.NameProperty), IsActiveProperty(TransRow.IsActiveProperty)]
    [DialogType(typeof(TransDialog)), LocalTextPrefix(TransRow.LocalTextPrefix), Service(TransService.BaseUrl)]
    public class TransGrid : EntityGrid<TransRow>
    {
        public TransGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}