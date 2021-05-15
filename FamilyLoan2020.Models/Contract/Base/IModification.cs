
using System;

namespace FamilyLoan2020.Models.Contract
{
    public interface IModification
    {
        /// <summary>
        /// تاریخ ایجاد
        /// </summary>
        DateTime CreatededDateTime { get; set; }
        /// <summary>
        /// تاریخ آپدیت
        /// </summary>
        DateTime ModifiedDateTime { get; set; }
        /// <summary>
        /// آیا حذف منطقی شده است
        /// </summary>
        bool IsDeleted { get; set; }
        /// <summary>
        /// آیا تغییر کرده است
        /// </summary>
        bool IsDirty { get; set; }
    }
}
