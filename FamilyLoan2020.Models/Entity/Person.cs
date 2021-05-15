namespace FamilyLoan2020.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using FamilyLoan2020.Models.Abstract;
    using Sadr_Tools.ExtensionMethods;

    public partial class Person : BaseEntityIdentity
    {
        public Person()
        {
            LoanRequests = new HashSet<LoanRequest>();
            Payments = new HashSet<Payment>();

            PropertyHeaderList = new List<PropertyHeader>()
            {
                new PropertyHeader("ProfileImage","تصویر",false,100,true),
                 new PropertyHeader("ID","شناسه"),
                 new PropertyHeader("FullName","نام"),
                 new PropertyHeader("Title","جنسیت"),
                 new PropertyHeader("PersianBirthDate","تاریخ تولد"),
                 new PropertyHeader("Age","سن"),
                 new PropertyHeader("Mobile","موبایل"),
                 new PropertyHeader("AccountNo","شماره حساب")
            };

        }


        public string Name { get; set; }
        public string AccountNo { get; set; }

        public string Family { get; set; }

        public bool Gender { get; set; }

        public DateTime Birthdate { get; set; }

        public string Mobile { get; set; }

        public virtual ICollection<LoanRequest> LoanRequests { get; }

        public virtual ICollection<Payment> Payments { get; }

        public virtual User User { get; set; }

        public string FullName
        {
            get
            {
                return Name + " " + Family;
            }
        }

        public string Title
        {
            get
            {
                return Gender ? "مرد" : "زن";
            }
        }

        public byte Age
        {
            get
            {
                return Birthdate.CalculateAge();
            }
        }

        public string PersianBirthDate
        {
            get
            {
                return Birthdate.ToPersianDate();
            }
        }

        public override bool IsValid()
        {
            return ID > 0 && Name.Length >= 3 && Family.Length >= 3;
        }


        /// <summary>
        /// نام و فامیل رسمی
        /// </summary>
        public string FormalFullName
        {
            get
            {
                return (Gender ? "جناب آقای " : "سرکار خانم ") + FullName;
            }
        }

        public override string ToString()
        {
            return FormalFullName;
        }
        public byte[] ProfileImage { get; set; }

    }
}
