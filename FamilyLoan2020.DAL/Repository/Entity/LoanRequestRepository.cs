using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.Entity;
using System.Linq;
using Sadr_Tools.ExtensionMethods;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace FamilyLoan2020.DAL.Repository
{
    public class LoanRequestRepository : IdentityRepository<LoanRequest>, ILoanRequestRepository
    {
        readonly FamilyLoan2020Context ctx;

        public LoanRequestRepository(FamilyLoan2020Context context) : base(context)
        {
            ctx = context;
        }


        public List<LoanRequest> GetUncertainList()
        {
            var list = (from lr in this.Get()
                        where lr.IsApproved == null
                        orderby lr.ID
                        select lr).ToList();

            int index = 1;
            foreach (LoanRequest item in list)
            {
                item.ItemNo = index;
                index++;
            }

            return list;
        }

        public bool IsRequestAmountValid(int requestAmount)
        {
            var lastSetting = new SettingRepository(ctx).GetLastOne();
            return requestAmount.Between(lastSetting.MinLoanAmount, lastSetting.MaxLoanAmount);
        }

        public void SetLoanRequestStatus(int loanRequestID, bool isApproved = true)
        {
            var loanRequest = this.GetByID(loanRequestID);
            loanRequest.IsApproved = isApproved;
            this.Update(loanRequest);
        }

        public override IQueryable<LoanRequest> Get()
        {
            var list = base.Get();

            int index = 1;
            foreach (LoanRequest item in list)
            {
                item.ItemNo = index;
                index++;
            }

            return list;
        }

        public override IQueryable<LoanRequest> Get(Expression<Func<LoanRequest, bool>> predicate)
        {
            var list = base.Get(predicate);

            int index = 1;
            foreach (LoanRequest item in list)
            {
                item.ItemNo = index;
                index++;
            }

            return list;
        }
    }

}
