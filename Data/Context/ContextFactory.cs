using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=tcp:studiowebdigital.database.windows.net,1433;Database=StudioWeb;User ID=StudioWeb;Password=Sup0rt3@;Trusted_Connection=False;Encrypt=True;";
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}