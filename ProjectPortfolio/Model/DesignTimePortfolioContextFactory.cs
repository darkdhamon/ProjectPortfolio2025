using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Model;

public class DesignTimePortfolioContextFactory : IDesignTimeDbContextFactory<PortfolioContext>
{
    public PortfolioContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PortfolioContext>();
        optionsBuilder.UseSqlite("Data Source=portfolio.db");
        return new PortfolioContext(optionsBuilder.Options);
    }
}
