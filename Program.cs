using System;
using bartolini.liam._5h.PrimoEF.Models;

namespace bartolini.liam._5h.PrimoEF
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello db-World!");

      // Apro il db
      DbPersone db = new();
      // Aggiungo una nuova persona
      for (int i = 0; i < 1000; i++)
      {
          db.Persone.Add(new Persona {Nome = "Liam", Cognome = "Bartolini", EMail = "liambartolini@gmail.com"} );
      }

      db.SaveChanges();
    }
  }
}