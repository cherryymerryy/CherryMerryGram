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
        /// Returns forwarded copies of a channel message to different public channels and public reposts as a story. Can be used only if messageProperties.can_get_statistics == true. For optimal performance, the number of returned messages and stories is chosen by TDLib
        /// </summary>
        public class GetMessagePublicForwards : Function<PublicForwards>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMessagePublicForwards";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Message identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// Offset of the first entry to return as received from the previous request; use empty string to get the first chunk of results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public string Offset { get; set; }

            /// <summary>
            /// The maximum number of messages and stories to be returned; must be positive and can't be greater than 100. For optimal performance, the number of returned objects is chosen by TDLib and can be smaller than the specified limit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns forwarded copies of a channel message to different public channels and public reposts as a story. Can be used only if messageProperties.can_get_statistics == true. For optimal performance, the number of returned messages and stories is chosen by TDLib
        /// </summary>
        public static Task<PublicForwards> GetMessagePublicForwardsAsync(
            this Client client, long chatId = default, long messageId = default, string offset = default, int limit = default)
        {
            return client.ExecuteAsync(new GetMessagePublicForwards
            {
                ChatId = chatId, MessageId = messageId, Offset = offset, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd