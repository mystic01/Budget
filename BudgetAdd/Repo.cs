using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetAdd
{
    internal class Repo : IRepo
    {
        public void Add(Budget budget)
        {
            using (var dbcontext = new BudgetEntities())
            {
                var budgetDB = dbcontext.Budgets.SingleOrDefault(x => x.YearMonth == budget.Month);
                if (budgetDB == null)
                {
                    var budgets = new Budgets {Amount = Decimal.Parse(budget.Amount), YearMonth = budget.Month};
                    dbcontext.Budgets.Add(budgets);
                }
                else
                {
                    budgetDB.Amount = Decimal.Parse(budget.Amount);
                }

                dbcontext.SaveChanges();
            }
        }

        public ICollection<Budget> GetAllBudgets()
        {
            List<Budget> budgets = new List<Budget>();
            using (var dbcontext = new BudgetEntities())
            {
                var allBudgets = dbcontext.Budgets.ToList();
                foreach (var budget in allBudgets)
                {
                    budgets.Add(new Budget(budget.YearMonth, budget.Amount.ToString()));
                }
            }

            return budgets;
        }
    }
}