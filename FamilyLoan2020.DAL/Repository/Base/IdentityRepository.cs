using FamilyLoan2020.Models.Abstract;
using FamilyLoan2020.Models.Contract;
using System;

namespace FamilyLoan2020.DAL.Repository
{
    /// <summary>
    /// کلاس پایه برای متد های وابسته به آیدی
    /// </summary>
    public abstract class IdentityRepository<T> : Repository<T>, IIdentityRepository<T> where T : BaseEntityIdentity
    {
        public IdentityRepository(FamilyLoan2020Context context) : base(context)
        {

        }


        public T GetByID(int id)
        {
            return LoanSet.Find(id);
        }

        public void DeleteByID(int id)
        {
            var obj = GetByID(id);

            if (obj == null)
            {
                throw new ArgumentNullException("");
            }

            Delete(obj);

        }

    }

}
