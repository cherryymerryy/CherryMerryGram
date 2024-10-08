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
        /// Returns chat members joined a chat via an invite link. Requires administrator privileges and can_invite_users right in the chat for own links and owner privileges for other links
        /// </summary>
        public class GetChatInviteLinkMembers : Function<ChatInviteLinkMembers>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatInviteLinkMembers";

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
            /// Invite link for which to return chat members
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link")]
            public string InviteLink { get; set; }

            /// <summary>
            /// Pass true if the link is a subscription link and only members with expired subscription must be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("only_with_expired_subscription")]
            public bool OnlyWithExpiredSubscription { get; set; }

            /// <summary>
            /// A chat member from which to return next chat members; pass null to get results from the beginning
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset_member")]
            public ChatInviteLinkMember OffsetMember { get; set; }

            /// <summary>
            /// The maximum number of chat members to return; up to 100
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns chat members joined a chat via an invite link. Requires administrator privileges and can_invite_users right in the chat for own links and owner privileges for other links
        /// </summary>
        public static Task<ChatInviteLinkMembers> GetChatInviteLinkMembersAsync(
            this Client client, long chatId = default, string inviteLink = default, bool onlyWithExpiredSubscription = default, ChatInviteLinkMember offsetMember = default, int limit = default)
        {
            return client.ExecuteAsync(new GetChatInviteLinkMembers
            {
                ChatId = chatId, InviteLink = inviteLink, OnlyWithExpiredSubscription = onlyWithExpiredSubscription, OffsetMember = offsetMember, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd