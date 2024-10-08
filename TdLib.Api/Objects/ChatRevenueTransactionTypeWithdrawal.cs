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
        public partial class ChatRevenueTransactionType : Object
        {
            /// <summary>
            /// Describes a withdrawal of earnings
            /// </summary>
            public class ChatRevenueTransactionTypeWithdrawal : ChatRevenueTransactionType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatRevenueTransactionTypeWithdrawal";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Point in time (Unix timestamp) when the earnings withdrawal started
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("withdrawal_date")]
                public int WithdrawalDate { get; set; }

                /// <summary>
                /// Name of the payment provider
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("provider")]
                public string Provider { get; set; }

                /// <summary>
                /// State of the withdrawal
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("state")]
                public RevenueWithdrawalState State { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd