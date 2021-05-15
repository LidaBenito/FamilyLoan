using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.Entity;
using System.Linq;
using Sadr_Tools.ExtensionMethods;
using System.Collections.Generic;
using FamilyLoan2020.Models.DTO;
using System.Collections;


namespace FamilyLoan2020.DAL.Repository
{
    public class LoanRepository : IdentityRepository<Loan>, ILoanRepository
    {
        public LoanRepository(FamilyLoan2020Context context) : base(context)
        {

        }


        public byte GetPersonLoanNo(int personID)
        {
            var numbers = (from l in this.Get()
                           where l.LoanRequest.PersonID == personID
                           select l.PersonLoanNo);

            if (numbers == null || numbers.Count() == 0)
                return 1;
            return (numbers.Max() + 1).ToByte();
        }

        public short GetSettingLoanNo(int settingCode)
        {
            var numbers = (from l in this.Get()
                           where l.SettingCode == settingCode
                           select l.LoanNo);

            if (numbers == null || numbers.Count() == 0)
                return 1;
            return (numbers.Max() + 1).ToShort();
        }

        public List<PersonLoanDTO> GetPersonWithLoanInformation()
        {
            var loans = this.Get().ToList();
            var result = (from l in loans
                          select new PersonLoanDTO
                          {
                              Amount = l.Amount,
                              LoanStatus = l.LoanStatus,
                              PersianLastInstallmentDate = l.PersianLastInstallmentDate,
                              PersianLoanDate = l.PersianLoanDate,
                              LoanCode = l.PersonLoanNo,
                              PersonFullName = l.LoanRequest.Person.FormalFullName
                          }).ToList();

            return result;
        }

        public IList GetPersonWithAggregateLoanInformation()
        {
            var loans = this.Get().ToList();

            var result = (from l in loans
                          group l by l.LoanRequest.Person into grp
                          select new
                          {
                              PersonFullName = grp.Key.FormalFullName,
                              TotalCount = grp.Count(),
                              TotalAmount = grp.Sum(x => x.Amount),
                              TotalNetAmount = grp.Sum(x => x.NetAmount)

                          });

            return result.OrderByDescending(x => x.TotalCount).ToList();
        }

       
    }
}
