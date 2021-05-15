using FamilyLoan2020.Models.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyLoan2020.Models.Abstract
{
    public abstract class BaseEntity : IModification
    {
        public DateTime CreatededDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDirty { get; set; }

        /// <summary>
        /// آیا آبجکت مورد نظر معتبر میباشد؟
        /// </summary>
        public abstract bool IsValid();

        /// <summary>
        /// لیست هدر پراپرتی ها
        /// </summary> 

        [NotMapped]
        public List<PropertyHeader> PropertyHeaderList { get; set; }
    }
}

