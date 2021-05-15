using FamilyLoan2020.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLoan2020.Models.Contract.Entity
{
    public interface IPasswordHistoryRepository : IIdentityRepository<PasswordHistory>
    {

        ///<summary>
        ///آیا کلمه عبور فعلی درست است؟
        /// </summary>
        /// <param name="currentPassword">کلمه عبورفعلی</param>
        bool DoesCurrentPasswordCorrect(int userID,string currentPassword);

        ///<summary>
        ///آیا لاگین موفقیت آمیز است؟
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="password"> کلمه عبور</param>
        User DoesLoginSuccessful(string username,string password);
    }
}