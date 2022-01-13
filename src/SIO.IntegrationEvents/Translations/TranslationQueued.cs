namespace SIO.IntegrationEvents.Translations
{
    public class TranslationQueued : TranslationEvent
    {
        public TranslationQueued(string subject, int version, string documentSubject) : base(subject, version, documentSubject)
        {
        }
    }
}
