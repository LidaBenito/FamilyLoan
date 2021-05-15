using System.Drawing;


namespace FamilyLoan2020.UI.BaseForms
{
    public interface IBaseFormProperty
    {
        string HeaderText { get; set; }
        Color HeaderColor { get; set; }
        Image HeaderImage { get; set; }
    }
}

