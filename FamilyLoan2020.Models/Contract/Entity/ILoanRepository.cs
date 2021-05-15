using FamilyLoan2020.Models.DTO;
using FamilyLoan2020.Models.Entity;
using System.Collections.Generic;
using System.Collections;

namespace FamilyLoan2020.Models.Contract
{
    public interface ILoanRepository : IIdentityRepository<Loan>
    {
        /// <summary>
        /// کد وام جدید برای شخص مورد نظر
        /// </summary>
        /// <param name="personID">شناسه شخص</param>
        byte GetPersonLoanNo(int personID);

        /// <summary>
        /// کد وام جدید به ازای هر دوره
        /// </summary>
        /// <param name="settingCode">کد دوره</param>
        short GetSettingLoanNo(int settingCode);
        /// <summary>
        /// لیست اطلاعات اشخاص به همراه اطلاعات وام
        /// </summary>
        /// <returns></returns>
        List<PersonLoanDTO>  GetPersonWithLoanInformation();

        /// <summary>
        /// لیست اطلاعات اشخاص به همراه اطلاعات تجمعی وام
        /// </summary>
        /// <returns></returns>
        IList GetPersonWithAggregateLoanInformation();
       

    }

}
