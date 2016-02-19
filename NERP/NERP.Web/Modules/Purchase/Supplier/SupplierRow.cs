
namespace NERP.Purchase.Entities
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

    [ConnectionKey("NERPDB"), DisplayName("Supplier"), InstanceName("Supplier"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class SupplierRow : BaseRow
    {
        [DisplayName("User Type Id"), Column("User_Type_Id")]
        public Int32? UserTypeId
        {
            get { return Fields.UserTypeId[this]; }
            set { Fields.UserTypeId[this] = value; }
        }

        [DisplayName("User Group Id"), Column("User_Group_Id")]
        public Int32? UserGroupId
        {
            get { return Fields.UserGroupId[this]; }
            set { Fields.UserGroupId[this] = value; }
        }

        [DisplayName("First Name"), Column("First_Name"), Size(50)]
        public String FirstName
        {
            get { return Fields.FirstName[this]; }
            set { Fields.FirstName[this] = value; }
        }

        [DisplayName("Middle Name"), Column("Middle_Name"), Size(50)]
        public String MiddleName
        {
            get { return Fields.MiddleName[this]; }
            set { Fields.MiddleName[this] = value; }
        }

        [DisplayName("Last Name"), Column("Last_Name"), Size(50)]
        public String LastName
        {
            get { return Fields.LastName[this]; }
            set { Fields.LastName[this] = value; }
        }

        [DisplayName("Full Name"), Column("Full_Name"), Size(150)]
        public String FullName
        {
            get { return Fields.FullName[this]; }
            set { Fields.FullName[this] = value; }
        }

        [DisplayName("Image"), Column("Image_Id"), ForeignKey("[dbo].[Image]", "Id"), LeftJoin("jImage"), TextualField("ImageCode")]
        public Int32? ImageId
        {
            get { return Fields.ImageId[this]; }
            set { Fields.ImageId[this] = value; }
        }

        [DisplayName("Address1"), Size(100)]
        public String Address1
        {
            get { return Fields.Address1[this]; }
            set { Fields.Address1[this] = value; }
        }

        [DisplayName("Address2"), Size(100)]
        public String Address2
        {
            get { return Fields.Address2[this]; }
            set { Fields.Address2[this] = value; }
        }

        [DisplayName("Mobile"), Size(12)]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        [DisplayName("Email"), Size(50)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Date Of Birth"), Column("Date_Of_Birth")]
        public DateTime? DateOfBirth
        {
            get { return Fields.DateOfBirth[this]; }
            set { Fields.DateOfBirth[this] = value; }
        }

        [DisplayName("Login Name"), Column("Login_Name"), Size(50)]
        public String LoginName
        {
            get { return Fields.LoginName[this]; }
            set { Fields.LoginName[this] = value; }
        }

        [DisplayName("Password"), Size(50)]
        public String Password
        {
            get { return Fields.Password[this]; }
            set { Fields.Password[this] = value; }
        }

        [DisplayName("Is Taxable"), Column("Is_Taxable")]
        public Int16? IsTaxable
        {
            get { return Fields.IsTaxable[this]; }
            set { Fields.IsTaxable[this] = value; }
        }

        [DisplayName("Commission Rate"), Column("Commission_Rate"), Size(18), Scale(Statics.DecimalLength), NotNull]
        public Decimal? CommissionRate
        {
            get { return Fields.CommissionRate[this]; }
            set { Fields.CommissionRate[this] = value; }
        }

        [DisplayName("Note"), Size(200)]
        public String Note
        {
            get { return Fields.Note[this]; }
            set { Fields.Note[this] = value; }
        }

        [DisplayName("Project"), Column("Project_Id"), ForeignKey("[dbo].[Project]", "Id"), LeftJoin("jProject"), TextualField("ProjectCode")]
        public Int32? ProjectId
        {
            get { return Fields.ProjectId[this]; }
            set { Fields.ProjectId[this] = value; }
        }

        [DisplayName("Organogram Id"), Column("Organogram_Id")]
        public Int32? OrganogramId
        {
            get { return Fields.OrganogramId[this]; }
            set { Fields.OrganogramId[this] = value; }
        }

        [DisplayName("Scope Id"), Column("Scope_Id")]
        public Int32? ScopeId
        {
            get { return Fields.ScopeId[this]; }
            set { Fields.ScopeId[this] = value; }
        }


        [DisplayName("Project Name"), Expression("jProject.[Name]")]
        public String ProjectName
        {
            get { return Fields.ProjectName[this]; }
            set { Fields.ProjectName[this] = value; }
        }

        [DisplayName("Company Name"), Expression("jCompany.[Name]")]
        public String CompanyName
        {
            get { return Fields.CompanyName[this]; }
            set { Fields.CompanyName[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public SupplierRow()
            : base(Fields)
        {
        }

        public class RowFields : BaseRow.BaseRowFields
        {
            public readonly Int32Field UserTypeId;
            public readonly Int32Field UserGroupId;
            public readonly StringField FirstName;
            public readonly StringField MiddleName;
            public readonly StringField LastName;
            public readonly StringField FullName;
            public readonly Int32Field ImageId;
            public readonly StringField Address1;
            public readonly StringField Address2;
            public readonly StringField Mobile;
            public readonly StringField Email;
            public readonly DateTimeField DateOfBirth;
            public readonly StringField LoginName;
            public readonly StringField Password;
            public readonly Int16Field IsTaxable;
            public readonly DecimalField CommissionRate;

            public readonly StringField ProjectName;
            public readonly StringField CompanyName;

            public RowFields()
                : base("[Pur].[Supplier]")
            {
                LocalTextPrefix = "Purchase.Supplier";
            }
        }
    }
}