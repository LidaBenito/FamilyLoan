using System.Data.Entity.ModelConfiguration.Conventions;

namespace FamilyLoan2020.DAL.CustomConvention
{
    internal class MaxStringConvention : Convention
    {
        public MaxStringConvention()
        {
            Properties<string>().Configure(p => p.HasMaxLength(50));
        }
    }
}
