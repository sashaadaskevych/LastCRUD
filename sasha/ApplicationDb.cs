using Microsoft.EntityFrameworkCore;
using sasha.addclasses;
using Microsoft.EntityFrameworkCore;
using sasha.addclasses;

namespace sasha
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Account> Accounts { get; set; } 
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Employee> Employees { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(a => a.Cards)
                .WithOne(c => c.Account)
                .HasForeignKey(c => c.AccountId);
        }
    }
}
