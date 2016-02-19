
namespace NERP.HR.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HR.Employee")]
    [BasedOnRow(typeof(Entities.EmployeeRow))]
    public class EmployeeForm
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Int32 UserTypeId { get; set; }
        public Int32 UserGroupId { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String FullName { get; set; }
        public Int32 ImageId { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Mobile { get; set; }
        public String Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String LoginName { get; set; }
        public String Password { get; set; }
        public Int16 IsTaxable { get; set; }
        public Decimal CommissionRate { get; set; }
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
    }
}