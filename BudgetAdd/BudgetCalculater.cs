using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = System.DateTime;

namespace BudgetAdd
{
    internal class BudgetCalculater
    {
        private readonly IRepo _repo;
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;

        public BudgetCalculater(IRepo repo, DateTime startDate, DateTime endDate)
        {
            _repo = repo;
            _startDate = startDate;
            _endDate = endDate;
        }

        public int GetBudget()
        {
            var budgets = _repo.GetAllBudgets();
            if (_startDate > _endDate)
                return 0;

            int summary = 0;
            summary += CalculateMiddleMonthBudget(budgets);
            summary += CalculateFirstMonthBudget(budgets);

            if (!IsTheSameMonth())
                summary += CalculateLastMonthBudget(budgets);

            return summary;
        }

        private int CalculateMiddleMonthBudget(ICollection<Budget> budgets)
        {
            var summary = 0;
            DateTime target = _startDate.AddMonths(1);
            while (target.Year <= _endDate.Year && target.Month < _endDate.Month)
            {
                var targetMonthText = target.Year + "-" + target.Month.ToString("d2");
                var targetBudget = budgets.FirstOrDefault(x => x.Month == targetMonthText);
                if (targetBudget != null)
                {
                    summary += Int32.Parse(targetBudget.Amount);
                }

                target = target.AddMonths(1);
            }

            return summary;
        }

        private bool IsTheSameMonth()
        {
            return _startDate.Year == _endDate.Year && _startDate.Month == _endDate.Month;
        }

        private int CalculateLastMonthBudget(ICollection<Budget> budgets)
        {
            var summary = 0;
            var endMonthText = _endDate.Year + "-" + _endDate.Month.ToString("d2");
            var endBudget = budgets.FirstOrDefault(x => x.Month == endMonthText);
            if (endBudget != null)
            {
                var daysInMonth = DateTime.DaysInMonth(_endDate.Year, _endDate.Month);
                var oneDayBudget = Int32.Parse(endBudget.Amount) / daysInMonth;
                var days = _endDate.Day;
                summary += oneDayBudget * days;
            }

            return summary;
        }

        private int CalculateFirstMonthBudget(ICollection<Budget> budgets)
        {
            var summary = 0;
            var firstMonthText = _startDate.Year + "-" + _startDate.Month.ToString("d2");
            var firstBudget = budgets.FirstOrDefault(x => x.Month == firstMonthText);
            if (firstBudget != null)
            {
                var daysInMonth = DateTime.DaysInMonth(_startDate.Year, _startDate.Month);
                var oneDayBudget = Int32.Parse(firstBudget.Amount) / daysInMonth;
                if (_startDate.Year == _endDate.Year && _startDate.Month == _endDate.Month)
                    daysInMonth = _endDate.Day;

                var days = daysInMonth - _startDate.Day + 1;
                summary += oneDayBudget * days;
            }

            return summary;
        }
    }
}
