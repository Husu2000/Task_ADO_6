using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace Task_ADO_6;

internal class MiniINSTACON:DbContext
{
    public DbSet<Post> posts { get; set; }
    public DbSet<Tags> tags { get; set; }
    public DbSet<Users> users { get; set; }

    public MiniINSTACON()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MiniInsta;Integrated Security=SSPI;");

    }
}
