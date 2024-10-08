using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Searches for public channel posts containing the given hashtag or cashtag. For optimal performance, the number of returned messages is chosen by TDLib and can be smaller than the specified limit
        /// </summary>
        public class SearchPublicMessagesByTag : Function<FoundMessages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchPublicMessagesByTag";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Hashtag or cashtag to search for
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("tag")]
            public string Tag { get; set; }

            /// <summary>
            /// Offset of the first entry to return as received from the previous request; use empty string to get the first chunk of results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public string Offset { get; set; }

            /// <summary>
            /// The maximum number of messages to be returned; up to 100. For optimal performance, the number of returned messages is chosen by TDLib and can be smaller than the specified limit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Searches for public channel posts containing the given hashtag or cashtag. For optimal performance, the number of returned messages is chosen by TDLib and can be smaller than the specified limit
        /// </summary>
        public static Task<FoundMessages> SearchPublicMessagesByTagAsync(
            this Client client, string tag = default, string offset = default, int limit = default)
        {
            return client.ExecuteAsync(new SearchPublicMessagesByTag
            {
                Tag = tag, Offset = offset, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd