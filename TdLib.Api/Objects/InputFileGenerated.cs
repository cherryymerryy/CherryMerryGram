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
        public partial class InputFile : Object
        {
            /// <summary>
            /// A file generated by the application. The application must handle updates updateFileGenerationStart and updateFileGenerationStop to generate the file when asked by TDLib
            /// </summary>
            public class InputFileGenerated : InputFile
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputFileGenerated";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Local path to a file from which the file is generated. The path doesn't have to be a valid path and is used by TDLib only to detect name and MIME type of the generated file
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("original_path")]
                public string OriginalPath { get; set; }

                /// <summary>
                /// String specifying the conversion applied to the original file; must be persistent across application restarts. Conversions beginning with '#' are reserved for internal TDLib usage
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("conversion")]
                public string Conversion { get; set; }

                /// <summary>
                /// Expected size of the generated file, in bytes; pass 0 if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("expected_size")]
                public long ExpectedSize { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd