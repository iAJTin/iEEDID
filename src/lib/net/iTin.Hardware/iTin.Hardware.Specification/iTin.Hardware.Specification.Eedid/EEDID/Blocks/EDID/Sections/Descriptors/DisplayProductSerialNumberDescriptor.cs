
namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;

    // Data Block Descriptor: Display Product Serial Number Descriptor Definition
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
    // | Offset       Name                      Lenght      Description                                  |
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
    // | 00h -> 0ch   ASCII                     13 BYTEs    Up to 13 alphanumeric characters of a serial |
    // |              Text                                  number may be stored.                        |
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.DisplayProductSerialNumber"/>.
    /// </summary> 
    internal sealed class DisplayProductSerialNumberDescriptor : BaseDataSection
    {
        #region constructor/s

        #region [public] DisplayProductSerialNumberDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data of this block untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="DisplayProductSerialNumberDescriptor"/> class with the data of this block untreated.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        public DisplayProductSerialNumberDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            byte[] data = RawData.ToArray();
            properties.Add(EedidProperty.Edid.DataBlock.Definition.DisplayProductSerialNumber.Data, Encoding.ASCII.GetString(data, 0x00, data.Length));
        }
        #endregion

        #endregion
    }
}
