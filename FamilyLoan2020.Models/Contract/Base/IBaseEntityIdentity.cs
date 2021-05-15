using System;

namespace FamilyLoan2020.Models.Contract
{
    public interface IBaseEntityIdentity
    {
        /// <summary>
        /// شناسه موجودیت
        /// </summary>
        int ID { get; set; }
    }
}

