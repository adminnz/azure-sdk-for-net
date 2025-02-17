// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Container group log analytics information.
    /// </summary>
    public partial class LogAnalytics
    {
        /// <summary>
        /// Initializes a new instance of the LogAnalytics class.
        /// </summary>
        public LogAnalytics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogAnalytics class.
        /// </summary>
        /// <param name="workspaceId">The workspace id for log
        /// analytics</param>
        /// <param name="workspaceKey">The workspace key for log
        /// analytics</param>
        /// <param name="logType">The log type to be used. Possible values
        /// include: 'ContainerInsights', 'ContainerInstanceLogs'</param>
        /// <param name="metadata">Metadata for log analytics.</param>
        /// <param name="workspaceResourceId">The workspace resource id for log
        /// analytics</param>
        public LogAnalytics(string workspaceId, string workspaceKey, string logType = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>), IDictionary<string, string> workspaceResourceId = default(IDictionary<string, string>))
        {
            WorkspaceId = workspaceId;
            WorkspaceKey = workspaceKey;
            LogType = logType;
            Metadata = metadata;
            WorkspaceResourceId = workspaceResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the workspace id for log analytics
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets the workspace key for log analytics
        /// </summary>
        [JsonProperty(PropertyName = "workspaceKey")]
        public string WorkspaceKey { get; set; }

        /// <summary>
        /// Gets or sets the log type to be used. Possible values include:
        /// 'ContainerInsights', 'ContainerInstanceLogs'
        /// </summary>
        [JsonProperty(PropertyName = "logType")]
        public string LogType { get; set; }

        /// <summary>
        /// Gets or sets metadata for log analytics.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the workspace resource id for log analytics
        /// </summary>
        [JsonProperty(PropertyName = "workspaceResourceId")]
        public IDictionary<string, string> WorkspaceResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WorkspaceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkspaceId");
            }
            if (WorkspaceKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkspaceKey");
            }
        }
    }
}
