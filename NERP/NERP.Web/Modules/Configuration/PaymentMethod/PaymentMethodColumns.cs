
namespace NERP.Configuration.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Configuration.PaymentMethod")]
    [BasedOnRow(typeof(Entities.PaymentMethodRow))]
    public class PaymentMethodColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId")]
        public Int32 Id { get; set; }
        [EditLink]
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Int16 IsPaymentDetailReq { get; set; }
        public String Note { get; set; }
        //public Int32 ProjectId { get; set; }
        //public Int32 OrganogramId { get; set; }
        //public Int32 ScopeId { get; set; }
        //public Int32 CompanyId { get; set; }
        //public Int32 StatusId { get; set; }
        //public DateTime ActiveOn { get; set; }
        //public DateTime InactiveOn { get; set; }
        //public Int16 IsActive { get; set; }
        //public Int32 DbId { get; set; }
        //public Int32 CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public String CreatedPc { get; set; }
        //public Int32 UpdatedBy { get; set; }
        //public DateTime UpdatedOn { get; set; }
        //public String UpdatedPc { get; set; }
        //public Int32 DeletedBy { get; set; }
        //public DateTime DeletedOn { get; set; }
        //public String DeletedPc { get; set; }
        //public Int16 IsDelete { get; set; }
        public Int32 PaymentMethodId { get; set; }
    }
}