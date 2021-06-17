using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_CashFlowManager
{
    class SalariedEmployee : Employee
    {
        private decimal _Salary_Pay;


        protected decimal Salary_Pay
        {
            get { return _Salary_Pay; }
        }

        public SalariedEmployee(string First_Name, string Last_Name, int SSN, decimal Salary_Pay) : base(First_Name, Last_Name, SSN)
        {
            _Salary_Pay = Salary_Pay;
        }
        public override decimal Earnings()
        {
            return Salary_Pay;
        }
        public override IPayable.LedgerType GetLedgerType()
        {
            return IPayable.LedgerType.Salaried;
        }

        public override string ToString()
        {
            return
                $"Salaried employee: {First_Name} {Last_Name} " +
                $"\nSSN: {string.Format("{0:###-##-####}", SSN)}" +
                $"\nWeekly Salary: {Salary_Pay.ToString("C")}" +
                $"\nEarned: {Salary_Pay.ToString("C")}";

        }
    }
}
