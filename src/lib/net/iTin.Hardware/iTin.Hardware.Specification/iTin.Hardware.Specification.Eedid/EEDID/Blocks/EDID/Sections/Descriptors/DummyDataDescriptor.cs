
namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;

    // Data Block Descriptor: Dummy Data Descriptor Definition
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
    // | Offset       Name                      Lenght      Description                                  |
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
    // | 00h -> 0ch   Dummy Data                13 BYTEs    All bytes filled with 00h                    |
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.DummyData"/>.
    /// </summary> 
    internal sealed class DummyDataDescriptor : BaseDataSection
    {
        #region constructor/s

        #region [public] DummyDataDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data of this block untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="DummyDataDescriptor"/> class with the data of this block untreated.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        public DummyDataDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
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
            properties.Add(EedidProperty.Edid.DataBlock.Definition.DummyData.OriginalData, Encoding.ASCII.GetString(data, 0x00, data.Length));

            //byte[] rawData = RawData.ToArray();
            //string originalString = Encoding.ASCII.GetString(rawData, 0x00, rawData.Length);
            //string printableString = new string(originalString.Where(c => !char.IsControl(c)).ToArray());

            //properties.Add(EedidProperty.Edid.DataBlock.Definition.DummyData.OriginalData, originalString);
            //properties.Add(EedidProperty.Edid.DataBlock.Definition.DummyData.PrintableData, printableString);
        }
        #endregion

        #endregion
    }
}
