using FamilyLoan2020.Models.Abstract;
using FamilyLoan2020.Models.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using FamilyLoan2020.DAL.ExtensionMethod;

namespace FamilyLoan2020.DAL.Repository
{
    /// <summary>
    /// کلاس پایه برای متد های مستقل از کد و آیدی
    /// </summary>
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// کانتکس پروژه تعریف شده در کلاس ریپازیتوری اصلی
        /// </summary>
        protected FamilyLoan2020Context LoanContext { get; set; }
        protected DbSet<T> LoanSet { get; set; }
        
        public Repository(FamilyLoan2020Context context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            LoanContext = context;
            LoanSet = LoanContext.Set<T>();
        }

        public virtual IQueryable<T> Get()
        {
            return LoanSet.WhereNotDeleted();
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return this.Get().Where(predicate);
        }

        public IEnumerable<T> Get(string query, params object[] parameters)
        {
            return LoanSet.SqlQuery(query, parameters).ToList();
        }

        public void Insert(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.CreatededDateTime = DateTime.Now;
            entity.ModifiedDateTime = DateTime.Now;

            LoanSet.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.ModifiedDateTime = DateTime.Now;
            LoanContext.Entry(entity).State = EntityState.Modified;      
        }

        public void Delete(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.IsDeleted = true;
            entity.ModifiedDateTime = DateTime.Now;
            LoanContext.Entry(entity).State = EntityState.Modified;
        }
    }

}
