namespace ExpenseManager.Models.DTO
{
    public class CurrencyType
    {
        public int CurrencyTypeId { get; set; }

        public string Currency { get; set; } = null!;

        public string Country { get; set; } = null!;

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}