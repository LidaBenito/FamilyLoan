using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLoan2020.Models.DTO
{ /// <summary>
  /// مدلی برای گزارش اشخاص و وام ها
  /// </summary>
    public class PersonLoanDTO
    {
        public string PersonFullName { get; set; }
        public byte LoanCode { get; set; }
        public string PersianLoanDate { get; set; }
        public string PersianLastInstallmentDate { get; set; }
        public int Amount { get; set; }
        public string LoanStatus { get; set; }

    }
}
