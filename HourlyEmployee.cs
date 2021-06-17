using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_CashFlowManager
{
    class HourlyEmployee : Employee
    {
        private decimal _Hourly_Pay;
        private int _Hours_Worked;

        protected decimal Hourly_Pay
        {
            get { return _Hourly_Pay; }
        }

        protected int Hours_Worked
        {
            get { return _Hours_Worked; }
        }
        public HourlyEmployee(string First_Name, string Last_Name, int SSN,
            decimal Hourly_Pay, int Hours_Worked) : base(First_Name, Last_Name, SSN)
        {
            _Hourly_Pay = Hourly_Pay;
            _Hours_Worked = Hours_Worked;
        }

        public override decimal Earnings()
        {
            if (Hours_Worked > 40)
            {
                decimal earnings = Hourly_Pay * 40;
                int Over_Time = Hours_Worked - 40;
                return earnings += Over_Time * (Hourly_Pay * 1.5M);
            }
            else
            {
                return Hours_Worked * Hourly_Pay;
            }
        }
        public override IPayable.LedgerType GetLedgerType()
        {
            return IPayable.LedgerType.Hourly;
        }
        public override string ToString()
        {
            return
                $"Salaried employee: {First_Name} {Last_Name} " +
                $"\nSSN: {string.Format("{0:###-##-####}", SSN)}" +
                $"\nHourly Wage Salary: {Hourly_Pay.ToString("C")}" +
                $"\nHours Worked: {Hours_Worked}" +
                $"\nEarned: {Earnings().ToString("C")}";
        }
    }
}
