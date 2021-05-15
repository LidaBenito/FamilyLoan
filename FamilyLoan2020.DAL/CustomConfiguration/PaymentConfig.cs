using FamilyLoan2020.Models.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
    internal class PaymentConfig : EntityTypeConfiguration<Payment>
    {
        public PaymentConfig()
        {
            this.ToTable("Payment", "Pay");
            this.Property(x => x.PaymentDateTime).HasColumnType("datetime");
        }
    }
}
