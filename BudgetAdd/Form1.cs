using System;
using System.Windows.Forms;

namespace BudgetAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            var inputMonth = month.Text;
            var inputAmount = amount.Text;

            var budget = new Budget(inputMonth, inputAmount);
            var repo = new Repo();
            repo.Add(budget);
        }
    }

    internal class Repo
    {
        public void Add(Budget budget)
        {
        }
    }

    internal class Budget
    {
        private readonly string _inputMonth;
        private readonly string _inputAmount;

        public Budget(string inputMonth, string inputAmount)
        {
            _inputMonth = inputMonth;
            _inputAmount = inputAmount;
        }
    }
}