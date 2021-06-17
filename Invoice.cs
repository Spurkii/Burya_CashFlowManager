using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_CashFlowManager
{
    class Invoice : IPayable
    {
        private string _Part_Number;
        private int _Quantity;
        private string _Part_Description;
        private decimal _Price;
        private int _Invoice_Number;

        protected string Part_Number
        {
            get { return _Part_Number; }
        }

        protected int Quantity
        {
            get { return _Quantity; }
        }

        protected string Part_Description
        {
            get { return _Part_Description; }
        }

        protected decimal Price
        {
            get { return _Price; }
        }
        public Invoice(string Part_Number, string Part_Description, int Quantity, decimal Price)
        {
            _Part_Number = Part_Number;
            _Part_Description = Part_Description;
            _Quantity = Quantity;
            _Price = Price;
            _Invoice_Number = Invoice_Number();
        }
        private int Invoice_Number()
        {
            Random random = new Random();
            return random.Next(000001, 999999);
        }

        public decimal GetPayableAmount()
        {
            return Price * Quantity;
        }

        public IPayable.LedgerType GetLedgerType()
        {
            return IPayable.LedgerType.Invoice;
        }

        public override string ToString()
        {
            return
                $"Invoice: {Invoice_Number()}_{Part_Number}" +
                $"\nQuantity: {Quantity}" +
                $"\nPart Description: {Part_Description}" +
                $"\nUnit Price: {Price.ToString("C")}" +
                $"\nExtended Price: {GetPayableAmount().ToString("C")}";
        }
    }
}   
