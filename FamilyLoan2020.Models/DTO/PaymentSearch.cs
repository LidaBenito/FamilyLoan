using System;

namespace FamilyLoan2020.Models.DTO
{
    /// <summary>
    /// مدلی برای فرم جستجوی پرداخت ها
    /// </summary>
   public class PaymentSearchDTO
    {
       
        public int? PaymentID { get; set; }
        public int? PersonID { get; set; }
        public byte? SettingCode { get; set; }
        public byte? PaymentTypeCode { get; set; }
        public int? FromAmount { get; set; }
        public int? ToAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
