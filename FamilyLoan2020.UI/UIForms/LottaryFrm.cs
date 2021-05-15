using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.DTO;
using FamilyLoan2020.Models.Entity;
using FamilyLoan2020.UI.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class LottaryFrm : BaseFrm
    {
        UnitOfWork uow = null;
        Person MainObject = null;




        public LottaryFrm()
        {
            InitializeComponent();
        }


        private void LottaryFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new Person();
            

        }

      
        private void BtnLottary_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<Person> list = uow.PersonRepository.Get().ToList();
            Random random = new Random();
            i = random.Next(list.Count);
            var result = uow.PersonRepository.Get().Where(c => c.ID == i).SingleOrDefault();
            lblName.Text = result.FullName;
        }
    }
}
