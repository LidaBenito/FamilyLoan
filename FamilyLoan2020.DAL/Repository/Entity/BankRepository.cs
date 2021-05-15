using FamilyLoan2020.Models.Contract.Entity;
using FamilyLoan2020.Models.Entity;

namespace FamilyLoan2020.DAL.Repository.Entity
{
    public class BankRepository : IdentityRepository<Bank>, IBankRepository
    {
        public BankRepository(FamilyLoan2020Context context) : base(context)
        {
        }
    }
}
