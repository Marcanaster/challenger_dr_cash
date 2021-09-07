using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DrCash.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<DrCashContext>
    {
        public DrCashContext CreateDbContext(string[] args)
        {
            //var connectionString = @"Data Source=MARCANASTER\\SQLEXPRESS;Initial Catalog=DrCash;Persist Security Info=True;User ID=marcanaster;Password=f0d@s481521;MultipleActiveResultSets=True";
            var optionsBuilder = new DbContextOptionsBuilder<DrCashContext>();
            optionsBuilder.UseSqlServer("Server= MARCANASTER\\SQLEXPRESS; Initial Catalog = DrCash; Persist Security Info = True; User ID = marcanaster; Password = f0d@s481521; MultipleActiveResultSets = True");
            return new DrCashContext(optionsBuilder.Options);
        }
    }
}
