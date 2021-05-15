using FamilyLoan2020.Models.DTO;
using FamilyLoan2020.Models.Entity;
using System;
using System.Collections.Generic;

namespace FamilyLoan2020.Models.Contract
{
    public interface IPaymentRepository : IIdentityRepository<Payment>
    {
        /// <summary>
        /// پرداخت وام 
        /// </summary>
        /// <param name="obj"></param>
        /// 
        void InsertByLoan(Loan obj);

        // بدون استفاده از DTO
        // List<Payment> GetPayments(int? PaymentID, int? PersonID, byte? SettingCode, byte? PaymentTypeCode, int? FromAmount, int? ToAmount, DateTime? FromDate, DateTime? ToDate);

        /// <summary>
        /// جستجوی پرداخت ها
        /// </summary>
        List<Payment> GetPayments(PaymentSearchDTO paymentSearch);

        /// <summary>
        /// لیست پرداختی های یک روز
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <returns></returns>
        /// 
        
        List<Payment> GetPayments(DateTime date);
        /// <summary>
        /// جمع مبالغ به تفکیک نوع پرداخت
        /// </summary>
        /// <param name="payments"></param>
        /// <returns></returns>
        (int SumLoan, int SumInstallment,int SumFee) GetSumByPaymentType(List<Payment> payments);
        /// <summary>
        /// هر شخص در کل چه میزان پرداختی داشته است
        /// </summary>
        /// <param name="personID">شناسه شخص</param>
        /// <returns></returns>
        (int SumFee, int SumInstallment, ulong Total) TotalPayPerPerson(int personID);

    }

}
