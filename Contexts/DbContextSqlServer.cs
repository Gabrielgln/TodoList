using Microsoft.EntityFrameworkCore;
using TWTodoList.Models;

namespace TWTodoList.Contexts;

public class DbContextSqlServer : DbContext
{
    private const string strConnection = "Data Source=DESKTOP-Q8ARERH\\SQLEXPRESS;Initial Catalog=TWTodoList;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=False;User Id=sa;Password=12345";
    public DbSet<Todo> Todo {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(strConnection);
    }
}