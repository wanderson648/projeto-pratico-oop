namespace MaoNaMassaPOO.ContetContext
{
  public class Carrer : Content
  {
    public Carrer(string title, string url)
      : base(title, url)
    {
      Items = new List<CarrerItem>();
    }
    public int Courses { get; set; }

    public IList<CarrerItem> Items { get; set; }

    public int TotalCourses => Items.Count(); // Expression Body/ usado quando só tem uma linha de código
  }
}