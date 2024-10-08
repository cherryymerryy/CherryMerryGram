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
        public partial class GiveawayPrize : Object
        {
            /// <summary>
            /// The giveaway sends Telegram Stars to the winners
            /// </summary>
            public class GiveawayPrizeStars : GiveawayPrize
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "giveawayPrizeStars";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Number of Telegram Stars that will be shared by all winners
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("star_count")]
                public long StarCount { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd