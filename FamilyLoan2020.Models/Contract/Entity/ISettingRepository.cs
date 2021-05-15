using FamilyLoan2020.Models.Entity;
using System;

namespace FamilyLoan2020.Models.Contract
{
    public interface ISettingRepository : ICodeRepository<Setting>
    {
        /// <summary>
        /// جدید ترین قانون
        /// </summary>
        /// <returns></returns>
        Setting GetLastOne();

        /// <summary>
        /// کل مبلغ حق عضویت از ابتدا شروع صندوق تا آخرین ماه دوره جاری
        /// </summary>
        /// <returns></returns>
        ulong GetTotalMembershipFee();

        /// <summary>
        /// کل مبلغ حق عضویت از ابتدا شروع صندوق تا ماه ورودی
        /// </summary>
        /// <param name="date">ماه</param>
        /// <returns></returns>
        ulong GetTotalMembershipFee(DateTime date);
    }

}

