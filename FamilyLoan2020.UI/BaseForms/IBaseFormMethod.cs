namespace FamilyLoan2020.UI.BaseForms
{
    public interface IBaseFormMethod
    {
        /// <summary>
        /// تغییر وضعیت کنترل های روی فرم
        /// </summary>
        /// <param name="isEnabled">فعال شود؟</param>
        void EnableControlStatus(bool isEnabled = true);


        /// <summary>
        /// پاک کردن محتویات کنترل ها
        /// </summary>
        void ClearControlContent();

        /// <summary>
        /// بررسی اطلاعات وارد شده
        /// </summary>
        bool CheckInputData();
    }
}
