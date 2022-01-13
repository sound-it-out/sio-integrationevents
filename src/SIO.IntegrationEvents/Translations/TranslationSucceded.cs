namespace SIO.IntegrationEvents.Translations
{
    public class TranslationSucceded : TranslationEvent
    {
        public TranslationSucceded(string subject, int version, string documentSubject) : base(subject, version, documentSubject)
        {
        }
    }
}
