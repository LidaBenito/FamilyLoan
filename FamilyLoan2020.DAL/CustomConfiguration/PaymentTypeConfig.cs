using FamilyLoan2020.Models.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
    internal class PaymentTypeConfig : EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeConfig()
        {
            this.ToTable("PaymentType", "Pay");
            this.HasKey(x => x.Code);
            this.Property(x => x.Title).IsRequired();
            this.HasMany(x => x.Payments).WithRequired(x => x.PaymentType).WillCascadeOnDelete(false);
            this.HasMany(x => x.Banks).WithRequired(x => x.PaymentType).WillCascadeOnDelete(false);
        }
    }
}
