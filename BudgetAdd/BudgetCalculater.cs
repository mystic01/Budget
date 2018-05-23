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
        private readonly ICollection<Budget> _budgetsLookup;
        private readonly DateTime _endDate;
        private readonly DateTime _startDate;

        public BudgetCalculater(IRepo repo, DateTime startDate, DateTime endDate)
        {
            _budgetsLookup = repo.GetAllBudgets();
            _startDate = startDate;
            _endDate = endDate;
        }

        public int GetBudget()
        {
            if (IsErrorDate())
                return 0;

            var toalBudget = CalculateFirstMonthBudget();
            toalBudget += CalculateMiddleMonthBudget();

            if (!IsTheSameMonth(_startDate, _endDate))
                toalBudget += CalculateLastMonthBudget();

            return (int)toalBudget;
        }

        private float CalculateFirstMonthBudget()
        {
            var daysInMonth = DateTime.DaysInMonth(_startDate.Year, _startDate.Month);
            var days = GetFirstMonthDays(daysInMonth);
            var oneDayBudget = GetMonthBudgetInRepo(_startDate) / daysInMonth;
            return oneDayBudget * days;
        }

        private float CalculateLastMonthBudget()
        {
            var daysInMonth = DateTime.DaysInMonth(_endDate.Year, _endDate.Month);
            var days = _endDate.Day;
            var oneDayBudget = GetMonthBudgetInRepo(_endDate) / daysInMonth;
            return oneDayBudget * days;
        }

        private float CalculateMiddleMonthBudget()
        {
            float summary = 0;
            var iMonth = _startDate.AddMonths(1);
            while (IsDateMonth1BeforeDateMonth2(iMonth, _endDate))
            {
                summary += GetMonthBudgetInRepo(iMonth);
                iMonth = iMonth.AddMonths(1);
            }
            return summary;
        }

        private int GetFirstMonthDays(int daysInMonth)
        {
            var days = daysInMonth - _startDate.Day + 1;
            if (IsTheSameMonth(_startDate, _endDate))
                days = _endDate.Day - _startDate.Day + 1;
            return days;
        }

        private float GetMonthBudgetInRepo(DateTime date)
        {
            var monthText = date.Year + "-" + date.Month.ToString("d2");
            var budget = _budgetsLookup.FirstOrDefault(x => x.Month == monthText);
            if (budget == null)
                return 0;
            return Int32.Parse(budget.Amount);
        }

        private bool IsDateMonth1BeforeDateMonth2(DateTime month1, DateTime month2)
        {
            return month1.Year < month2.Year
                   || (month1.Year == month2.Year && month1.Month < month2.Month);
        }

        private bool IsErrorDate()
        {
            return _startDate > _endDate;
        }

        private bool IsTheSameMonth(DateTime date1, DateTime date2)
        {
            return date1.Year == date2.Year && date1.Month == date2.Month;
        }
    }
}
