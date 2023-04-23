using Balta.ContentContext;

namespace Balta.SubsrcriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Email { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription){
            if(IsPremium)
            {
                AddNotidication(new NotificationContext.Notification("Premium","O Aluno já tem uma assinatura ativa"));     
            }
        }
        public bool IsPremium => Subscriptions.Any(x=>!x.IsInactive);
    }
}