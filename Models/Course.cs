namespace ControleDeCursos.Models;

public class Course
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public IList<Lead> Leads { get; set; }
}

