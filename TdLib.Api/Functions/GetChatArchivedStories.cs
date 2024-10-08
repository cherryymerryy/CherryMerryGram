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
        /// Returns the list of all stories posted by the given chat; requires can_edit_stories right in the chat.
        /// The stories are returned in reverse chronological order (i.e., in order of decreasing story_id). For optimal performance, the number of returned stories is chosen by TDLib
        /// </summary>
        public class GetChatArchivedStories : Function<Stories>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatArchivedStories";

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
            /// Identifier of the story starting from which stories must be returned; use 0 to get results from the last story
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("from_story_id")]
            public int FromStoryId { get; set; }

            /// <summary>
            /// The maximum number of stories to be returned.
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns the list of all stories posted by the given chat; requires can_edit_stories right in the chat.
        /// The stories are returned in reverse chronological order (i.e., in order of decreasing story_id). For optimal performance, the number of returned stories is chosen by TDLib
        /// </summary>
        public static Task<Stories> GetChatArchivedStoriesAsync(
            this Client client, long chatId = default, int fromStoryId = default, int limit = default)
        {
            return client.ExecuteAsync(new GetChatArchivedStories
            {
                ChatId = chatId, FromStoryId = fromStoryId, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd