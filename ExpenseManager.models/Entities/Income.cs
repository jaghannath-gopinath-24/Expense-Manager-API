using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.Models.Entities
{
    public class Income
    {
        [Key]
        public Guid Income_ID { get; set; }

        [Required]
        public float Income_Amount { get; set; }

        [Required]
        public DateTime Date_Of_Income { get; set; }

        [ForeignKey("IncomeCategory")]
        public int? Income_Category_Id { get; set; }

        [Required]
        public string User_Id { get; set; } = null!;

        [Required]
        [ForeignKey("CurrencyType")]
        public int Currency_Type_Id { get; set; }

        public string? Income_Comments { get; set; }

        [Required]
        public DateTime Created_Date_Time { get; set; }

        [Required]
        public DateTime Updated_Date_Time { get; set; }

        [Required]
        public bool Active { get; set; } 
    }
}