using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BudgetAdd.Tests
{
    [TestClass()]
    public class BudgetCalculaterTests
    {
        private IRepo _repoStub;

        [TestMethod()]
        public void GetBudgetTest_20160115_20160213_251()
        {
            CreateRepoStub("2016-02 560");
            Assert.AreEqual(251, GetBudget("2016-01-15", "2016-02-13"));
        }

        [TestMethod()]
        public void GetBudgetTest_20160201_20180430_1160()
        {
            CreateRepoStub("2016-02 560", "2016-02 560", "2018-04 600",
                "2018-05 620", "2018-07 620", "2019-02 990");
            Assert.AreEqual(1160, GetBudget("2016-02-01", "2018-04-30"));
        }

        [TestMethod()]
        public void GetBudgetTest_20160215_20160213_0()
        {
            CreateRepoStub("2016-02 560");
            Assert.AreEqual(0, GetBudget("2016-02-15", "2016-02-13"));
        }

        [TestMethod()]
        public void GetBudgetTest_20160215_20160216_38()
        {
            CreateRepoStub("2016-02 560");
            Assert.AreEqual(38, GetBudget("2016-02-15", "2016-02-16"));
        }

        [TestMethod()]
        public void GetBudgetTest_20180101_20180130_0()
        {
            CreateRepoStub("2016-02 560");
            Assert.AreEqual(0, GetBudget("2018-01-01", "2018-01-30"));
        }

        [TestMethod()]
        public void GetBudgetTest_20180201_20190201_1875()
        {
            CreateRepoStub("2018-04 600", "2018-05 620", "2018-07 620",
                "2019-02 990", "2019-03 990");
            Assert.AreEqual(1875, GetBudget("2018-02-01", "2019-02-01"));
        }

        [TestMethod()]
        public void GetBudgetTest_20180401_20180401_20()
        {
            CreateRepoStub("2018-04 600");
            Assert.AreEqual(20, GetBudget("2018-04-01", "2018-04-01"));
        }

        [TestMethod()]
        public void GetBudgetTest_20180415_20180515_620()
        {
            CreateRepoStub("2018-04 600", "2018-05 620");
            Assert.AreEqual(620, GetBudget("2018-04-15", "2018-05-15"));
        }

        [TestMethod()]
        public void GetBudgetTest_20180415_20180630_940()
        {
            CreateRepoStub("2018-04 600", "2018-05 620");
            Assert.AreEqual(940, GetBudget("2018-04-15", "2018-06-30"));
        }

        [TestMethod()]
        public void GetBudgetTest_20180520_20180716_560()
        {
            CreateRepoStub("2018-05 620", "2018-07 620");
            Assert.AreEqual(560, GetBudget("2018-05-20", "2018-07-16"));
        }

        [TestMethod()]
        public void GetBudgetTest_20190201_20190630_4950()
        {
            CreateRepoStub("2019-02 990", "2019-03 990", "2019-04 990",
                "2019-05 990", "2019-06 990");
            Assert.AreEqual(4950, GetBudget("2019-02-01", "2019-06-30"));
        }

        private void CreateRepoStub(params string[] budgets)
        {
            var budgetList = new List<Budget>();
            foreach (var budget in budgets)
            {
                budgetList.Add(new Budget(budget.Split(' ')[0], budget.Split(' ')[1]));
            }
            _repoStub = new RepoStub(budgetList);
        }

        private int GetBudget(string start, string end)
        {
            return GenerateBudgetCalculater(start, end).GetBudget();
        }

        private BudgetCalculator GenerateBudgetCalculater(string start, string end)
        {
            return new BudgetCalculator(_repoStub,
                DateTime.ParseExact(start, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                DateTime.ParseExact(end, "yyyy-MM-dd", CultureInfo.InvariantCulture));
        }
    }

    internal class RepoStub : IRepo
    {
        private List<Budget> _budgets;

        public RepoStub(List<Budget> budgets)
        {
            _budgets = budgets;
        }

        public void Add(Budget budget)
        {
        }

        public ICollection<Budget> GetAllBudgets()
        {
            return _budgets;
        }
    }
}