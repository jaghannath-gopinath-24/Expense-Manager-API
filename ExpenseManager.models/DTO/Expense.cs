namespace ExpenseManager.Models.DTO
{
    public class Expense
    {
        public Guid ExpenseId { get; set; }

        public int ExpenseCategory { get; set; }

        public int ExpenseType { get; set; }

        public float Amount { get; set; }

        public string UserId { get; set; } = null!;

        public int CurrencyCategory { get; set; }

        public DateTime DateOfExpense { get; set; }

        public string? Comments { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}