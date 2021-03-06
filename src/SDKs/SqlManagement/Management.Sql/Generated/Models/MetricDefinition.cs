// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A database metric definition.
    /// </summary>
    public partial class MetricDefinition
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        /// <param name="name">The name information for the metric.</param>
        /// <param name="primaryAggregationType">The primary aggregation type
        /// defining how metric values are displayed. Possible values include:
        /// 'None', 'Average', 'Count', 'Minimum', 'Maximum', 'Total'</param>
        /// <param name="resourceUri">The resource uri of the database.</param>
        /// <param name="unit">The unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond'</param>
        /// <param name="metricAvailabilities">The list of database metric
        /// availabities for the metric.</param>
        public MetricDefinition(MetricName name = default(MetricName), string primaryAggregationType = default(string), string resourceUri = default(string), string unit = default(string), IList<MetricAvailability> metricAvailabilities = default(IList<MetricAvailability>))
        {
            Name = name;
            PrimaryAggregationType = primaryAggregationType;
            ResourceUri = resourceUri;
            Unit = unit;
            MetricAvailabilities = metricAvailabilities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name information for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public MetricName Name { get; private set; }

        /// <summary>
        /// Gets the primary aggregation type defining how metric values are
        /// displayed. Possible values include: 'None', 'Average', 'Count',
        /// 'Minimum', 'Maximum', 'Total'
        /// </summary>
        [JsonProperty(PropertyName = "primaryAggregationType")]
        public string PrimaryAggregationType { get; private set; }

        /// <summary>
        /// Gets the resource uri of the database.
        /// </summary>
        [JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; private set; }

        /// <summary>
        /// Gets the unit of the metric. Possible values include: 'Count',
        /// 'Bytes', 'Seconds', 'Percent', 'CountPerSecond', 'BytesPerSecond'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets the list of database metric availabities for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "metricAvailabilities")]
        public IList<MetricAvailability> MetricAvailabilities { get; private set; }

    }
}
