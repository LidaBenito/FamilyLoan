using FamilyLoan2020.Models.Abstract;
using System.Collections.Generic;
using Sadr_Tools.ExtensionMethods;


namespace FamilyLoan2020.Models.Entity
{
    public enum EnPaymentType
    {
        حق_عضویت = 1,
        وام = 2,
        کارمزد = 3,
        قسط = 4,
         بانک = 5,
    }

    public partial class PaymentType : BaseEntityCode
    {
        public PaymentType()
        {
            Payments = new HashSet<Payment>();
            Banks = new HashSet<Bank>();
            PropertyHeaderList = new List<PropertyHeader>()
            {
                 new PropertyHeader("Code","کد"),
                 new PropertyHeader("Title","عنوان")
            };
        }


        public string Title { get; set; }

        public virtual ICollection<Payment> Payments { get; }
        public virtual ICollection<Bank> Banks { get; }

        public override bool IsValid()
        {
            return Code > 0 && !Title.IsNullOrEmpty();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
