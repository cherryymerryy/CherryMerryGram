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
        /// Contains information about the main Web App of a bot
        /// </summary>
        public partial class MainWebApp : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "mainWebApp";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// URL of the Web App to open
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// True, if the Web App must always be opened in the compact mode instead of the full-size mode
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_compact")]
            public bool IsCompact { get; set; }
        }
    }
}
// REUSE-IgnoreEnd