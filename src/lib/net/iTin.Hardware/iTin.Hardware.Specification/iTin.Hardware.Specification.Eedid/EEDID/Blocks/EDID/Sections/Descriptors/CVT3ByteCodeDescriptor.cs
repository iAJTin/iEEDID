
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    // Data Block Descriptor: CVT 3 Byte Code Descriptor Definition
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                   |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Version                   BYTE        01h. Other values reserved.                   |
    // |              Number                                                                              |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h - 03h    CTV 3 Byte Code           3 BYTE      Prioridad más alta. If not defined (00 00 00) |
    // |              Descriptor with                       Note: See Priority(KnownCVT3ByteCodePriority) |
    // |              #1 Priority                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h - 06h    CTV 3 Byte Code           3 BYTE      If not defined (00 00 00)                     |
    // |              Descriptor with                       Note: See Priority(KnownCVT3ByteCodePriority) |
    // |              #2 Priority                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h - 09h    CTV 3 Byte Code           3 BYTE      If not defined (00 00 00)                     |
    // |              Descriptor with                       Note: See Priority(KnownCVT3ByteCodePriority) |
    // |              #3 Priority                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ah - 0ch    CTV 3 Byte Code           3 BYTE      Prioridad más baja. If not defined (00 00 00) |
    // |              Descriptor with                       Note: See Priority(KnownCVT3ByteCodePriority) |
    // |              #4 Priority                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.DataBlocks"/> section of type this block <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/>.
    /// </summary> 
    internal sealed class Cvt3ByteCodeDescriptor : BaseDataSection
    {
        #region private enumerations

        #region [private] (enum) KnownCVT3ByteCodePriority: Enumeration with the known priorities for this block
        /// <summary>
        /// Enumeration with the known priorities for this block.
        /// </summary> 
        private enum KnownCvt3ByteCodePriority
        {
            /// <summary>
            /// Priority 1 (The highest)
            /// </summary>
            Priority1,

            /// <summary>
            /// Priority 2
            /// </summary>
            Priority2,

            /// <summary>
            /// Priority 3
            /// </summary>
            Priority3,

            /// <summary>
            /// Priority 4 (The lowest)
            /// </summary>
            Priority4,
        }
        #endregion

        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDictionary<KnownCvt3ByteCodePriority, Cvt3ByteCodeDescriptorItem> _priorityTable;
        #endregion

        #region constructor/s

        #region [public] Cvt3ByteCodeDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data of this block untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="Cvt3ByteCodeDescriptor"/> class with the data of this block untreated.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        public Cvt3ByteCodeDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (Dictionary<KnownCVT3ByteCodePriority, CVT3ByteCodeDescriptorItem>) PriorityTable: Gets a value that represents a dictionary of priority dictionary
        /// <summary>
        /// Gets a value that represents a dictionary of priority dictionary.
        /// </summary>
        /// <value>
        /// Dictionary containing the pair Priority / Value.
        /// </value>e>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDictionary<KnownCvt3ByteCodePriority, Cvt3ByteCodeDescriptorItem> PriorityTable
        {
            get
            {
                if (_priorityTable != null)
                {
                    return _priorityTable;
                }

                _priorityTable = new Dictionary<KnownCvt3ByteCodePriority, Cvt3ByteCodeDescriptorItem>();
                PopulatesPriorityTable(_priorityTable);
                return _priorityTable;
            }
        }
        #endregion

        #region [private] (byte) VersionNumber: Gets a value representing 'Version Number' field
        /// <summary>
        /// Gets a value representing <c>Version Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VersionNumber => RawData[0x00];
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.VersionNumber, VersionNumber);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Priority1, Priority(KnownCvt3ByteCodePriority.Priority1));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Priority2, Priority(KnownCvt3ByteCodePriority.Priority2));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Priority3, Priority(KnownCvt3ByteCodePriority.Priority3));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Priority4, Priority(KnownCvt3ByteCodePriority.Priority4));
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] (CVT3ByteCodeDescriptorItem) Priority(KnownCVT3ByteCodePriority): Returns the value that contains the specified key
        /// <summary>
        /// Returns the value that contains the specified key.
        /// </summary>
        /// <param name="byteCode">Timing to be recovere.</param>
        /// <returns>
        /// Value of the specified timing
        /// </returns>
        private Cvt3ByteCodeDescriptorItem Priority(KnownCvt3ByteCodePriority byteCode)
        {
            Cvt3ByteCodeDescriptorItem result;

            try
            {
                result = PriorityTable[byteCode];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }

            return result;
        }
        #endregion

        #region [private] (void) PopulatesPriorityTable(IDictionary<KnownCVT3ByteCodePriority, CVT3ByteCodeDescriptorItem>): Returns a value that represents the priority dictionary
        /// <summary>
        /// Returns a value that represents the priority dictionary.
        /// </summary>
        /// <param name="priorityDictionary">Priority dictionary.</param>
        private void PopulatesPriorityTable(IDictionary<KnownCvt3ByteCodePriority, Cvt3ByteCodeDescriptorItem> priorityDictionary)
        {
            byte[] sectionDataArray = RawData.ToArray();

            for (int n = 0, i = 0x01; i < 0x0c; i += 0x03)
            {
                var priorityArray = new byte[0x03];
                Array.Copy(sectionDataArray, i, priorityArray, 0x00, 0x03);

                var priorityCollection = new ReadOnlyCollection<byte>(priorityArray);
                var priority = new Cvt3ByteCodeDescriptorItem(priorityCollection);
                priorityDictionary.Add((KnownCvt3ByteCodePriority)n, priority);
                n++;                     
            }
        }
        #endregion

        #endregion
    }
}
