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
        /// Contains a list of media previews of a bot
        /// </summary>
        public partial class BotMediaPreviews : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "botMediaPreviews";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of media previews
            /// </summary>
            [JsonProperty("previews", ItemConverterType = typeof(Converter))]
            public BotMediaPreview[] Previews { get; set; }
        }
    }
}
// REUSE-IgnoreEnd