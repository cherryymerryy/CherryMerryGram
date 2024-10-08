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
        public partial class LinkPreviewType : Object
        {
            /// <summary>
            /// The link is a link to an audio file
            /// </summary>
            public class LinkPreviewTypeExternalAudio : LinkPreviewType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "linkPreviewTypeExternalAudio";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// URL of the audio file
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("url")]
                public string Url { get; set; }

                /// <summary>
                /// MIME type of the audio file
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("mime_type")]
                public string MimeType { get; set; }

                /// <summary>
                /// Duration of the audio, in seconds; 0 if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int Duration { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd