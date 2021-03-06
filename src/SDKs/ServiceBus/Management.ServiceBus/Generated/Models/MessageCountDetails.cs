// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Message Count Details.
    /// </summary>
    public partial class MessageCountDetails
    {
        /// <summary>
        /// Initializes a new instance of the MessageCountDetails class.
        /// </summary>
        public MessageCountDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MessageCountDetails class.
        /// </summary>
        /// <param name="activeMessageCount">Number of active messages in the
        /// queue, topic, or subscription.</param>
        /// <param name="deadLetterMessageCount">Number of messages that are
        /// dead lettered.</param>
        /// <param name="scheduledMessageCount">Number of scheduled
        /// messages.</param>
        /// <param name="transferMessageCount">Number of messages transferred
        /// to another queue, topic, or subscription.</param>
        /// <param name="transferDeadLetterMessageCount">Number of messages
        /// transferred into dead letters.</param>
        public MessageCountDetails(long? activeMessageCount = default(long?), long? deadLetterMessageCount = default(long?), long? scheduledMessageCount = default(long?), long? transferMessageCount = default(long?), long? transferDeadLetterMessageCount = default(long?))
        {
            ActiveMessageCount = activeMessageCount;
            DeadLetterMessageCount = deadLetterMessageCount;
            ScheduledMessageCount = scheduledMessageCount;
            TransferMessageCount = transferMessageCount;
            TransferDeadLetterMessageCount = transferDeadLetterMessageCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets number of active messages in the queue, topic, or
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "activeMessageCount")]
        public long? ActiveMessageCount { get; private set; }

        /// <summary>
        /// Gets number of messages that are dead lettered.
        /// </summary>
        [JsonProperty(PropertyName = "deadLetterMessageCount")]
        public long? DeadLetterMessageCount { get; private set; }

        /// <summary>
        /// Gets number of scheduled messages.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledMessageCount")]
        public long? ScheduledMessageCount { get; private set; }

        /// <summary>
        /// Gets number of messages transferred to another queue, topic, or
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "transferMessageCount")]
        public long? TransferMessageCount { get; private set; }

        /// <summary>
        /// Gets number of messages transferred into dead letters.
        /// </summary>
        [JsonProperty(PropertyName = "transferDeadLetterMessageCount")]
        public long? TransferDeadLetterMessageCount { get; private set; }

    }
}
