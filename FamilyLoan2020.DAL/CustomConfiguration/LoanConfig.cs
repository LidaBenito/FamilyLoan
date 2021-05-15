using FamilyLoan2020.Models.Entity;
using System.Data.Entity.ModelConfiguration;


namespace FamilyLoan2020.DAL.CustomConfiguration
{
    internal class LoanConfig : EntityTypeConfiguration<Loan>
    {
        public LoanConfig()
        {
            this.ToTable("Loan", "Loan");
            this.HasIndex(i => new { i.LoanNo, i.SettingCode }).IsUnique();
            this.HasMany(x => x.LoanItems).WithRequired(x => x.Loan).WillCascadeOnDelete(false); 
        }
    }
}

