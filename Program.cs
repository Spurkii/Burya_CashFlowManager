using System;
// Mark Burya
// IT112 
// NOTES: An Assignment I thought would be easy turned into a bug hunt
// as I tried to figure out why errors were appearing and why my code wasn't working for the past week
// BEHAVIORS NOT IMPLEMENTED AND WHY: I believe I have completed everything that was asked of me
namespace Burya_CashFlowManager
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsRunning = true;
            string User_Input;

            IPayable[] Payable = new IPayable[40];

            Payable[0] = new Invoice("1111", "Kyber Krystal", 1, 100000M);
            Payable[1] = new Invoice("2222", "Super Kyber Krystal", 2, 999999.99M);
            Payable[2] = new Invoice("3333", "Lightsaber handle", 3, 999.99M);
            Payable[3] = new HourlyEmployee("Han", "Solo", 111111111, 19.92M, 2);
            Payable[4] = new HourlyEmployee("Mace", "Windu", 222222222, 21.23M, 80);
            Payable[5] = new HourlyEmployee("Kit", "fisto", 333333333, 18.05M, 39);
            Payable[6] = new SalariedEmployee("Anakin", "Skywalker", 444444444, 900M);
            Payable[7] = new SalariedEmployee("Obi-Wan", "Kenobi", 555555555, 100M);
            Payable[8] = new SalariedEmployee("Yoda", "???", 666666666, .50M);

            int a = 9;
            do
            {
                string First_Name;
                string Last_Name;
                int SSN;
                decimal Pay;
                int Hours_Worked;

                Console.Write("Please choose an option" +
                    "\n1: Add Salaried Employee" +
                    "\n2. Add Hourly Employee" +
                    "\n3. Add Invoice" +
                    "\n4. Print Report" +
                    "\n5. Exit\n");
                User_Input = Console.ReadLine();

                switch (User_Input)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Please enter the First Name: ");
                        First_Name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Please enter the Last Name: ");
                        Last_Name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Please enter the Social Security Number: ");
                        SSN = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Please enter the Weekly Salary: ");
                        Pay = decimal.Parse(Console.ReadLine());
                        Console.Clear();
                        Payable[a] = new SalariedEmployee(First_Name, Last_Name, SSN, Pay);
                        a++;
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Please enter the First Name: ");
                        First_Name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Please enter the Last Name: ");
                        Last_Name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Please enter the Social Security Number: ");
                        SSN = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Please enter the Hourly Salary: ");
                        Pay = decimal.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Please enter the hours worked this week: ");
                        Hours_Worked = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Payable[a] = new HourlyEmployee(First_Name, Last_Name, SSN, Pay, Hours_Worked);
                        a++;

                        break;

                    case "3":

                        string Part_Number;
                        string Part_Description;
                        int Quantity = 0;
                        decimal Price;

                        Console.Clear();
                        Console.WriteLine("Enter the PartNumber: ");
                        Part_Number = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter the Part Description: ");
                        Part_Description = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter the Quanity: ");
                        Quantity = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Enter the Price: ");
                        Price = decimal.Parse(Console.ReadLine());
                        Console.Clear();
                        Payable[a] = new Invoice(Part_Number, Part_Description, Quantity, Price);
                        a++;

                        break;

                    case "4":
                        decimal totalPayout = 0;
                        decimal invoiceTotal = 0;
                        decimal salariedTotal = 0;
                        decimal hourlyTotal = 0;

                        Console.Clear();
                        Console.WriteLine("Weekly Cash Flow Analysis is as follows:");

                        for (int i = 0; Payable[i] != null; i++)
                        {
                            Console.WriteLine("\n" + Payable[i].ToString());
                            totalPayout += Payable[i].GetPayableAmount();
                            if (Payable[i].GetLedgerType() == IPayable.LedgerType.Invoice)
                            {
                                invoiceTotal += Payable[i].GetPayableAmount();
                            }
                            else if (Payable[i].GetLedgerType() == IPayable.LedgerType.Salaried)
                            {
                                salariedTotal += Payable[i].GetPayableAmount();
                            }
                            else if (Payable[i].GetLedgerType() == IPayable.LedgerType.Hourly)
                            {
                                hourlyTotal += Payable[i].GetPayableAmount();
                            }
                        }
                       
                        Console.Write(
                        $"\nTotal Weekly Payout: {totalPayout.ToString("C")}" +
                        $"\nCategory Breakdown:" +
                        $"\nInvoices: {invoiceTotal.ToString("C")}" +
                        $"\nSalaried Payroll: {salariedTotal.ToString("C")}" +
                        $"\nHourly Payroll: {hourlyTotal.ToString("C")}" +
                        $"\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                        Console.Write("Program closed");
                        IsRunning = false;
                        break;

                    default:
                        Console.Clear();
                        Console.Write("ERROR\n");
                        break;
                }

            } while (IsRunning == true);
        }
    }
}
