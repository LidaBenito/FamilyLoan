using System.Windows.Forms;

namespace ParsiTextBox_Control
{

    /// <summary>
    /// زبان کیبرد
    /// </summary>
    public enum EnKeyBoardLanguage
    {
        Persian,
        English
    }


    /// <summary>
    /// کلاسی برای تنظیمان زبان کیبرد
    /// </summary>
    public static class KeyBoardLanguageSetting
    {
        public static void SetParsi()
        {
            foreach (InputLanguage lan in InputLanguage.InstalledInputLanguages)
                if (lan.Culture.Name == "fa-IR")
                    InputLanguage.CurrentInputLanguage = lan;
        }

        public static void SetEnglish()
        {
            foreach (InputLanguage lan in InputLanguage.InstalledInputLanguages)
                if (lan.Culture.Name == "en-US")
                    InputLanguage.CurrentInputLanguage = lan;
        }
    }
}
