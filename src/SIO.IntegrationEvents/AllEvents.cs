using SIO.IntegrationEvents.Documents;
using SIO.IntegrationEvents.TranslationOptions;
using SIO.IntegrationEvents.Translations;
using SIO.IntegrationEvents.Users;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SIO.IntegrationEvents
{
    public class AllEvents : IEnumerable<Type>
    {
        public IEnumerator<Type> GetEnumerator()
        {
            yield return typeof(DocumentDeleted);
            yield return typeof(DocumentUploaded);
            yield return typeof(TranslationCharactersProcessed);
            yield return typeof(TranslationFailed);
            yield return typeof(TranslationQueued);
            yield return typeof(TranslationStarted);
            yield return typeof(TranslationSucceded);
            yield return typeof(UserEmailChanged);
            yield return typeof(UserLoggedIn);
            yield return typeof(UserLoggedOut);
            yield return typeof(UserPasswordTokenGenerated);
            yield return typeof(UserPurchasedCharacterTokens);
            yield return typeof(UserRegistered);
            yield return typeof(UserVerified);
            yield return typeof(TranslationOptionImported);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
