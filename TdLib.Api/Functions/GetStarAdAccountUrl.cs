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
        /// Returns a URL for a Telegram Ad platform account that can be used to set up advertisements for the chat paid in the owned Telegram Stars
        /// </summary>
        public class GetStarAdAccountUrl : Function<HttpUrl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getStarAdAccountUrl";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the owner of the Telegram Stars; can be identifier of an owned bot, or identifier of an owned channel chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("owner_id")]
            public MessageSender OwnerId { get; set; }
        }

        /// <summary>
        /// Returns a URL for a Telegram Ad platform account that can be used to set up advertisements for the chat paid in the owned Telegram Stars
        /// </summary>
        public static Task<HttpUrl> GetStarAdAccountUrlAsync(
            this Client client, MessageSender ownerId = default)
        {
            return client.ExecuteAsync(new GetStarAdAccountUrl
            {
                OwnerId = ownerId
            });
        }
    }
}
// REUSE-IgnoreEnd