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
        public partial class RichText : Object
        {
            /// <summary>
            /// A reference to a richTexts object on the same page
            /// </summary>
            public class RichTextReference : RichText
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "richTextReference";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The text
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public RichText Text { get; set; }

                /// <summary>
                /// The name of a richTextAnchor object, which is the first element of the target richTexts object
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("anchor_name")]
                public string AnchorName { get; set; }

                /// <summary>
                /// An HTTP URL, opening the reference
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("url")]
                public string Url { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd