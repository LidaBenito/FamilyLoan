using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FamilyLoan2020.DAL.CustomConvention
{
    internal class CodeConvention : Convention
    {
        public CodeConvention()
        {
            this.Properties().Where(p => p.Name.Length == 4 && p.Name.Equals("Code")).
              Configure(c =>
              {
                  c.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
              });
        }
    }
}

