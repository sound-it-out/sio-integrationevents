using SIO.Infrastructure.Events;

namespace SIO.IntegrationEvents.Users
{
    public class UserLoggedIn : Event
    {
        public UserLoggedIn(string subject, int version) : base(subject, version)
        {
        }
    }
}
