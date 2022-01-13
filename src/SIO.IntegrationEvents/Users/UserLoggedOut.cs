using SIO.Infrastructure.Events;

namespace SIO.IntegrationEvents.Users
{
    public class UserLoggedOut : Event
    {
        public UserLoggedOut(string subject, int version) : base(subject, version)
        {
        }
    }
}
