using System.ComponentModel.DataAnnotations;

namespace ExpenseManager.Models.Entities
{
    public class CurrencyType
    {
        [Key]
        public int Currency_Type_Id { get; set; }

        [Required]
        public string Currency_Name { get; set; } = null!;

        [Required]
        public string Country_Name { get; set; } = null!;

        [Required]
        public DateTime Created_Date_Time { get; set; }

        [Required]
        public DateTime Updated_Date_Time { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}