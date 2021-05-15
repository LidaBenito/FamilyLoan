using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FamilyLoan2020.DAL.CustomConvention
{
    class DateTimeConvention : Convention
    {
        public DateTimeConvention()
        {
            this.Properties<DateTime>().Where(p => p.Name.ToLower().EndsWith("datetime")).
             Configure(c =>
             {
                 c.HasColumnType("datetime");
             });

            this.Properties<DateTime>().Where(p => p.Name.ToLower().EndsWith("date")).
            Configure(c =>
            {
                c.HasColumnType("date");
            });
        }
    }
}

