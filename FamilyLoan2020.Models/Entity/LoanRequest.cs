namespace FamilyLoan2020.Models.Entity
{
    using FamilyLoan2020.Models.Abstract;
    using System;
    using System.Collections.Generic;
    using Sadr_Tools.ExtensionMethods;

    public partial class LoanRequest : BaseEntityIdentity
    {

        public LoanRequest()
        {
            Loans = new HashSet<Loan>();
            PropertyHeaderList = new List<PropertyHeader>()
            {
                 new PropertyHeader("ItemNo","شماره ردیف"),
                 new PropertyHeader("ID","شناسه"),
                 new PropertyHeader("Person","شخص"),
                 new PropertyHeader("RequestAmount","مبلغ درخواست",true),
                 new PropertyHeader("PersianRequestDate","تاریخ درخواست"),
                 new PropertyHeader("Note","توضیحات"),
            };
        }


        public int PersonID { get; set; }

        public int RequestAmount { get; set; }

        public DateTime RequestDate { get; set; }

        public bool? IsApproved { get; set; }

        public string Note { get; set; }

        public virtual ICollection<Loan> Loans { get; }

        public virtual Person Person { get; set; }

        public string PersianRequestDate
        {
            get
            {
                return RequestDate.ToPersianDate();
            }
        }

        /// <summary>
        /// شماره ردیف در گرید
        /// </summary>
        public int ItemNo { get; set; }

        public override bool IsValid()
        {
            return ID > 0 && PersonID > 0 && RequestAmount > 0;
        }

        public override string ToString()
        {
            return $"{Person} : {RequestAmount} : {RequestDate.ToPersianDate()}";
        }
    }
}


