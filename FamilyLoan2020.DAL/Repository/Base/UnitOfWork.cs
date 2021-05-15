using FamilyLoan2020.DAL.Repository.Entity;
using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.Contract.Entity;

namespace FamilyLoan2020.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private FamilyLoan2020Context _loanContext;

        public UnitOfWork()
        {

        }


        /// <summary>
        /// شروع کانتکست از یونیت آو ورک
        /// </summary>
        public FamilyLoan2020Context LoanContext
        {
            get
            {
                if (_loanContext == null)
                    _loanContext = new FamilyLoan2020Context();
                return _loanContext;
            }
        }


        private IPaymentTypeRepository _paymentTypeRepository;
        private IPersonRepository _personRepository;
        private IPaymentRepository _paymentRepository;
        private ISettingRepository _settingRepository;
        private ILoanRequestRepository _loanRequestRepository;
        private ILoanItemRepository _loanItemRepository;
        private ILoanRepository _loanRepository;
        private IUserRepository _userRepository;
        private IPasswordHistoryRepository _passwordHistoryRepository;
        private IBankRepository _bankRepository;
      
        public IPaymentTypeRepository PaymentTypeRepository
        {
            get
            {
                if (_paymentTypeRepository == null)
                    _paymentTypeRepository = new PaymentTypeRepository(LoanContext);
                return _paymentTypeRepository;
            }
        }
        public IPersonRepository PersonRepository
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new PersonRepository(LoanContext);
                return _personRepository;
            }
        }
        public IPaymentRepository PaymentRepository
        {
            get
            {
                if (_paymentRepository == null)
                    _paymentRepository = new PaymentRepository(LoanContext);
                return _paymentRepository;
            }
        }
        public ISettingRepository SettingRepository
        {
            get
            {
                if (_settingRepository == null)
                    _settingRepository = new SettingRepository(LoanContext);
                return _settingRepository;
            }
        }
        public ILoanRequestRepository LoanRequestRepository
        {
            get
            {
                if (_loanRequestRepository == null)
                    _loanRequestRepository = new LoanRequestRepository(LoanContext);
                return _loanRequestRepository;
            }
        }
        public ILoanItemRepository LoanItemRepository
        {
            get
            {
                if (_loanItemRepository == null)
                    _loanItemRepository = new LoanItemRepository(LoanContext);
                return _loanItemRepository;
            }
        }
        public ILoanRepository LoanRepository
        {
            get
            {
                if (_loanRepository == null)
                    _loanRepository = new LoanRepository(LoanContext);
                return _loanRepository;
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(LoanContext);
                return _userRepository;
            }
        }

        public IPasswordHistoryRepository PasswordHistoryRepository
        {
            get
            {
                if (_passwordHistoryRepository == null)
                    _passwordHistoryRepository = new PasswordHistoryRepository(LoanContext);
                return _passwordHistoryRepository;
            }
        }

        public IBankRepository BankRepository
        {
            get
            {
                if (_bankRepository == null)
                    _bankRepository = new BankRepository(LoanContext);
                return _bankRepository;
            }
        }

        public void Save()
        {
            LoanContext.SaveChanges();
        }

        public void Dispose()
        {
            LoanContext.Dispose();
           
        }
    }
}
