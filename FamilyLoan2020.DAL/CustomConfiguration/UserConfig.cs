using FamilyLoan2020.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
    internal class UserConfig:EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            this.ToTable("User", "Account");
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(x => x.UserName).IsRequired();
            this.Property(x => x.UserName).IsUnicode(false);
            this.HasRequired(x => x.Person).WithRequiredDependent(x => x.User).WillCascadeOnDelete(false);
            this.HasMany(x => x.PasswordHistories).WithRequired(x => x.User).WillCascadeOnDelete(false);
        }
    }
}
