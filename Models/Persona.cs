using System.ComponentModel.DataAnnotations;

namespace bartolini.liam._5h.PrimoEF.Models
{
  public class Persona
  {
    [Key]
    public int idPersona { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }

    [EmailAddress]
    public string EMail { get; set; }
  }
}