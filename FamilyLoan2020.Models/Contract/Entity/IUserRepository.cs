using FamilyLoan2020.Models.Entity;

namespace FamilyLoan2020.Models.Contract.Entity
{
    public interface IUserRepository : IIdentityRepository<User>
    {
        ///<summary>
        ///آیا این نام کاربری قبلا ثبت شده؟
        /// </summary>
        /// <param name="username">نام کاربری</param>
        bool IsUsernameExist(string Username);

        ///<summary>
        ///آیا این شخص کاربری دارد؟
        /// </summary>
        /// <param name="personID">شناسه شخص</param>
        bool DoesPersonHaveUserName(int personID);  
    }
}
