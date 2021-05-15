using FamilyLoan2020.Models.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FamilyLoan2020.DAL.CustomConfiguration
{
    internal class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            this.ToTable("Person", "Person");
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Family).IsRequired();
            this.Property(x => x.Mobile).IsRequired();
            this.Property(x => x.Mobile).IsUnicode(false);
            this.Ignore(x => x.Age);
            this.Ignore(x => x.PersianBirthDate);
            this.Ignore(x => x.Title);
            this.Ignore(x => x.FullName);
            this.HasIndex(x => x.Mobile).IsUnique();
            this.HasMany(x => x.LoanRequests).WithRequired(x => x.Person).WillCascadeOnDelete(false);
           
        }
    }
}
