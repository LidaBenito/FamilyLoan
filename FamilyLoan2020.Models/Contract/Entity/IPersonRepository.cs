using FamilyLoan2020.Models.DTO;
using FamilyLoan2020.Models.Entity;
using System.Collections.Generic;

namespace FamilyLoan2020.Models.Contract
{
    public interface IPersonRepository : IIdentityRepository<Person>
    {
        /// <summary>
        /// آیا این شخص وام تسویه نشده ای دارد؟ اگر بله ، آن را برگردان
        /// </summary>
        /// <param name="person">آبجکت شخص مورد نظر</param>
        Loan HasUnfinishedLoan(int personID);

        /// <summary>
        /// لیست اشخاصی که برای آنها نام کاربری فعال تعریف شده
        /// </summary>
         List<Person> GetPeopleWithUserInfo();
      
    }

}

