using SIO.Infrastructure.Events;

namespace SIO.IntegrationEvents.Users
{
    public class UserPurchasedCharacterTokens : Event
    {
        public long CharacterTokens { get; set; }

        public UserPurchasedCharacterTokens(string subject, int version) : base(subject, version)
        {
        }
    }
}
