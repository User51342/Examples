using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var william = new ExpenseHandler(new Employee("William Worker", 0m));
            var kate = new ExpenseHandler(new Employee("Kate Manager", 1000m));
            var victor = new ExpenseHandler(new Employee("Victor Vicepresident", 5000m));
            var paula = new ExpenseHandler(new Employee("Paula President", 20000));

            william.RegisterNext(kate);
            kate.RegisterNext(victor);
            victor.RegisterNext(paula);

            Decimal expenseReportAmount;
            Console.Write("Expense report amount:");
            if(Decimal.TryParse(Console.ReadLine(),out expenseReportAmount))
            {
                var expenseReport = new ExpenseReport(expenseReportAmount);
                var response = william.Approve(expenseReport);
                Console.WriteLine(response);
                Console.ReadLine();
            }
        }
    }
}
