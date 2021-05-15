using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.UI.BaseForms;
using System;
using System.Linq;
//using Stimulsoft.Report;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.Utility;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class ReportHomeFrm : BaseFrm
    {
//        public ReportHomeFrm()
//        {
//            InitializeComponent();
//        }
//        UnitOfWork uow = null;

//        private void ReportHomeFrm_Load(object sender, EventArgs e)
//        {
//            uow = new UnitOfWork();
//        }

//        private void ToolStripBtnPeople_Click(object sender, EventArgs e)
//        {
//            var people = uow.PersonRepository.Get().ToList();
//            stiReport1.Load(ReportFiles.Person);
//            stiReport1.RegBusinessObject("PersonCat", "Person", people);
//            stiReport1.Dictionary.Variables["ReportDate"].Value = DateTime.Now.ToPersianDate();
//            stiReport1.Dictionary.Variables["ReportPersonName"].Value = Sadr_Tools.CommonConsts.Application.PersonName;
//            stiReport1.Show(this, true);
//        }

//        private void ToolStripBtnLoans_Click(object sender, EventArgs e)
//        {
//            var list = uow.LoanRepository.GetPersonWithLoanInformation();
//            using (var report = new StiReport())
//            {
//                report.Load(ReportFiles.PersonLoan);
//                report.RegBusinessObject("PersonLoanCat", "PersonLoan", list);
//                report.Dictionary.Variables["ReportDate"].Value = DateTime.Now.ToPersianDate();
//                report.Dictionary.Variables["ReportPersonName"].Value = Sadr_Tools.CommonConsts.Application.PersonName;
//                report.Show(this, true);
//            }
//        }

//        private void ToolStripBtnTotall_Click(object sender, EventArgs e)
//        {
//            var list = uow.LoanRepository.GetPersonWithAggregateLoanInformation();
//            using (var report = new StiReport())
//            {
//                report.Load(ReportFiles.PersonAggregateLoan);
//                report.RegBusinessObject("PersonLoanAggregateCat", "PersonLoanAggregate", list);
//                report.Dictionary.Variables["ReportDate"].Value = DateTime.Now.ToPersianDate();
//                report.Dictionary.Variables["ReportPersonName"].Value = Sadr_Tools.CommonConsts.Application.PersonName;
//                report.Show(this, true);
//            }

//            FarsiBox.ShowInformation("نمایش حالت دوم");

//            using (var report = new StiReport())
//            {
//                report.Load(ReportFiles.PersonAggregateLoanWithSum);
//                report.RegBusinessObject("PersonLoanAggregateCat", "PersonLoanAggregate", list);
//                report.Dictionary.Variables["ReportDate"].Value = DateTime.Now.ToPersianDate();
//                report.Dictionary.Variables["ReportPersonName"].Value = Sadr_Tools.CommonConsts.Application.PersonName;
//                report.Show(this, true);
//            }


//        }
    }
}
