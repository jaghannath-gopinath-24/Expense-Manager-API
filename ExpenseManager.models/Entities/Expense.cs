using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.Models.Entities
{
    public class Expense
    {
        [Key] 
        public Guid Expense_Id { get; set; }

        [Required]
        [ForeignKey("ExpenseCategory")]
        public int Expense_Category_Id { get; set; }

        [Required]
        [ForeignKey("ExpenseType")]
        public int Expense_Type_Id { get; set; }

        [Required]
        public float Expense_Amount { get; set; }

        [Required]
        // [ForeignKey("User")]
        public string User_Id { get; set; } = null!;

        [Required]
        [ForeignKey("CurrencyCategory")]
        public int Currency_Category_Id { get; set; }

        [Required]
        public DateTime Date_Of_Expense { get; set; }

        public string? Expense_Comments { get; set; }

        [Required]
        public DateTime Created_Date_Time { get; set; }

        [Required]
        public DateTime Updated_Date_Time { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}