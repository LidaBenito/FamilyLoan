using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.Contract.Entity;

namespace FamilyLoan2020.DAL.Repository
{
    public interface IUnitOfWork : System.IDisposable
    {
       
        IBankRepository BankRepository { get; }
        IPaymentTypeRepository PaymentTypeRepository { get; }

        IPaymentRepository PaymentRepository { get; }

        IPersonRepository PersonRepository { get; }

        ISettingRepository SettingRepository { get; }

        ILoanRequestRepository LoanRequestRepository { get; }

        ILoanItemRepository LoanItemRepository { get; }

        ILoanRepository LoanRepository { get; }
        IUserRepository UserRepository { get; }

        IPasswordHistoryRepository PasswordHistoryRepository { get; }



        void Save();
    }
}
