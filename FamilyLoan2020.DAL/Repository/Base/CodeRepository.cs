using FamilyLoan2020.Models.Abstract;
using FamilyLoan2020.Models.Contract;
using System;

namespace FamilyLoan2020.DAL.Repository
{
    /// <summary>
    /// کلاس پایه برای متد های وابسته به کد 
    /// </summary>
    public abstract class CodeRepository<T> : Repository<T> , ICodeRepository<T>  where T : BaseEntityCode
    {
        public CodeRepository(FamilyLoan2020Context context) :base(context)
        {
           
        }


        public T GetByCode(byte code)
        {
            return LoanSet.Find(code);
        }

        public void DeleteByCode(byte code)
        {
            var obj = GetByCode(code);

            if (obj == null)
            {
                throw new ArgumentNullException("");
            }

            Delete(obj);
        }
    }

}
