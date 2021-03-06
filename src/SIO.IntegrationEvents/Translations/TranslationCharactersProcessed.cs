namespace SIO.IntegrationEvents.Translations
{
    public class TranslationCharactersProcessed : TranslationEvent
    {
        public long CharactersProcessed { get; set; }

        public TranslationCharactersProcessed(string subject, int version, string documentSubject, long charactersProcess) : base(subject, version, documentSubject)
        {
            CharactersProcessed = charactersProcess;
        }
    }
}
