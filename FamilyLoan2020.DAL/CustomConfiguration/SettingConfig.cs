using FamilyLoan2020.Models.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
    internal class SettingConfig : EntityTypeConfiguration<Setting>
    {
        public SettingConfig()
        {

            this.ToTable("Setting", "Loan");
            this.HasKey(x => x.Code);
            this.HasMany(x => x.Loans).WithRequired(x => x.Setting).WillCascadeOnDelete(false);
            this.Property(x => x.StartDate).HasColumnOrder(8);
            this.Property(x => x.EndDate).HasColumnOrder(9);
        }
    }
}