using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;
using Application = TestStack.White.Application;
using Button = TestStack.White.UIItems.Button;
using TextBox = TestStack.White.UIItems.TextBox;

namespace BudgetAddTests.Steps
{
    [Binding]
    public class BudgetAddSteps
    {
        private static Window _window;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            var application = Application.Launch(@"C:\Users\Mystic\Documents\Courses\CSD\WinForms\BudgetAdd\BudgetAdd\bin\Debug\BudgetAdd.exe");
            _window = application.GetWindow("Form1", InitializeOption.NoCache);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            _window.Close();
        }

        [When(@"I input month ""(.*)"" and amount (.*)")]
        public void WhenIInputMonthAndAmount(string monthText, string amountText)
        {
            var month = _window.Get<TextBox>("month");
            month.Text = monthText;
            var amount = _window.Get<TextBox>("amount");
            amount.Text = amountText;
            var saveButton = _window.Get<Button>("save");
            saveButton.Click();
        }

        [Then(@"the result should be ""(.*)"" and ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeAndOnTheScreen(string monthText, string amountText)
        {
            var UopdateButton = _window.Get<Button>("update");
            UopdateButton.Click();

            var resultListBox = _window.Get<TestStack.White.UIItems.ListBoxItems.ListBox>("resultListBox");
            var existExceptedItem = resultListBox.Items.Exists(x => x.Text == (monthText + " " + amountText));
            Assert.IsTrue(existExceptedItem);
        }
    }
}