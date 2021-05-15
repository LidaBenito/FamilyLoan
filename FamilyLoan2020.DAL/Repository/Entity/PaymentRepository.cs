using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.DTO;
using FamilyLoan2020.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Sadr_Tools.ExtensionMethods;
using System.Data.Entity.SqlServer;

namespace FamilyLoan2020.DAL.Repository
{
    public class PaymentRepository : IdentityRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(FamilyLoan2020Context context) : base(context)
        {

        }


        public List<Payment> GetPayments(PaymentSearchDTO ps)
        {
            var list = (from p in this.Get()
                        where (ps.PaymentID == null || p.ID == ps.PaymentID) &&
                              (ps.PersonID == null ||
                                    (p.PersonID != null && p.PersonID == ps.PersonID) ||
                                    (p.Loan != null && p.Loan.LoanRequest.PersonID == ps.PersonID) ||
                                    (p.LoanItem != null && p.LoanItem.Loan.LoanRequest.PersonID == ps.PersonID)) &&
                              (ps.PaymentTypeCode == null || p.PaymentTypeCode == ps.PaymentTypeCode) &&
                              ((ps.SettingCode == null) || p.Loan.SettingCode == ps.SettingCode) &&
                              (ps.FromAmount == null || p.Amount >= ps.FromAmount.Value && p.Amount <= ps.ToAmount.Value) &&
                              (ps.FromDate == null || p.PaymentDateTime >= ps.FromDate.Value && p.PaymentDateTime <= ps.ToDate.Value)
                        orderby p.ID
                        select p).ToList();

            return list;
        }

        public List<Payment> GetPayments(DateTime date)
        {
            var list = (from p in this.Get()
                        where SqlFunctions.DateDiff("day", p.PaymentDateTime, date) == 0
                        orderby p.ID
                        select p).ToList();
            return list;
        }



        public void InsertByLoan(Loan obj)
        {

            var loanPayment = new Payment()
            {
                LoanID = obj.ID,
                Amount = obj.NetAmount,
                PaymentDateTime = DateTime.Now,
                PaymentTypeCode = (byte)EnPaymentType.وام
            };

           

            this.Insert(loanPayment);
          
        }
      

        public (int SumFee, int SumInstallment, ulong Total) TotalPayPerPerson(int personID)
        {
            var payments = (from p in this.Get()
                            where p.PersonID == personID ||
                                  (p.LoanItem != null && p.LoanItem.Loan.LoanRequest.PersonID == personID)
                            select p).ToList();

            int sumFee = 0;
            int sumInstallment = 0;

            foreach (var item in payments)
            {
                if (item.PaymentTypeCode == (byte)EnPaymentType.قسط)
                {
                    sumInstallment += item.Amount;
                    continue;
                }

                if (item.PaymentTypeCode == (byte)EnPaymentType.حق_عضویت)
                {
                    sumFee += item.Amount;
                    continue;
                }
            }

            return (sumFee, sumInstallment, (ulong)(sumFee + sumInstallment));
        }

        (int SumLoan, int SumInstallment, int SumFee) IPaymentRepository.GetSumByPaymentType(List<Payment> payments)
        {
            int SumLoan = 0;
            int SumFee = 0;
            int SumInstallment = 0;
            foreach (var item in payments)
            {
                if (item.PaymentTypeCode == (byte)EnPaymentType.وام)
                {
                   
                    SumLoan += item.Amount;

                    continue;
                }
                if (item.PaymentTypeCode == (byte)EnPaymentType.قسط)
                {
                    SumInstallment += item.Amount;
                    

                    continue;
                }
              
                if (item.PaymentTypeCode == (byte)EnPaymentType.حق_عضویت)
                {
                    SumFee += item.Amount;
                    continue;
                }
             
            }
            return (SumLoan, SumInstallment, SumFee);
        }

       
    }

}
