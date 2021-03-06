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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SecurityAlertPolicyState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SecurityAlertPolicyState
    {
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class SecurityAlertPolicyStateEnumExtension
    {
        internal static string ToSerializedValue(this SecurityAlertPolicyState? value )  =>
            value == null ? null : (( SecurityAlertPolicyState )value).ToSerializedValue();

        internal static string ToSerializedValue(this SecurityAlertPolicyState value )
        {
            switch( value )
            {
                case SecurityAlertPolicyState.New:
                    return "New";
                case SecurityAlertPolicyState.Enabled:
                    return "Enabled";
                case SecurityAlertPolicyState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static SecurityAlertPolicyState? ParseSecurityAlertPolicyState( this string value )
        {
            switch( value )
            {
                case "New":
                    return SecurityAlertPolicyState.New;
                case "Enabled":
                    return SecurityAlertPolicyState.Enabled;
                case "Disabled":
                    return SecurityAlertPolicyState.Disabled;            }
            return null;
        }
    }
}
