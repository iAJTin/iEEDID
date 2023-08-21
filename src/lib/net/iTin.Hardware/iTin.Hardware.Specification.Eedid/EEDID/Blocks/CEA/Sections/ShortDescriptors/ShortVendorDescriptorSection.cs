
using System.Collections.ObjectModel;

using iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors;

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the Short Vendor Descriptor section of the Data Block Collection block.
/// </summary> 
internal sealed class ShortVendorDescriptorSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="ShortVendorDescriptorSection"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="sectionData">Raw data of this section.</param>
    public ShortVendorDescriptorSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        var vendorAllocationDataBlock = new VendorDataBlock(RawData);
        properties.Add(EedidProperty.Cea.DataBlock.Vendor.IEEERegistrationIdentifier, vendorAllocationDataBlock.IEEERegistrationIdentifier);
        properties.Add(EedidProperty.Cea.DataBlock.Vendor.PhysicalAddress, vendorAllocationDataBlock.PhysicalAddress);
        properties.Add(EedidProperty.Cea.DataBlock.Vendor.Flags, vendorAllocationDataBlock.Flags);
        properties.Add(EedidProperty.Cea.DataBlock.Vendor.MaxClock, vendorAllocationDataBlock.MaxClock);
        properties.Add(EedidProperty.Cea.DataBlock.Vendor.VendorPayload, vendorAllocationDataBlock.PayLoad);
    }

    #endregion
}
