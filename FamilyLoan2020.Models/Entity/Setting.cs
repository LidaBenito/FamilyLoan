namespace FamilyLoan2020.Models.Entity
{
    using FamilyLoan2020.Models.Abstract;
    using Sadr_Tools.ExtensionMethods;
    using System;
    using System.Collections.Generic;


    public partial class Setting : BaseEntityCode
    {
        public Setting()
        {
            Loans = new HashSet<Loan>();

            PropertyHeaderList = new List<PropertyHeader>()
            {
                 new PropertyHeader("Code","کد",false,50),
                 new PropertyHeader("MembershipFee","حق عضویت",true),
                 new PropertyHeader("MinLoanAmount","حداقل مبلغ وام",true),
                 new PropertyHeader("MaxLoanAmount","حداکثر مبلغ وام",true),
                 new PropertyHeader("InstallmentQty","تعداد اقساط",false,80),
                 
            };

        }
        /// <summary>
        /// حق عضویت ماهانه
        /// </summary>
        public int MembershipFee { get; set; }

        public int MinLoanAmount { get; set; }

        public int MaxLoanAmount { get; set; }

        /// <summary>
        /// تعداد اقساط
        /// </summary>
        public byte InstallmentQty { get; set; }


   
        public virtual ICollection<Loan> Loans { get; }
        /// <summary>
        ///     تاریخ شروع دوره
        /// </summary>
        public DateTime StartDate{ get; set; }
        /// <summary>
        ///     تاریخ پایان دوره
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        ///     تعداد ماه های هر دوره
        /// </summary>
        public byte Duration
        { 
            get 
            {
                return StartDate.CalculateDifferenceMonth(EndDate).ToByte();
            } 
        
        }

        public override bool IsValid()
        {
            return Code > 0;
        }

        public override string ToString()
        {
            return $"{Code} : {MembershipFee}";
        }
        /// <summary>
        /// کل مبلغ حق عضویت به ازای هر دوره
        /// </summary>
        public int TotalFeePaymentPerDuration
        {
            get
            {
                return Duration * MembershipFee;
            }
        }
    }
}
