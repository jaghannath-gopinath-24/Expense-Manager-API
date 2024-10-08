namespace ExpenseManager.Models.DTO
{
    public class IncomeCategory
    {
        public int IncomeCategoryId { get; set; }

        public string Category { get; set; } = null!;
        
        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}