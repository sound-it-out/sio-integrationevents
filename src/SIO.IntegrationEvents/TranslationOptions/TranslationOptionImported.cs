using SIO.IntegrationEvents.Documents;
using SIO.Infrastructure.Events;

namespace SIO.IntegrationEvents.TranslationOptions
{
    public class TranslationOptionImported : Event
    {
        public TranslationType TranslationType { get; set; }

        public TranslationOptionImported(string subject, int version, TranslationType translationType) : base(subject, version)
        {
            TranslationType = translationType;
        }
    }
}
