using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyLoan2020.DAL.Repository
{
    public class LoanItemRepository : IdentityRepository<LoanItem>, ILoanItemRepository
    {

        UnitOfWork uow = new UnitOfWork();


        public LoanItemRepository(FamilyLoan2020Context context) : base(context)
        {
        }



        public int GetAmount(int loanItemID)
        {
            var obj = this.GetByID(loanItemID);
            if (obj != null && obj.IsValid())
                return obj.InstallmentAmount;
            return 0;
        }

        public List<LoanItem> GetUnpaidList(int PersonID)
        {
            var list = (from li in this.Get()
                        where li.Loan.LoanRequest.PersonID == PersonID &&
                     li.InstallmentAmount != 0
                        orderby li.ID
                        select li).ToList();
            return list;

        }

        public void InsertRange(Loan loanObject)
        {

            for (int i = 1; i <= loanObject.Setting.InstallmentQty; i++)
            {
                LoanItem obj = new LoanItem()
                {

                    LoanID = loanObject.ID,
                    InstallmentAmount = loanObject.InstallmentAmount,
                    InstallmentDate = loanObject.LoanDate.AddMonths(i)
                };
                this.Insert(obj);

            }
        }

        //public List<LoanItem> InstallmentAccounting(Payment payment)
        //{
        //    var Remaining = 0;
        //    var outOfPlace = 0;
        //    List<LoanItem> list = uow.LoanItemRepository.Get().ToList();
        //    foreach (var item in list)
        //    {
        //        if (item.ID == payment.LoanItemID)
        //        {
        //            payment.LoanID = item.LoanID;
        //            if (payment.Amount == item.InstallmentAmount)
        //            {
        //                item.InstallmentAmount -= payment.Amount;

        //                break;
        //            }
        //            else
        //            if (payment.Amount < item.InstallmentAmount)
        //            {
        //                item.InstallmentAmount -= payment.Amount;
        //                LoanItem loanItem = uow.LoanItemRepository.Get(c => c.ID == item.ID + 1).SingleOrDefault();
        //                loanItem.InstallmentAmount += item.InstallmentAmount;

        //                break;

        //            }
        //            else
        //             if (payment.Amount > item.InstallmentAmount)
        //            {
        //                Remaining = payment.Amount % item.InstallmentAmount;
        //                outOfPlace = payment.Amount / item.InstallmentAmount;
        //                var count = 0;
        //                count += outOfPlace + item.ID;
        //                for (int i = item.ID; i < count; i++)
        //                {
        //                    LoanItem currectLoanItem = uow.LoanItemRepository.Get(c => c.ID == i).SingleOrDefault();

        //                    currectLoanItem.InstallmentAmount -= currectLoanItem.InstallmentAmount;

        //                }
        //                count += 1;
        //                LoanItem LoanItemNew = uow.LoanItemRepository.Get(c => c.ID == count).SingleOrDefault();
        //                LoanItemNew.InstallmentAmount -= Remaining;

                        
        //                break;
        //            }
        //        }

        //    }
        //        return list;
        //}
    }

}
