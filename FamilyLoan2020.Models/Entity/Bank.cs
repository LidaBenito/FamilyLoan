using FamilyLoan2020.Models.Abstract;
using System;
using System.Collections.Generic;

namespace FamilyLoan2020.Models.Entity
{
   

    public partial class Bank : BaseEntityIdentity
    {
        public Bank()
        {
            Payments = new HashSet<Payment>();
            PropertyHeaderList = new List<PropertyHeader>()
            {
                 new PropertyHeader("ID","شناسه"),
                 new PropertyHeader("PaymentType","نوع پرداخت"),
                 new PropertyHeader("AccountNO","شماره حساب"),
                 new PropertyHeader("Amount","مبلغ"),
                 new PropertyHeader("AmountDate","تاریخ"),
                 new PropertyHeader("Description","توضیحات"),
            };
        }
        public byte PaymentTypeCode { get; set; }
        public string Description{ get; set; }
        public DateTime AmountDate { get; set; }
        public string AccountNO{ get; set; }
        public int Amount{ get; set; }
       // public int Total{ get; set; }
        public virtual ICollection<Payment> Payments { get; }
        public virtual PaymentType PaymentType { get; set; }

        public override bool IsValid()
        {
            return ID > 0;
        }
    }
}
