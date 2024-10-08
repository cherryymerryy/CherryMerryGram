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
        public partial class FirebaseDeviceVerificationParameters : Object
        {
            /// <summary>
            /// Device verification must be performed with the classic Play Integrity verification (https://developer.android.com/google/play/integrity/classic)
            /// </summary>
            public class FirebaseDeviceVerificationParametersPlayIntegrity : FirebaseDeviceVerificationParameters
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "firebaseDeviceVerificationParametersPlayIntegrity";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Base64url-encoded nonce to pass to the Play Integrity API
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("nonce")]
                public string Nonce { get; set; }

                /// <summary>
                /// Cloud project number to pass to the Play Integrity API
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("cloud_project_number")]
                public long CloudProjectNumber { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd