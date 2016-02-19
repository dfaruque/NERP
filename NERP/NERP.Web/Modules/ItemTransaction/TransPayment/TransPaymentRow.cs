
namespace NERP.ItemTransaction.Entities
{
    using NERP.Common;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("NERPDB"), DisplayName("Trans_Payment"), InstanceName("Trans_Payment"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class TransPaymentRow : BaseRow
    {

        [DisplayName("Trans"), Column("Trans_Id"), ForeignKey("[dbo].[Trans]", "Id"), LeftJoin("jTrans"), TextualField("TransCode")]
        public Int32? TransId
        {
            get { return Fields.TransId[this]; }
            set { Fields.TransId[this] = value; }
        }

        [DisplayName("Payment Method Id"), Column("Payment_Method_Id")]
        public Int32? PaymentMethodId
        {
            get { return Fields.PaymentMethodId[this]; }
            set { Fields.PaymentMethodId[this] = value; }
        }

        [DisplayName("Payment Amt"), Column("Payment_Amt"), Size(18), Scale(6)]
        public Decimal? PaymentAmt
        {
            get { return Fields.PaymentAmt[this]; }
            set { Fields.PaymentAmt[this] = value; }
        }

        [DisplayName("Payment Means No"), Column("Payment_Means_No"), Size(50)]
        public String PaymentMeansNo
        {
            get { return Fields.PaymentMeansNo[this]; }
            set { Fields.PaymentMeansNo[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TransPaymentRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public Int32Field TransId;
            public Int32Field PaymentMethodId;
            public DecimalField PaymentAmt;
            public StringField PaymentMeansNo;

            public RowFields()
                : base("[dbo].[Trans_Payment]")
            {
                LocalTextPrefix = "ItemTransaction.TransPayment";
            }
        }
    }
}