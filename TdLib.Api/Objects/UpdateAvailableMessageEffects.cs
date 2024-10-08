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
        public partial class Update : Object
        {
            /// <summary>
            /// The list of available message effects has changed
            /// </summary>
            public class UpdateAvailableMessageEffects : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateAvailableMessageEffects";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The new list of available message effects from emoji reactions
                /// </summary>
                [JsonProperty("reaction_effect_ids", ItemConverterType = typeof(Converter))]
                public long[] ReactionEffectIds { get; set; }

                /// <summary>
                /// The new list of available message effects from Premium stickers
                /// </summary>
                [JsonProperty("sticker_effect_ids", ItemConverterType = typeof(Converter))]
                public long[] StickerEffectIds { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd