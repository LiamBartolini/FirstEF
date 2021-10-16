using System;
using Microsoft.EntityFrameworkCore;

namespace bartolini.liam._5h.PrimoEF.Models
{
  public class DbPersone : DbContext
  {
    // Tabella di Persone
    public DbSet<Persona> Persone { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder opzioni)
    {
      opzioni.UseSqlite("Data Source=dbPersone.db");
    }
  }
}