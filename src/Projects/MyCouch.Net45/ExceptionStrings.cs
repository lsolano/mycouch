﻿namespace MyCouch
{
    public static class ExceptionStrings
    {
        public static string DbRequestUrlIsAgainstOtherDb
        {
            get { return "When generating an URL for a request against a database via an IDbConnection, the DbNames must match."; }
        }
        public static string CanNotExtractDbNameFromDbUri
        {
            get { return "Could not extract DbName from passed URI: {0}. Please specify using specific contructor."; }
        }

        public static string PutRequestIsMissingIdInUrl
        {
            get { return "PUT requests must have an id part of the URL."; }
        }
        public static string QueryResponseRowsDeserializerNeedsJsonArray
        {
            get { return "When deserializing query response rows, the JSON-reader should point to the Start of an array."; }
        }

        public static string JsonConverterDoesNotSupportSerialization
        {
            get { return "This JSON-converter does only support deserialization, NOT serialization."; }
        }

        public static string GetChangesForNonContinuousFeedOnly
        {
            get { return "This method only supports Normal and Longpolling feeds. Please use other overload for e.g. Continuous feed."; }
        }

        public static string GetContinuousChangesInvalidFeed
        {
            get { return "This method only supports Continuous feeds. Please use other overload for e.g. Normal or Longpolling feed."; }
        }
    }
}
