using MaoNaMassaPOO.ContetContext.Enums;

namespace MaoNaMassaPOO.ContetContext
{
  public class Course : Content
  {
    // inicializar modulos no construtor
    public Course(string title, string url)
      : base(title, url)
    {
      Modules = new List<Module>();
    }

    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }

  }
}