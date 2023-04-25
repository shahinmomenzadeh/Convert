using Microsoft.EntityFrameworkCore;
using WebApplication1.db.Entities;

namespace ClassLibrary1;

public class Db : DbContext
{
    public DbSet<Result> Results { get; set; }

    public Db(DbContextOptions<Db> options):base(options)
    {
        
    }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //   base.OnConfiguring(optionsBuilder);
    //   optionsBuilder.UseSqlServer("Data Source=(localdb)\\DESKTOP-H8VBLET;Initial Catalog=DBCONVERT;User Id=shahin;Password=1234567890;");
   // }
}