namespace FamilyLoan2020.Models.Entity
{
    using FamilyLoan2020.Models.Abstract;
    using System;
    using System.Collections.Generic;
    using Sadr_Tools.ExtensionMethods;

    public partial class LoanItem : BaseEntityIdentity
    {

        public LoanItem()
        {
            Payments = new HashSet<Payment>();
        }

        public int LoanID { get; set; }

        public int InstallmentAmount { get; set; }

        public DateTime InstallmentDate { get; set; }

        public virtual Loan Loan { get; set; }


        public virtual ICollection<Payment> Payments { get; }

        public override bool IsValid()
        {
            return LoanID > 0 && InstallmentAmount > 0;
        }


        public string PersianInstallmentDate 
        {
            get
            {
                return InstallmentDate.ToPersianDate();
            }
            
        }

        //public override string ToString()
        //{
        //    return PersianInstallmentDate;
        //}
    }
}
