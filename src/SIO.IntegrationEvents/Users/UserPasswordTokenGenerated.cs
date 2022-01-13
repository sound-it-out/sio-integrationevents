using SIO.Infrastructure.Events;

namespace SIO.IntegrationEvents.Users
{
    public class UserPasswordTokenGenerated : Event
    {
        public string Token { get; set; }

        public UserPasswordTokenGenerated(string subject, int version) : base(subject, version)
        {
        }
    }
}
