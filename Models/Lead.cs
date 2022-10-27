namespace ControleDeCursos.Models;

public class Lead
{
  public int Id {get; set;}
  public string Name { get; set; }
  public string Email { get; set; }
  public string CPF { get; set; }
  public IList<Course> Courses { get; set; }
}