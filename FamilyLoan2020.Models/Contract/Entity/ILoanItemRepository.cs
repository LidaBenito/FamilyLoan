using FamilyLoan2020.Models.Entity;
using System.Collections.Generic;

namespace FamilyLoan2020.Models.Contract
{
    public interface ILoanItemRepository : IIdentityRepository<LoanItem>
    {

        /// <summary>
        /// افزودن اقلام وام
        /// </summary>
        /// <param name="loanObject"></param>
        void InsertRange(Loan loanObject);

        /// <summary>
        /// لیست اقلام های پرداخت نشده وام شخص مورد نظر
        /// </summary>
        /// <param name="PersonID">شناسه شخص</param>
        List<LoanItem> GetUnpaidList(int PersonID);

        /// <summary>
        /// برگرداندن مبلغ اقلام وام
        /// </summary>
        /// <param name="loanItemID">شناسه اقلام وام</param>
        int GetAmount(int loanItemID);
        /// <summary>
        /// کسر اقساط پرداخت شده
        /// </summary>
        /// <param name="payment"></param>
       // List<LoanItem> InstallmentAccounting(Payment payment);
      
    }

}
