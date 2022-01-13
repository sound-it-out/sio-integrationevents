using SIO.Infrastructure.Events;

namespace SIO.IntegrationEvents.Users
{
    public class UserVerified : Event
    {
        public UserVerified(string subject, int version) : base(subject, version)
        {
        }
    }
}
