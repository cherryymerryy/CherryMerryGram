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
        /// Returns name of a sticker set by its identifier
        /// </summary>
        public class GetStickerSetName : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getStickerSetName";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the sticker set
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("set_id")]
            public long SetId { get; set; }
        }

        /// <summary>
        /// Returns name of a sticker set by its identifier
        /// </summary>
        public static Task<Text> GetStickerSetNameAsync(
            this Client client, long setId = default)
        {
            return client.ExecuteAsync(new GetStickerSetName
            {
                SetId = setId
            });
        }
    }
}
// REUSE-IgnoreEnd