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
        /// Changes the message auto-delete or self-destruct (for secret chats) time in a chat. Requires change_info administrator right in basic groups, supergroups and channels.
        /// Message auto-delete time can't be changed in a chat with the current user (Saved Messages) and the chat 777000 (Telegram).
        /// </summary>
        public class SetChatMessageAutoDeleteTime : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setChatMessageAutoDeleteTime";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// New time value, in seconds; unless the chat is secret, it must be from 0 up to 365 * 86400 and be divisible by 86400. If 0, then messages aren't deleted automatically
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_auto_delete_time")]
            public int MessageAutoDeleteTime { get; set; }
        }

        /// <summary>
        /// Changes the message auto-delete or self-destruct (for secret chats) time in a chat. Requires change_info administrator right in basic groups, supergroups and channels.
        /// Message auto-delete time can't be changed in a chat with the current user (Saved Messages) and the chat 777000 (Telegram).
        /// </summary>
        public static Task<Ok> SetChatMessageAutoDeleteTimeAsync(
            this Client client, long chatId = default, int messageAutoDeleteTime = default)
        {
            return client.ExecuteAsync(new SetChatMessageAutoDeleteTime
            {
                ChatId = chatId, MessageAutoDeleteTime = messageAutoDeleteTime
            });
        }
    }
}
// REUSE-IgnoreEnd