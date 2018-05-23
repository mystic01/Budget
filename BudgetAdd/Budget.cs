namespace BudgetAdd
{
    internal class Budget
    {
        public readonly string Month;
        public readonly string Amount;

        public Budget(string month, string amount)
        {
            Month = month;
            Amount = amount;
        }
    }
}