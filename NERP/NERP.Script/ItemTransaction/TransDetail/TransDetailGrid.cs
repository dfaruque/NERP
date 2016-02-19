
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("ItemTransaction.TransDetail"), IdProperty(TransDetailRow.IdProperty), NameProperty(TransDetailRow.NameProperty), IsActiveProperty(TransDetailRow.IsActiveProperty)]
    [DialogType(typeof(TransDetailDialog)), LocalTextPrefix(TransDetailRow.LocalTextPrefix), Service(TransDetailService.BaseUrl)]
    public class TransDetailGrid : EntityGrid<TransDetailRow>
    {
        public TransDetailGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}