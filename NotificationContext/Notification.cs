namespace MaoNaMassaPOO.NotificationContext
{
  public class Notification 
  {
    public Notification() { } // construtor vazio

    public Notification(string property, string message) 
    {
      Property = property;
      Message = message;
    }
    public string Property { get; set; }
    public string Message { get; set; }
  }
}