using FamilyLoan2020.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace FamilyLoan2020.Models.Contract
{
    /// <summary>
    /// متد های مستقل از کد و آیدی
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T: BaseEntity
    {
        /// <summary>
        /// افزودن موجودیت
        /// </summary>
        void Insert(T entity);

        /// <summary>
        /// آپدیت موجودیت
        /// </summary>
        void Update(T entity);

        /// <summary>
        /// حذف موجودیت
        /// </summary>
        void Delete(T entity);

        /// <summary>
        ///   واکشی اطلاعات حذف نشده
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Get();

        /// <summary>
        /// واکشی اطلاعات با گزاره
        /// </summary>
        /// <param name="predicate">گزاره</param>
        IQueryable<T> Get(Expression<Func<T,bool>> predicate);

        /// <summary>
        /// واکشی اطلاعات با دستورات اس کیو ال
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IEnumerable<T> Get(string query, params object[] parameters);
    }
}
