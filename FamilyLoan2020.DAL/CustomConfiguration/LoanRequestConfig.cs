using FamilyLoan2020.Models.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
    internal class LoanRequestConfig : EntityTypeConfiguration<LoanRequest>
    {
        public LoanRequestConfig()
        {
            this.ToTable("LoanRequest", "Loan");
            this.Property(p => p.Note).HasMaxLength(200);
            this.Ignore(p => p.ItemNo);
            this.HasMany(x => x.Loans).WithRequired(x => x.LoanRequest).WillCascadeOnDelete(false);
        }
    }
}
