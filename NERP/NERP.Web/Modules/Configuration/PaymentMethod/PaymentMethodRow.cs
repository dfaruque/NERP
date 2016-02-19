
namespace NERP.Configuration.Entities
{
    using Serenity.Services; using NERP.Common;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Payment_Method"), InstanceName("Payment_Method"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class PaymentMethodRow : BaseRow
    {

        [DisplayName("Is Payment Detail Req"), Column("Is_Payment_Detail_Req")]
        public Int16? IsPaymentDetailReq
        {
            get { return Fields.IsPaymentDetailReq[this]; }
            set { Fields.IsPaymentDetailReq[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PaymentMethodRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int16Field IsPaymentDetailReq;

            public RowFields()
                : base("[dbo].[Payment_Method]")
            {
                LocalTextPrefix = "Configuration.PaymentMethod";
            }
        }
    }
}