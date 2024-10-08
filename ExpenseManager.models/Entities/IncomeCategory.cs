using System.ComponentModel.DataAnnotations;

namespace ExpenseManager.Models.Entities
{
    public class IncomeCategory
    {
        [Key]
        public int Income_Category_Id { get; set; }

        [Required]
        public string Category_Name { get; set; } = null!;
        
        [Required]
        public DateTime Created_Date_Time { get; set; }

        [Required]
        public DateTime Updated_Date_Time { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}