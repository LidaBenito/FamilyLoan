using FamilyLoan2020.Models.Contract.Entity;
using FamilyLoan2020.Models.Entity;
using Sadr_Tools.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyLoan2020.DAL.Repository.Entity
{
    public class PasswordHistoryRepository : IdentityRepository<PasswordHistory>, IPasswordHistoryRepository
    {
        readonly FamilyLoan2020Context ctx;

        public PasswordHistoryRepository(FamilyLoan2020Context context) : base(context)
        {
            ctx = context;
        }

        public bool DoesCurrentPasswordCorrect(int userID, string currentPassword)
        {
            var lastPasswordHistory = (from p in this.Get()
                                       where p.UserID == userID
                                       orderby p.ID descending
                                       select p).First();

            var lastSalt = lastPasswordHistory.Salt;

            var candidatePass = currentPassword.MakeSaltedHashPassword(lastSalt);

            return lastPasswordHistory.HashPassword == candidatePass;

        }


        public User  DoesLoginSuccessful(string username, string password)
        {

            var user = new UserRepository(ctx).Get(x => x.UserName.ToLower() == username.ToLower()).SingleOrDefault();
            if (user == null || !user.IsActive || !user.IsValid())
                return null;

            if (DoesCurrentPasswordCorrect(user.ID, password))
                return user;
            return null;
        }
    }
}
