using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FamilyLoan2020.DAL.CustomConvention
{
    internal class IDConvention : Convention
    {
        public IDConvention()
        {
            this.Properties().Where(p => p.Name.Length == 2 && p.Name.Equals("ID")).
            Configure(c =>
            {
                c.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            });
        }
    }
}

