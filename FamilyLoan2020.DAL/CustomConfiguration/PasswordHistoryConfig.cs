using FamilyLoan2020.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
   internal class PasswordHistoryConfig:EntityTypeConfiguration<PasswordHistory>
    {
        public PasswordHistoryConfig()
        {
            this.ToTable("Password", "Account");
            this.Property(x => x.UserID).IsRequired();
            this.Property(x => x.Salt).IsRequired();
            this.Property(x => x.HashPassword).IsRequired();
            this.Property(x => x.Salt).IsUnicode(false);
            this.Property(x => x.HashPassword).IsUnicode(false);
            this.Property(x => x.Salt).HasMaxLength(8000);
            this.Property(x => x.HashPassword).HasMaxLength(8000);

        }
    }
}
