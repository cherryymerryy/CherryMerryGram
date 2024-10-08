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
        /// Removes potentially dangerous characters from the name of a file. Returns an empty string on failure. Can be called synchronously
        /// </summary>
        public class CleanFileName : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "cleanFileName";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// File name or path to the file
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_name")]
            public string FileName { get; set; }
        }

        /// <summary>
        /// Removes potentially dangerous characters from the name of a file. Returns an empty string on failure. Can be called synchronously
        /// </summary>
        public static Task<Text> CleanFileNameAsync(
            this Client client, string fileName = default)
        {
            return client.ExecuteAsync(new CleanFileName
            {
                FileName = fileName
            });
        }
    }
}
// REUSE-IgnoreEnd