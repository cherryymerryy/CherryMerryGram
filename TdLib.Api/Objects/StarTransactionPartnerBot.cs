using System;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class StarTransactionPartner : Object
        {
            /// <summary>
            /// The transaction is a transaction with a bot
            /// </summary>
            public class StarTransactionPartnerBot : StarTransactionPartner
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "starTransactionPartnerBot";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the bot
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public long UserId { get; set; }

                /// <summary>
                /// Purpose of the transaction
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("purpose")]
                public BotTransactionPurpose Purpose { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd