using FamilyLoan2020.Models.Abstract;

namespace FamilyLoan2020.Models.Contract
{
    /// <summary>
    /// متد های وابسته به آیدی
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIdentityRepository<T> : IRepository<T> where T : BaseEntityIdentity
    {
        /// <summary>
        /// حذف موجودیت با آیدی
        /// </summary>
        /// <param name="id">آیدی</param>
        void DeleteByID(int id);

        /// <summary>
        /// واکشی اطلاعات با آیدی
        /// </summary>
        /// <param name="id">آیدی</param>
        /// <returns></returns>
        T GetByID(int id);
    }
}


