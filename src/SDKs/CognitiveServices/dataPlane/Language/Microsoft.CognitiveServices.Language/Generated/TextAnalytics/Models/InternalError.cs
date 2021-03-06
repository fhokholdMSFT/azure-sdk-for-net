// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Language.TextAnalytics.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Language;
    using Microsoft.CognitiveServices.Language.TextAnalytics;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class InternalError
    {
        /// <summary>
        /// Initializes a new instance of the InternalError class.
        /// </summary>
        public InternalError()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InternalError class.
        /// </summary>
        public InternalError(string code = default(string), string message = default(string), InternalError innerError = default(InternalError))
        {
            Code = code;
            Message = message;
            InnerError = innerError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public InternalError InnerError { get; set; }

    }
}
