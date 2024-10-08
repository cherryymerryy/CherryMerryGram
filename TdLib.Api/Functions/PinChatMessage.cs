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
        /// Pins a message in a chat. A message can be pinned only if messageProperties.can_be_pinned
        /// </summary>
        public class PinChatMessage : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "pinChatMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the new pinned message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// Pass true to disable notification about the pinned message. Notifications are always disabled in channels and private chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("disable_notification")]
            public bool DisableNotification { get; set; }

            /// <summary>
            /// Pass true to pin the message only for self; private chats only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("only_for_self")]
            public bool OnlyForSelf { get; set; }
        }

        /// <summary>
        /// Pins a message in a chat. A message can be pinned only if messageProperties.can_be_pinned
        /// </summary>
        public static Task<Ok> PinChatMessageAsync(
            this Client client, long chatId = default, long messageId = default, bool disableNotification = default, bool onlyForSelf = default)
        {
            return client.ExecuteAsync(new PinChatMessage
            {
                ChatId = chatId, MessageId = messageId, DisableNotification = disableNotification, OnlyForSelf = onlyForSelf
            });
        }
    }
}
// REUSE-IgnoreEnd