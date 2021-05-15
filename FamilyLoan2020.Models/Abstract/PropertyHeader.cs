using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyLoan2020.Models.Abstract
{
    /// <summary>
    /// خصوصیات موجودیت ها
    /// </summary>
    [NotMapped]
    public class PropertyHeader
    {
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// عنوان هدر
        /// </summary>
        public string HeaderText { get; set; }

        /// <summary>
        /// جدا کننده سه رقمی
        /// </summary>
        public bool ApplyThousandSeprator { get; set; }

        /// <summary>
        /// عرض ستون در گرید
        /// </summary>
        public short ColWidth { get; set; } 
        public bool IsImage{ get; set; }

        public PropertyHeader(string name, string headerText , bool applyThousandSeprator = false , short colWidth = 100,bool isImage=false)
        {
            Name = name;
            HeaderText = headerText;
            ApplyThousandSeprator = applyThousandSeprator;
            ColWidth = colWidth;
            IsImage = isImage;
        }

        public override string ToString()
        {
            return HeaderText;
        }
    }
}
