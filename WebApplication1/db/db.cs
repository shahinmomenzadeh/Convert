using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Security.Policy;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.db;

public class db : DbContext
{
    public DbSet<Publisher>Publishers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer()
    }
}