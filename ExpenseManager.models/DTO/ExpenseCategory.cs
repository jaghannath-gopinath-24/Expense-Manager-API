namespace ExpenseManager.Models.DTO
{
    public class ExpenseCategory
    {
        public int ExpenseCategoryId { get; set; }

        public string Category { get; set; } = null!;

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}