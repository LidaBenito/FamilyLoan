using FamilyLoan2020.Models.Contract;
using System;
namespace FamilyLoan2020.Models.Abstract
{
    /// <summary>
    /// کلاس پایه برای موجودیت های دارای آیدی
    /// </summary>
    public abstract class BaseEntityIdentity : BaseEntity, IBaseEntityIdentity
    {
        public int ID { get; set; }
    }
}

