using System;

namespace Budget
{
    class Program
    {
        static void Main (string[] args)
        {
            Budget buget1 = new Budget();
            Income income1 = new Income("Salary", 300.50, "Salary January");
            buget1.AddIncome(income1);
            string purpose = "Evidence January";
            buget1.setPurpose(purpose);
            Expense expense1 = new Expense("Bills", 250.35, "Bills January");
            buget1.AddExpense(expense1);

            Console.WriteLine("Adaugare doua tranzactii.");
            Console.WriteLine("-------------------------");

            Console.WriteLine(buget1.ToString());
            double budgetSum = buget1.BudgetSum();

            Console.WriteLine("\n");
            Console.WriteLine("Afisam soldul bugetului.");
            Console.WriteLine("------------------------");

            Console.WriteLine(budgetSum);
            Income income2 = new Income("Gifts", 450, "Gifts January");
            Expense expense2 = new Expense("Car service", 1000, "Car service January");
            buget1.AddIncome(income2);
            buget1.AddExpense(expense2);

            Console.WriteLine("\n");
            Console.WriteLine("Adaugare inca doua tranzactii.");
            Console.WriteLine("------------------------------");

            Console.WriteLine(buget1);
            buget1.ClearTranzactionByName("Car service January");

            Console.WriteLine("\n");
            Console.WriteLine("Stergere Car service January");
            Console.WriteLine("----------------------------");
            Console.WriteLine(buget1);






            Console.WriteLine("\n");
            Budget buget2 = new Budget();
            /*Expense expense1 = new Expense("Bills", 250.35, "Bills January");*/
            buget2.AddExpense(expense1);
            string purpose2 = "Expense Evidence January";
            buget2.setPurpose(purpose2);
            Console.WriteLine(buget2.ToString());

            Console.WriteLine("\n");    
            List<Transaction> transactionsList = new List<Transaction>();
            transactionsList.Add(income1);
            transactionsList.Add(expense1);
            Console.WriteLine(transactionsList.Count);

            

            //De adaugat un expense
            //Sa vizualizam lista de tranzactii
        }
    }
}
