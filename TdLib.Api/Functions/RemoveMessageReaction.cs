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
        /// Removes a reaction from a message. A chosen reaction can always be removed
        /// </summary>
        public class RemoveMessageReaction : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "removeMessageReaction";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which the message belongs
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// Type of the reaction to remove. The paid reaction can't be removed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reaction_type")]
            public ReactionType ReactionType { get; set; }
        }

        /// <summary>
        /// Removes a reaction from a message. A chosen reaction can always be removed
        /// </summary>
        public static Task<Ok> RemoveMessageReactionAsync(
            this Client client, long chatId = default, long messageId = default, ReactionType reactionType = default)
        {
            return client.ExecuteAsync(new RemoveMessageReaction
            {
                ChatId = chatId, MessageId = messageId, ReactionType = reactionType
            });
        }
    }
}
// REUSE-IgnoreEnd