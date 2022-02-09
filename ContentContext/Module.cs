using System.Collections.Generic;

namespace MaoNaMassaPOO.ContetContext
{
   public class Module : Base
  {
    public Module()
    {
      Lectures = new List<Lecture>();
    }

    public int Oder { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }

  }
}