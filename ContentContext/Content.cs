using System;

namespace MaoNaMassaPOO.ContetContext
{
  public abstract class Content : Base
  {
    public Content(string title, string url)
    {
      this.Title = title;
      this.Url = url;
    }


    public string Title  { get; set; }
    public string Url { get; set; }
  }
}