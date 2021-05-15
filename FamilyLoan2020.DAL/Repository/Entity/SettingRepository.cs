using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.Entity;
using Sadr_Tools.ExtensionMethods;
using System;
using System.Linq;

namespace FamilyLoan2020.DAL.Repository
{
    public class SettingRepository : CodeRepository<Setting>, ISettingRepository
    {
        public SettingRepository(FamilyLoan2020Context context) : base(context)
        {


        }

        public Setting GetLastOne()
        {
            var setting = (from s in this.Get()
                           orderby s.Code descending
                           select s).First();

            return setting;
        }

        public ulong GetTotalMembershipFee()
        {
            var list = this.Get().ToList();
            ulong totalSum = 0;
            foreach (var item in list)
            {
                totalSum += (ulong)item.TotalFeePaymentPerDuration;
            }

            return totalSum;
        }

        public ulong GetTotalMembershipFee(DateTime date)
        {
            var lastSetting = this.GetLastOne();
            var endDate = lastSetting.EndDate;
            var membershipFee = lastSetting.MembershipFee;

            if (date.Date > endDate.Date)
                throw new Exception("");

            var month = date.CalculateDifferenceMonth(endDate);
            var remainMonth = (ulong)(month * membershipFee);
            return this.GetTotalMembershipFee() - remainMonth;
        }
    }

}
