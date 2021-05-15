using FamilyLoan2020.Models.Abstract;
using Sadr_Tools.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLoan2020.Models.Entity
{
    public class PasswordHistory : BaseEntityIdentity
    {
        public PasswordHistory()
        {

        }
        public int UserID { get; set; }
        public string Salt { get; set; }
        public string HashPassword { get; set; }
        public virtual User User { get; }
        public override bool IsValid()
        {
            return UserID > 0 && !HashPassword.IsNullOrEmpty();
        }
    }
}
