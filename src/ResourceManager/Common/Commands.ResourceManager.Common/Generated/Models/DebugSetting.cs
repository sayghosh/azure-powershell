// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    using Azure;
    using Management;
    using Internal;
    using Resources;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DebugSetting
    {
        /// <summary>
        /// Initializes a new instance of the DebugSetting class.
        /// </summary>
        public DebugSetting() { }

        /// <summary>
        /// Initializes a new instance of the DebugSetting class.
        /// </summary>
        /// <param name="detailLevel">Specifies the type of information to log
        /// for debugging. The permitted values are none, requestContent,
        /// responseContent, or both requestContent and responseContent
        /// separated by a comma. The default is none. When setting this value,
        /// carefully consider the type of information you are passing in
        /// during deployment. By logging information about the request or
        /// response, you could potentially expose sensitive data that is
        /// retrieved through the deployment operations.</param>
        public DebugSetting(string detailLevel = default(string))
        {
            DetailLevel = detailLevel;
        }

        /// <summary>
        /// Gets or sets specifies the type of information to log for
        /// debugging. The permitted values are none, requestContent,
        /// responseContent, or both requestContent and responseContent
        /// separated by a comma. The default is none. When setting this value,
        /// carefully consider the type of information you are passing in
        /// during deployment. By logging information about the request or
        /// response, you could potentially expose sensitive data that is
        /// retrieved through the deployment operations.
        /// </summary>
        [JsonProperty(PropertyName = "detailLevel")]
        public string DetailLevel { get; set; }

    }
}
