using SIO.Infrastructure.Events;

namespace SIO.IntegrationEvents.Translations
{
    public abstract class TranslationEvent : Event
    {
        public string DocumentSubject { get; set; }

        public TranslationEvent(string subject, int version, string documentSubject) : base(subject, version)
        {
            DocumentSubject = documentSubject;
        }
    }
}
