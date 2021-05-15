using FamilyLoan2020.Models.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
    internal class LoanItemConfig : EntityTypeConfiguration<LoanItem>
    {
        public LoanItemConfig()
        {
            this.ToTable("LoanItem", "Loan");
        }
    }
}
