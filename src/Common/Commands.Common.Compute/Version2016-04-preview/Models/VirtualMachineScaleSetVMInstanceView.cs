// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version2016_04_preview.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The instance view of a virtual machine scale set VM.
    /// </summary>
    public partial class VirtualMachineScaleSetVMInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceView class.
        /// </summary>
        public VirtualMachineScaleSetVMInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceView class.
        /// </summary>
        /// <param name="platformUpdateDomain">The Update Domain count.</param>
        /// <param name="platformFaultDomain">The Fault Domain count.</param>
        /// <param name="rdpThumbPrint">The Remote desktop certificate
        /// thumbprint.</param>
        /// <param name="vmAgent">The VM Agent running on the virtual
        /// machine.</param>
        /// <param name="disks">The disks information.</param>
        /// <param name="extensions">The extensions information.</param>
        /// <param name="bootDiagnostics">Boot Diagnostics is a debugging
        /// feature which allows you to view Console Output and Screenshot to
        /// diagnose VM status. &lt;br&gt;&lt;br&gt; For Linux Virtual
        /// Machines, you can easily view the output of your console log.
        /// &lt;br&gt;&lt;br&gt; For both Windows and Linux virtual machines,
        /// Azure also enables you to see a screenshot of the VM from the
        /// hypervisor.</param>
        /// <param name="statuses">The resource status information.</param>
        /// <param name="placementGroupId">The placement group in which the VM
        /// is running. If the VM is deallocated it will not have a
        /// placementGroupId.</param>
        public VirtualMachineScaleSetVMInstanceView(int? platformUpdateDomain = default(int?), int? platformFaultDomain = default(int?), string rdpThumbPrint = default(string), VirtualMachineAgentInstanceView vmAgent = default(VirtualMachineAgentInstanceView), IList<DiskInstanceView> disks = default(IList<DiskInstanceView>), IList<VirtualMachineExtensionInstanceView> extensions = default(IList<VirtualMachineExtensionInstanceView>), BootDiagnosticsInstanceView bootDiagnostics = default(BootDiagnosticsInstanceView), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>), string placementGroupId = default(string))
        {
            PlatformUpdateDomain = platformUpdateDomain;
            PlatformFaultDomain = platformFaultDomain;
            RdpThumbPrint = rdpThumbPrint;
            VmAgent = vmAgent;
            Disks = disks;
            Extensions = extensions;
            BootDiagnostics = bootDiagnostics;
            Statuses = statuses;
            PlacementGroupId = placementGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Update Domain count.
        /// </summary>
        [JsonProperty(PropertyName = "platformUpdateDomain")]
        public int? PlatformUpdateDomain { get; set; }

        /// <summary>
        /// Gets or sets the Fault Domain count.
        /// </summary>
        [JsonProperty(PropertyName = "platformFaultDomain")]
        public int? PlatformFaultDomain { get; set; }

        /// <summary>
        /// Gets or sets the Remote desktop certificate thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "rdpThumbPrint")]
        public string RdpThumbPrint { get; set; }

        /// <summary>
        /// Gets or sets the VM Agent running on the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "vmAgent")]
        public VirtualMachineAgentInstanceView VmAgent { get; set; }

        /// <summary>
        /// Gets or sets the disks information.
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public IList<DiskInstanceView> Disks { get; set; }

        /// <summary>
        /// Gets or sets the extensions information.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<VirtualMachineExtensionInstanceView> Extensions { get; set; }

        /// <summary>
        /// Gets or sets boot Diagnostics is a debugging feature which allows
        /// you to view Console Output and Screenshot to diagnose VM status.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For Linux Virtual Machines,
        /// you can easily view the output of your console log.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For both Windows and Linux
        /// virtual machines, Azure also enables you to see a screenshot of the
        /// VM from the hypervisor.
        /// </summary>
        [JsonProperty(PropertyName = "bootDiagnostics")]
        public BootDiagnosticsInstanceView BootDiagnostics { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

        /// <summary>
        /// Gets or sets the placement group in which the VM is running. If the
        /// VM is deallocated it will not have a placementGroupId.
        /// </summary>
        [JsonProperty(PropertyName = "placementGroupId")]
        public string PlacementGroupId { get; set; }

    }
}