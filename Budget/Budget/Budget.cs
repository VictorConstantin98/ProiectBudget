using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal class Budget
    {
        private List<Transaction> transactionsList;
        private string purpose;

        public Budget()
        {
            transactionsList = new List<Transaction>();
        }

        /*
         * Metoda de adaugat tranzactii(income)
         */
        public void AddIncome(Income income)
        {
            transactionsList.Add(income);
        }

        public void setPurpose(string purpose)
        {
            this.purpose = purpose;
        }

        /*
         * Metoda de adaugat tranzactii(expense)
         */
        public void AddExpense(Expense expense)
        {
            if(expense.getValue() < 0)
            {
               transactionsList.Add(expense);
            }
            else
            {
                expense.setValue(expense.getValue() * -1);
                transactionsList.Add(expense);
            }
            
        }

        /*
         * Metoda de calcul a soldului bugetului/vizualizare sold buget
         */
        public double BudgetSum()
        {
            double budgetSold = 0;
            foreach(Transaction element in transactionsList)
            {
                budgetSold = budgetSold + element.getValue();
            }
            return budgetSold;
        }

        /*
         * Metoda de stergere a tranzactiilor in functie de nume/index
         */
        public void ClearTranzactionByName(string name)
        {
            int elementIndex = 0;
            foreach(Transaction element in transactionsList)
            {
                if(name == element.getName())
                {
                    elementIndex = transactionsList.IndexOf(element);
                    transactionsList.RemoveAt(elementIndex);
                    break;

                    
                }
            }
        }
        /*
         * Sort the Transactions based on value
         * 
         */

        public void sortTransactions()
        {
            this.transactionsList.Sort();
        }

        /*
         * 
         */

        public override string ToString()
        {
            string denumireString = "";
            denumireString = denumireString + "Budget" + "\n";
            foreach (Transaction element in transactionsList)
            {
                denumireString = denumireString + element.ToString();
            }
            denumireString = denumireString + "\n" + "Budget purpose: " + purpose;
            return denumireString;
        }
    }
}
