namespace FamilyLoan2020.Models.Entity
{
    using FamilyLoan2020.Models.Abstract;
    using System;
    using System.Collections.Generic;
    using Sadr_Tools.ExtensionMethods;
    using System.Linq;

    public partial class Loan : BaseEntityIdentity
    {
        public Loan()
        {
            LoanItems = new HashSet<LoanItem>();
            PropertyHeaderList = new List<PropertyHeader>()
            {
                 new PropertyHeader("ID","شناسه"),
                 new PropertyHeader("LoanRequest","درخواست وام"),
                 new PropertyHeader("Setting","قوانین دوره"),
                 new PropertyHeader("PersonLoanNo","شماره وام شخص"),
                 new PropertyHeader("LoanNo","شماره وام این دوره"),
                 new PropertyHeader("Amount","مبلغ وام",true),
                 new PropertyHeader("NetAmount","مبلغ خالص",true),
                 new PropertyHeader("PersianLoanDate","تاریخ وام"),
                 new PropertyHeader("PersianFirstInstallmentDate","تاریخ اولین قسط"),
                 new PropertyHeader("PersianLastInstallmentDate","تاریخ آخرین قسط"),
            };
        }
        public int PersonID{ get; set; }

        public int LoanRequestID { get; set; }

        public byte SettingCode { get; set; }

        public short LoanNo { get; set; }

        public byte PersonLoanNo  { get; set; }

        /// <summary>
        /// مبلغ وام
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// تاریخ وام
        /// </summary>
        public DateTime LoanDate { get; set; }

        /// <summary>
        /// تاریخ اولین قسط
        /// </summary>
        public DateTime FirstInstallmentDate { get; set; }

        /// <summary>
        /// تاریخ آخرین قسط
        /// </summary>
        public DateTime LastInstallmentDate { get; set; }
        /// <summary>
        ///     مبلغ قسط
        /// </summary>
        public int Installment{ get; set; }

        public bool IsFinished { get; set; }

        public virtual LoanRequest LoanRequest { get; set; }

        public virtual Setting Setting { get; set; }

        public virtual ICollection<LoanItem> LoanItems { get; }

        public override bool IsValid()
        {
            return (LoanNo > 0 && ID > 0);
        }

        public string PersianLoanDate { get { return LoanDate.ToPersianDate(); } }
        public string PersianFirstInstallmentDate { get { return FirstInstallmentDate.ToPersianDate(); } }
        public string PersianLastInstallmentDate { get { return LastInstallmentDate.ToPersianDate(); } }
      
        /// <summary>
        /// مبلغ هر قسط
        /// </summary>
        public int InstallmentAmount
        { 
            get
            {
                return Amount / Setting.InstallmentQty;
            }
           
        }

       
        /// <summary>
        /// مبلغ خالص
        /// </summary>
        public int NetAmount
        {
            get
            {
                //  return Amount - WageAmount;
                return Amount; 
            }
        }

        public string LoanStatus
        {
            get
            {
                return IsFinished ? "تسویه شده" : "تسویه نشده";
            }
        }
    }
}
