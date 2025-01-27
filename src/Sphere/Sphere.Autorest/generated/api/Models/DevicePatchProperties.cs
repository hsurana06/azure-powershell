// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of device patch</summary>
    public partial class DevicePatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DeviceGroupId" /> property.</summary>
        private string _deviceGroupId;

        /// <summary>Device group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeviceGroupId { get => this._deviceGroupId; set => this._deviceGroupId = value; }

        /// <summary>Creates an new <see cref="DevicePatchProperties" /> instance.</summary>
        public DevicePatchProperties()
        {

        }
    }
    /// The properties of device patch
    public partial interface IDevicePatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Device group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device group id",
        SerializedName = @"deviceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceGroupId { get; set; }

    }
    /// The properties of device patch
    internal partial interface IDevicePatchPropertiesInternal

    {
        /// <summary>Device group id</summary>
        string DeviceGroupId { get; set; }

    }
}