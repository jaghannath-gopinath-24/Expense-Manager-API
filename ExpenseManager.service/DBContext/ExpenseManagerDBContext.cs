using ExpenseManager.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManager.service.DBContext
{
    public class ExpenseManagerDBContext: IdentityDbContext<IdentityUser>
    {
        public ExpenseManagerDBContext(DbContextOptions<ExpenseManagerDBContext> options) : base(options)
        {
        }

        public DbSet<Income> Incomes { get; set; } = null!;

        public DbSet<Expense> Expenses { get; set; } = null!;

        public DbSet<CurrencyType> CurrencyTypes { get; set; } = null!;

        public DbSet<ExpenseCategory> ExpenseCategories { get; set; } = null!;

        public DbSet<IncomeCategory> IncomeCategories { get; set; } = null!;

        public DbSet<ExpenseType> ExpenseTypes { get; set; } = null!;
    }
}