using FamilyLoan2020.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
   internal class BankConfig:EntityTypeConfiguration<Bank>
    {
        public BankConfig()
        {
            this.ToTable("Bank", "Bank");
            this.HasKey(x => x.ID);
        }
    }
}
