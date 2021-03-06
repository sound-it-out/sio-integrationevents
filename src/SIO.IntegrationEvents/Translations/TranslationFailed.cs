namespace SIO.IntegrationEvents.Translations
{
    public class TranslationFailed : TranslationEvent
    {
        public string Error { get; set; }

        public TranslationFailed(string subject, int version, string documentSubject, string error) : base(subject, version, documentSubject)
        {
            Error = error;
        }
    }
}
