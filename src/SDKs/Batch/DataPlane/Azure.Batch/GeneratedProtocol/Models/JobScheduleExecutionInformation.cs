// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about jobs that have been and will be run under a
    /// job schedule.
    /// </summary>
    public partial class JobScheduleExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobScheduleExecutionInformation
        /// class.
        /// </summary>
        public JobScheduleExecutionInformation()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobScheduleExecutionInformation
        /// class.
        /// </summary>
        /// <param name="nextRunTime">The next time at which a job will be
        /// created under this schedule.</param>
        /// <param name="recentJob">Information about the most recent job under
        /// the job schedule.</param>
        /// <param name="endTime">The time at which the schedule ended.</param>
        public JobScheduleExecutionInformation(System.DateTime? nextRunTime = default(System.DateTime?), RecentJob recentJob = default(RecentJob), System.DateTime? endTime = default(System.DateTime?))
        {
            NextRunTime = nextRunTime;
            RecentJob = recentJob;
            EndTime = endTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the next time at which a job will be created under
        /// this schedule.
        /// </summary>
        /// <remarks>
        /// This property is meaningful only if the schedule is in the active
        /// state when the time comes around. For example, if the schedule is
        /// disabled, no job will be created at nextRunTime unless the job is
        /// enabled before then.
        /// </remarks>
        [JsonProperty(PropertyName = "nextRunTime")]
        public System.DateTime? NextRunTime { get; set; }

        /// <summary>
        /// Gets or sets information about the most recent job under the job
        /// schedule.
        /// </summary>
        /// <remarks>
        /// This property is present only if the at least one job has run under
        /// the schedule.
        /// </remarks>
        [JsonProperty(PropertyName = "recentJob")]
        public RecentJob RecentJob { get; set; }

        /// <summary>
        /// Gets or sets the time at which the schedule ended.
        /// </summary>
        /// <remarks>
        /// This property is set only if the job schedule is in the completed
        /// state.
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

    }
}
