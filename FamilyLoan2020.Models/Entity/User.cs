using FamilyLoan2020.Models.Abstract;
using Sadr_Tools.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLoan2020.Models.Entity
{
    public class User : BaseEntityIdentity
    {
        public User()
        {
            PasswordHistories = new HashSet<PasswordHistory>();
            PropertyHeaderList = new List<PropertyHeader>() 
            {
            new PropertyHeader("ID","شناسه"),
            new PropertyHeader("Person","شخص"),
            new PropertyHeader("UserName","نام کاربری"),
            new PropertyHeader("IsActiveTitle","وضعیت کاربر")
            };
        }
        /// <summary>
        /// نام کاربری
        /// </summary>
        public string UserName{ get; set; }

        /// <summary>
        /// وضعیت فعال بودن کاربر
        /// </summary>
        public bool IsActive{ get; set; }
        /// <summary>
        /// شخص
        /// </summary>
        public virtual  Person Person { get; set; }
        /// <summary>
        /// لیست پسوردهای هر شخص
        /// </summary>
        public virtual ICollection<PasswordHistory> PasswordHistories{ get;}
        
        public string IsActiveTitle
        {
            get
            {
                return IsActive ?"فعال":"غیر فعال";

            }
                
                }

        public override bool IsValid()
        {
            return !UserName.IsNullOrEmpty();
        }
        public override string ToString()
        {
            return UserName;
        }
    }
}
