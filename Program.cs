using MaoNaMassaPOO.ContetContext;
using MaoNaMassaPOO.SubscriptionContext;

namespace MaoNaMassaPOO 
{
  class Program 
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var articles = new List<Article>();
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
      articles.Add(new Article("Artigo sobre C#", "csharp"));
      articles.Add(new Article("Artigo sobre .NET", "dotnet"));

      // foreach(var article in articles)
      // {
      //   Console.WriteLine(article.Id);
      //   Console.WriteLine(article.Title);
      //   Console.WriteLine(article.Url);
      // }

      var courses = new List<Course>();
      var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
      var courseCsharp = new Course("Fundamentos csharp", "fundamentos-csharp");
      var courseAspNet = new Course("Fundamentos ASP .NET", "fundamentos-dotnet");

      courses.Add(courseOOP);
      courses.Add(courseCsharp);
      courses.Add(courseAspNet);


      var carrers = new List<Carrer>();
      
      var carrerDotnet = new Carrer("Especialisat .NET", "epecialista-dotnet");
      var carrerItem3 = new CarrerItem(3, "aprendendo C#", "", courseCsharp);
      var carrerItem = new CarrerItem(1, "aprendendo OOP", "", courseOOP);
      var carrerItem2 = new CarrerItem(2, "aprendendo .NET", "", courseAspNet);
      
      carrerDotnet.Items.Add(carrerItem3);
      carrerDotnet.Items.Add(carrerItem);
      carrerDotnet.Items.Add(carrerItem2);

      carrers.Add(carrerDotnet);

      // pode user foreach dentro de outro foreach
      foreach(var carrer in carrers)
      {
        Console.WriteLine(carrer.Title);

        foreach(var item in carrer.Items.OrderBy(x => x.Order))
        {
          Console.WriteLine($"{item.Order} - {item.Title}");
          Console.WriteLine($"{item.Course?.Title}"); // null cheque
          Console.WriteLine($"{item.Course?.Level}"); // null cheque

          foreach(var notification in item.Notifications)
          {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
          }
          
        }
      }

      var payPalSubscription = new PayPalSubscription();
      var student = new Student();
      student.CreateSubscription(payPalSubscription);

    }
  }
}

