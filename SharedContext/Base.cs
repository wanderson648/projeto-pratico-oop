using MaoNaMassaPOO.NotificationContext;
namespace MaoNaMassaPOO.ContetContext
{
  public abstract class  Base : Notifiable
  {
    public Base()
    {
      this.Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }

  }
}