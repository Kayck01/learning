using System;
using System.Linq;
using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.PayPalSubscriptionContext;
using Balta.SubsrcriptionContext;

namespace Balta
{
    class Program
    {
        static void Main (string[] args)
        {
            var articles = new List<Article>();    
            articles.Add(new Article("Artigo sobre OOP", "arientacao-objeto"));
            articles.Add(new Article("Artigo sobre C#", "arientacao-objeto"));
            articles.Add(new Article("Artido sobre .NET", "arientacao-objeto"));      

            foreach(var article in articles){
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamento-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamento-oop");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamento-oop");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);
            

            var careers = new List<Career>();
            var careerDotnet = new Career ("Especialista .NET", "especialis-.NET");
            var careerItem = new CareerItem(1,"Comece por aqui","", null);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderByDescending(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach(var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message} ");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.Subscriptions.Add(payPalSubscription);
                
            }
        }
    }
}
