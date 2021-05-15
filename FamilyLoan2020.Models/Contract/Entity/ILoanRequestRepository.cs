using FamilyLoan2020.Models.Entity;
using System.Collections.Generic;

namespace FamilyLoan2020.Models.Contract
{
    public interface ILoanRequestRepository : IIdentityRepository<LoanRequest>
    {
        /// <summary>
        /// آیا مبلغ درخواستی در رنج تعریف شده میباشد؟
        /// </summary>
        /// <param name="loanRequest">آبجکت درخواست وام</param>
        bool IsRequestAmountValid(int requestAmount);

        /// <summary>
        /// لیست درخواست ها با وضعیت نامشخص
        /// </summary>
        List<LoanRequest> GetUncertainList();


        /// <summary>
        /// مشخص کردن وضعیت درخواست وام
        /// </summary>
        /// <param name="loanRequestID">آیدی درخواست مورد نظر</param>
        /// <param name="isApproved">تایید یا عدم تایید</param>
        void SetLoanRequestStatus(int loanRequestID , bool isApproved = true);

    }
}
