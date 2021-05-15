using FamilyLoan2020.Models.Contract;
using System.Linq;

namespace FamilyLoan2020.DAL.ExtensionMethod
{
    public static class IQueryExt
    {
        /// <summary>
        /// رکورد های حذف شده نمایش داده نشوند
        /// </summary>                                                            /* Type Constraint */
        public static IQueryable<T> WhereNotDeleted<T>(this IQueryable<T> source) where T : class , IModification
        {
            //LINQ to Entities only supports casting EDM primitive or enumeration types
            return source.Where(x=>!x.IsDeleted);
        }
    }
}

