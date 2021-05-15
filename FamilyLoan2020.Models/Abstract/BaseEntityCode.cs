using FamilyLoan2020.Models.Contract;
using System;
namespace FamilyLoan2020.Models.Abstract
{
    /// <summary>
    /// کلاس پایه برای موجودیت های دارای کد
    /// </summary>
    public abstract class BaseEntityCode : BaseEntity, IBaseEntityCode
    {
        public byte Code { get; set; }
    }
}

