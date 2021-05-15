using FamilyLoan2020.Models.Abstract;

namespace FamilyLoan2020.Models.Contract
{
    /// <summary>
    /// متد های وابسته به کد
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICodeRepository<T> : IRepository<T> where T : BaseEntityCode
    {
        /// <summary>
        /// حذف موجودیت با کد
        /// </summary>
        /// <param name="code">کد</param>
        void DeleteByCode(byte code);

        /// <summary>
        /// واکشی اطلاعات با کد
        /// </summary>
        /// <param name="code">کد</param>
        /// <returns></returns>
        /// 
        T GetByCode(byte code);
    }
}
