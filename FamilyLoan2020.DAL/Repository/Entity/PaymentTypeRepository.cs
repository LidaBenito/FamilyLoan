using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.Entity;

namespace FamilyLoan2020.DAL.Repository
{
    public class PaymentTypeRepository : CodeRepository<PaymentType>, IPaymentTypeRepository
    {
        public PaymentTypeRepository(FamilyLoan2020Context context) : base(context)
        {

        }
    }

}

