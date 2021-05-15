using FamilyLoan2020.DAL.CustomConfiguration;
using FamilyLoan2020.DAL.CustomConvention;
using FamilyLoan2020.DAL.CustomDatabaseInitializer;
using FamilyLoan2020.Models.Contract;
using FamilyLoan2020.Models.Entity;
using Sadr_Tools.Utility;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace FamilyLoan2020.DAL
{
    public class FamilyLoan2020Context : DbContext
    {
        //public FamilyLoan2020Context() : base()
        //{

//#if DEBUG
//            Database.Log = s => StringMethods.LogDatabaseActivity(s);
//#endif
//        }
        static FamilyLoan2020Context()
        {
            Database.SetInitializer(new FamilyLoanContextInitializer());
        }
        public virtual DbSet<Bank> Banks{ get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<LoanItem> LoanItems { get; set; }
        public virtual DbSet<LoanRequest> LoanRequests { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new IDConvention());
            modelBuilder.Conventions.Add(new CodeConvention());
            modelBuilder.Conventions.Add(new MaxStringConvention());
            modelBuilder.Conventions.Add(new DateTimeConvention());

            modelBuilder.Configurations.Add(new SettingConfig());
            modelBuilder.Configurations.Add(new LoanConfig());
            modelBuilder.Configurations.Add(new LoanItemConfig());
            modelBuilder.Configurations.Add(new LoanRequestConfig());
            modelBuilder.Configurations.Add(new PaymentConfig());
            modelBuilder.Configurations.Add(new PaymentTypeConfig());
            modelBuilder.Configurations.Add(new PersonConfig());
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new PasswordHistoryConfig());
            modelBuilder.Configurations.Add(new BankConfig());

            base.OnModelCreating(modelBuilder);
        }

        #region [ Refactor ]

        public override int SaveChanges()
        {
            try
            {





                int result = base.SaveChanges();

                IEnumerable<IModification> histories = ChangeTracker.Entries()
                                         .Where(e => e.Entity is IModification)
                                         .Select(e => e.Entity as IModification);

                foreach (IModification item in histories)
                {
                    item.IsDirty = false;
                }

                return result;
            }
            catch (DbEntityValidationException e)
            {
                string s = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    s += $"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:";
                    foreach (var ve in eve.ValidationErrors)
                    {
                        s += $"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"";
                    }
                }



                throw;
            }

            #endregion




        }
    }
}
