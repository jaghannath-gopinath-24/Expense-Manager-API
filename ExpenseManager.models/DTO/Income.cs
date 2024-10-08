namespace ExpenseManager.Models.DTO
{
    public class Income
    {
        public Guid IncomeID { get; set; }

        public float Amount { get; set; }

        public DateTime DateOfIncome { get; set; }

        public int IncomeCategory { get; set; }

        public string UserId { get; set; } = null!;

        public int CurrencyType { get; set; }

        public string? Comments { get; set; }

        public DateTime Created_Date_Time { get; set; }

        public DateTime Updated_Date_Time { get; set; }
    }
}