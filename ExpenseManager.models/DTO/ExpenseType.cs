namespace ExpenseManager.Models.DTO
{
    public class ExpenseType
    {
        public int ExpenseTypeId { get; set; }

        public string Expense { get; set; } = null!;

        public int ExpenseCategory { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}