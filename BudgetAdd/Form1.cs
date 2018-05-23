using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BudgetAdd
{
    public partial class Form1 : Form
    {
        private IRepo _repo = new Repo();

        //For UnitTest
        internal Form1(IRepo repo)
        {
            _repo = repo;
        }

        public Form1()
        {
            InitializeComponent();

            _repo = new Repo();
        }

        internal void save_Click(object sender, EventArgs e)
        {
            var inputMonth = month.Text;
            var inputAmount = amount.Text;

            _repo.Add(new Budget(inputMonth, inputAmount));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            resultListBox.Items.Clear();
            var allBudgets = _repo.GetAllBudgets();
            foreach (var budget in allBudgets)
            {
                resultListBox.Items.Add(budget.Month + " " + budget.Amount);
            }
        }
    }

    internal interface IRepo
    {
        void Add(Budget budget);
        ICollection<Budget> GetAllBudgets();
    }
}