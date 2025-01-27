// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>
    /// The properties of a resource currently being monitored by the Elastic monitor resource.
    /// </summary>
    public partial class MonitoredResource :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IMonitoredResource,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IMonitoredResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ARM id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ReasonForLogsStatus" /> property.</summary>
        private string _reasonForLogsStatus;

        /// <summary>Reason for why the resource is sending logs (or why it is not sending).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string ReasonForLogsStatus { get => this._reasonForLogsStatus; set => this._reasonForLogsStatus = value; }

        /// <summary>Backing field for <see cref="SendingLog" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.SendingLogs? _sendingLog;

        /// <summary>
        /// Flag indicating the status of the resource for sending logs operation to Elastic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.SendingLogs? SendingLog { get => this._sendingLog; set => this._sendingLog = value; }

        /// <summary>Creates an new <see cref="MonitoredResource" /> instance.</summary>
        public MonitoredResource()
        {

        }
    }
    /// The properties of a resource currently being monitored by the Elastic monitor resource.
    public partial interface IMonitoredResource :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>The ARM id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ARM id of the resource.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Reason for why the resource is sending logs (or why it is not sending).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reason for why the resource is sending logs (or why it is not sending).",
        SerializedName = @"reasonForLogsStatus",
        PossibleTypes = new [] { typeof(string) })]
        string ReasonForLogsStatus { get; set; }
        /// <summary>
        /// Flag indicating the status of the resource for sending logs operation to Elastic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag indicating the status of the resource for sending logs operation to Elastic.",
        SerializedName = @"sendingLogs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.SendingLogs) })]
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.SendingLogs? SendingLog { get; set; }

    }
    /// The properties of a resource currently being monitored by the Elastic monitor resource.
    internal partial interface IMonitoredResourceInternal

    {
        /// <summary>The ARM id of the resource.</summary>
        string Id { get; set; }
        /// <summary>Reason for why the resource is sending logs (or why it is not sending).</summary>
        string ReasonForLogsStatus { get; set; }
        /// <summary>
        /// Flag indicating the status of the resource for sending logs operation to Elastic.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.SendingLogs? SendingLog { get; set; }

    }
}