using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.DTO;
using FamilyLoan2020.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace FamilyLoan2020.DAL.Repository
{
    public class PersonRepository : IdentityRepository<Person>, IPersonRepository
    {
        public PersonRepository(FamilyLoan2020Context context) : base(context)
        {

        }



        public List<Person> GetPeopleWithUserInfo()
        {
            var people = (from p in this.Get()
                          where p.User != null && p.User.IsActive
                          orderby p.ID
                          select p).ToList();
            return people;
        }

        public Loan HasUnfinishedLoan(int personID)
        {
            var unFinishedLoan = (from c in LoanContext.Loans
                                  where c.LoanRequest.PersonID == personID && !c.IsFinished
                                  select c).SingleOrDefault();

            return unFinishedLoan;

        }
    }


}
