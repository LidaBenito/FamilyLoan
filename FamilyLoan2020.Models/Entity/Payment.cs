using FamilyLoan2020.Models.Abstract;
using System;
using System.Collections.Generic;
using Sadr_Tools.ExtensionMethods;
namespace FamilyLoan2020.Models.Entity
{
   

    public partial class Payment : BaseEntityIdentity
    {

        public Payment()
        {
            PropertyHeaderList = new List<PropertyHeader>()
            {
                 new PropertyHeader("ID","شناسه"),
                 new PropertyHeader("PaymentType","نوع پرداخت"),
                 new PropertyHeader("ViewModelPerson","شخص"),
                 new PropertyHeader("Amount","مبلغ",true),
                 new PropertyHeader("PersianPaymentDateTime","تاریخ"),
            };
        }



        public byte PaymentTypeCode { get; set; }
     
        public int? PersonID {  get; set; }
        public int? BankID { get; set; }

        public int? LoanID { get; set; }

        public int? LoanItemID { get; set; }

        public int ItemNo { get; set; }

        public int Amount { get; set; }

        public DateTime PaymentDateTime { get; set; }

        public virtual LoanItem LoanItem { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        public virtual Person Person { get; set; }

        public virtual Loan Loan { get; set; }


        public string PersianPaymentDateTime
        {
            get
            {
                return PaymentDateTime.ToPersianDate();
            }
        }

        public Person ViewModelPerson   
        {
            get
            {
                if (this.Loan != null) // وام و حق الزحمه
                    return this.Loan.LoanRequest.Person;
                if (this.LoanItem != null) // قسط وام
                    return this.LoanItem.Loan.LoanRequest.Person;
                if (this.Person != null) // حق عضویت
                    return this.Person;
                
                return null;
            }
        }

        public override bool IsValid()
        {
            return (ID > 0 && Amount >= 0);
        }
    }
}
