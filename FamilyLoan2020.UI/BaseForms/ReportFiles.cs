using System.IO;

namespace FamilyLoan2020.UI.BaseForms
{
    public static class ReportFiles
    {
        private static string ReportDirectory
        {
            get
            {
                return System.IO.Path.Combine(FormTools.ExeDirectory, "MRTFiles");
            }
        }

        private static string PersonReport { get { return "PersonReport.mrt"; } }
        private static string PersonLoanReport { get { return "LoanReport.mrt"; } }
        private static string PersonAggregateLoanReport { get { return "PersonAggregateLoanReport.mrt"; } }

        private static string PersonAggregateLoanWithSumReport { get { return "PersonAggregateLoanWithSumReport.mrt"; } }



        /// <summary>
        /// گزارش لیست اشخاص
        /// </summary>
        public static string Person { get { return Path.Combine(ReportDirectory, PersonReport); } }

        /// <summary>
        /// گزارش لیست اشخاص و اطلاعات وام
        /// </summary>
        public static string PersonLoan { get { return Path.Combine(ReportDirectory, PersonLoanReport); } }

        /// <summary>
        /// گزارش تجمعی وام اشخاص
        /// </summary>
        public static string PersonAggregateLoan { get { return Path.Combine(ReportDirectory, PersonAggregateLoanReport); } }

        public static string PersonAggregateLoanWithSum { get { return Path.Combine(ReportDirectory, PersonAggregateLoanWithSumReport); } }

    }

}
