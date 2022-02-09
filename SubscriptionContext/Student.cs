using MaoNaMassaPOO.ContetContext;
using MaoNaMassaPOO.NotificationContext;

namespace MaoNaMassaPOO.SubscriptionContext
{
  public class Student : Base
  {
    public Student()
    {
      Subscriptions = new List<Subscription>();
    }
    
    public string Name { get; set; }
    public string Email { get; set; }
    public User User {get; set; }

    public IList<Subscription> Subscriptions { get; set; }
    
    public bool isPremium => Subscriptions.Any(x => !x.isInactive);


    public void CreateSubscription(Subscription subscription)
    {
      if(isPremium)
      {
        AddNotification(new Notification("Premium", "O aluno já é um assinante Premium"));
        return;
      }

      Subscriptions.Add(subscription);
    }
  }
}