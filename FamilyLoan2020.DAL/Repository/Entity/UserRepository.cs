using FamilyLoan2020.Models.Contract.Entity;
using FamilyLoan2020.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLoan2020.DAL.Repository.Entity
{
    public class UserRepository : IdentityRepository<User>, IUserRepository
    {
        public UserRepository(FamilyLoan2020Context context) : base(context)
        {
        }

        public bool DoesPersonHaveUserName(int personID)
        {
            var user = this.GetByID(personID);
            if (user != null && user.IsValid())
                return true;
            return false;
        }

        public bool IsUsernameExist(string username)
        {
            return this.Get(u => u.UserName.Trim().ToLower() == username.Trim().ToLower()).Any();
        }
    }
}
