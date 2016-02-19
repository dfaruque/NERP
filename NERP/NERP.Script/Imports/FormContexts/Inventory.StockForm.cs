
namespace NERP.Inventory
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class StockForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "Inventory.Stock";
    
        public StockForm(string idPrefix) : base(idPrefix) {}
    
        public StringEditor Code { get { return ById<StringEditor>("Code"); } }
        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public StringEditor ItemId { get { return ById<StringEditor>("ItemId"); } }
        public StringEditor ItemDetailId { get { return ById<StringEditor>("ItemDetailId"); } }
        public StringEditor UomId { get { return ById<StringEditor>("UomId"); } }
        public DecimalEditor OpeningStock { get { return ById<DecimalEditor>("OpeningStock"); } }
        public DecimalEditor OpeningStockVal { get { return ById<DecimalEditor>("OpeningStockVal"); } }
        public DecimalEditor ReceivedQty { get { return ById<DecimalEditor>("ReceivedQty"); } }
        public DecimalEditor ReceivedVal { get { return ById<DecimalEditor>("ReceivedVal"); } }
        public DecimalEditor DeliveredQty { get { return ById<DecimalEditor>("DeliveredQty"); } }
        public DecimalEditor DeliveredVal { get { return ById<DecimalEditor>("DeliveredVal"); } }
        public DecimalEditor CurrentStock { get { return ById<DecimalEditor>("CurrentStock"); } }
        public DecimalEditor CurrentStockVal { get { return ById<DecimalEditor>("CurrentStockVal"); } }
        public DateEditor OpeningStockDate { get { return ById<DateEditor>("OpeningStockDate"); } }
        public DateEditor LastReceivedDate { get { return ById<DateEditor>("LastReceivedDate"); } }
        public DateEditor LastDeliveredDate { get { return ById<DateEditor>("LastDeliveredDate"); } }
        public StringEditor Note { get { return ById<StringEditor>("Note"); } }
    }
}

