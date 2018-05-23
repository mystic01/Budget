using Microsoft.VisualStudio.TestTools.UnitTesting;
using BudgetAdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAdd.Tests
{
    [TestClass()]
    public class BudgetCalculaterTests
    {
        [TestMethod()]
        public void GetBudgetTest_20180415_20180515_620()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2018,04,15), new DateTime(2018,05,15));
            var actual = target.GetBudget();
            Assert.AreEqual(620, actual);
        }

        [TestMethod()]
        public void GetBudgetTest_20180415_20180630_940()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2018,04,15), new DateTime(2018,06,30));
            var actual = target.GetBudget();
            Assert.AreEqual(940, actual);
        }


        [TestMethod()]
        public void GetBudgetTest_20180520_20180716_560()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2018,05,20), new DateTime(2018,07,16));
            var actual = target.GetBudget();
            Assert.AreEqual(560, actual);
        }


        [TestMethod()]
        public void GetBudgetTest_20160215_20160213_251()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2016,01,15), new DateTime(2016,02,13));
            var actual = target.GetBudget();
            Assert.AreEqual(251, actual);
        }

        [TestMethod()]
        public void GetBudgetTest_20160215_20160213_0()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2016,02,15), new DateTime(2016,02,13));
            var actual = target.GetBudget();
            Assert.AreEqual(0, actual);
        }

        [TestMethod()]
        public void GetBudgetTest_20160215_20160216_38()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2016,02,15), new DateTime(2016,02,16));
            var actual = target.GetBudget();
            Assert.AreEqual(38, actual);
        }
        

        [TestMethod()]
        public void GetBudgetTest_20180401_20180401_20()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2018,04,01), new DateTime(2018,04,01));
            var actual = target.GetBudget();
            Assert.AreEqual(20, actual);
        }

        [TestMethod()]
        public void GetBudgetTest_20160201_20180430_1160()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2016, 02, 01), new DateTime(2018, 04, 30));
            var actual = target.GetBudget();
            Assert.AreEqual(1160, actual);
        }

        [TestMethod()]
        public void GetBudgetTest_20190201_20190630_4940()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2019, 02, 01), new DateTime(2019, 06, 30));
            var actual = target.GetBudget();
            Assert.AreEqual(4950, actual);
        }

        [TestMethod()]
        public void GetBudgetTest_20180201_20190201_1875()
        {
            var target = new BudgetCalculater(new RepoStub(), new DateTime(2018, 02, 01), new DateTime(2019, 02, 01));
            var actual = target.GetBudget();
            Assert.AreEqual(1875, actual);
        }
    }

    internal class RepoStub : IRepo
    {
        public void Add(Budget budget)
        {
        }

        public ICollection<Budget> GetAllBudgets()
        {
            var result = new List<Budget>()
            {
                new Budget("2016-02", "560" ),
                new Budget("2018-04", "600" ),
                new Budget("2018-05", "620" ),
                new Budget("2018-07", "620" ),
                new Budget("2019-02", "990" ),
                new Budget("2019-03", "990" ),
                new Budget("2019-04", "990" ),
                new Budget("2019-05", "990" ),
                new Budget("2019-06", "990" ),
            };
            return result;
        }
    }
}