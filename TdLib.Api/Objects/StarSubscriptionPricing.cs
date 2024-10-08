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
        /// <summary>
        /// Describes subscription plan paid in Telegram Stars
        /// </summary>
        public partial class StarSubscriptionPricing : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "starSubscriptionPricing";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The number of seconds between consecutive Telegram Star debiting
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("period")]
            public int Period { get; set; }

            /// <summary>
            /// The amount of Telegram Stars that must be paid for each period
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("star_count")]
            public long StarCount { get; set; }
        }
    }
}
// REUSE-IgnoreEnd