using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Sadr_Tools.ExtensionMethods;


namespace FamilyLoan2020.UI.BaseForms
{
    public partial class BaseFrm : Form, IBaseFormProperty 
    {
        public string HeaderText { get; set; } = "صندوق قرض الحسنه امداد";
        public Color HeaderColor { get; set; } = Color.PowderBlue;
        public Image HeaderImage { get; set; } = UI.Properties.Resources.bg;

        public BaseFrm()
        {
            InitializeComponent();
        }

        private void BaseFrm_Load(object sender, System.EventArgs e)
        {
            if (!DesignMode)
            {
                HeaderLabel.Text = HeaderText;
                HeaderPanel.BackColor = HeaderColor;
                HeaderPicBox.Image = HeaderImage;
                this.Text = HeaderText;
                ToolStripStatusLblDate.Text = DateTime.Now.ToPersianTextFull();
                ToolStripStatusLblTime.Text = Sadr_Tools.Utility.DateMethods.Hour("hh:mm");
                ToolStripStatusLblUsername.Text = Sadr_Tools.CommonConsts.Application.LoginName;

            }
        }

        private void TimerDisplayTime_Tick(object sender, EventArgs e)
        {
            if (!DesignMode)
                ToolStripStatusLblTime.Text = Sadr_Tools.Utility.DateMethods.Hour("hh:mm");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
