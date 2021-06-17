using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_CashFlowManager
{
    class Employee : IPayable
    {
        private string _First_Name;
        private string _Last_Name;
        private int _SSN;
        protected Employee(string First_Name, string Last_Name, int SSN)
        {
            _First_Name = First_Name;
            _Last_Name = Last_Name;
            _SSN = SSN;
        }

        protected string First_Name
        {
            get { return _First_Name; }
        }

        protected string Last_Name
        {
            get { return _Last_Name; }
        }

        protected int SSN
        {
            get { return _SSN; }
        }
        public virtual decimal Earnings()
        {
            throw new System.NotImplementedException();
        }

        public virtual IPayable.LedgerType GetLedgerType()
        {
            throw new System.NotImplementedException();
        }
        public decimal GetPayableAmount()
        {
            return Earnings();
        }
    }
}
