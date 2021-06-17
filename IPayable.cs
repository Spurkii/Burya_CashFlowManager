using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_CashFlowManager
{
    interface IPayable
    {
        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }
        LedgerType GetLedgerType();
        decimal GetPayableAmount();
    }
}
