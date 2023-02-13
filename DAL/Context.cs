using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<BooksG> book { get; set; }

    public Context(DbContextOptions<Context> option) : base(option)
    {
        
    }
}