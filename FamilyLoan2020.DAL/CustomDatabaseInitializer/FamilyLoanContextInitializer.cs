using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.Entity;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.Utility;
using System;
using System.Data.Entity;

namespace FamilyLoan2020.DAL.CustomDatabaseInitializer
{
   public class FamilyLoanContextInitializer: CreateDatabaseIfNotExists<FamilyLoan2020Context>
    {
        protected override void Seed(FamilyLoan2020Context context)
        {
            #region [ Insert Initial Records to DB ]
            UnitOfWork uow = new UnitOfWork();
            uow.PaymentTypeRepository.Insert(new PaymentType()
            {
                Code = 1,
                Title = "حق عضویت",
            });

            uow.PaymentTypeRepository.Insert(new PaymentType()
            {
                Code = 2,
                 Title = "وام",
            });

            uow.PaymentTypeRepository.Insert(new PaymentType()
            {
                Code = 3,
                Title = "کارمزد",
            });

            uow.PaymentTypeRepository.Insert(new PaymentType()
            {
                Code = 4,
                Title = "قسط",
            });


            uow.PaymentTypeRepository.Insert(new PaymentType()
            {
                Code = 5,
                Title = "بانک",
            });

          
            #endregion

            base.Seed(context);
        }
    }
}

