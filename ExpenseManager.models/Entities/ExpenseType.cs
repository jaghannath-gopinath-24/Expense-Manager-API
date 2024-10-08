using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.Models.Entities
{
    public class ExpenseType
    {
        [Key]
        public int Expense_Type_Id { get; set; }

        [Required]
        public string Expense_Name { get; set; } = null!;

        [Required]
        [ForeignKey("ExpenseCategory")]
        public int Expense_Category_Id { get; set; }

        [Required]
        public DateTime Created_Date_Time { get; set; }

        [Required]
        public DateTime Updated_Date_Time { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}