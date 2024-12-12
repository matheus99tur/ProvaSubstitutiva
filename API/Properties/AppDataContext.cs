using System;
using API.models;
using Microsoft.EntityFrameworkCore;

namespace API.Properties;

public class AppDataContext : DbContext

{
    public DbSet<Aluno> Aluno { get; set; }
    public DbSet<Imc> Imc { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Matheus.db");
    }
}


