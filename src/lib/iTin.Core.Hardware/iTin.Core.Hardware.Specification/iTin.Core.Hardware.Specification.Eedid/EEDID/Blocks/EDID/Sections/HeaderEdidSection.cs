
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    // EDID Section: Header
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Header                    8 BYTES     Must be: 00h, ffh, ffh, ffh, ffh, ffh, ffh, 00h     |
    // |                                                    Note: See Header                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.Header" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    internal sealed class HeaderEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] HeaderEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.HeaderEdidSection" /> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public HeaderEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte[]) Signature: Gets a value representing the 'Signature' field
        /// <summary>
        /// Gets a value representing the <c>Signature</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] Signature => RawData.Extract(0x00, 0x08).ToArray();
        #endregion

        #region [private] (bool) IsValid: Gets a value representing the 'IsValid' field
        /// <summary>
        /// Gets a value representing the <c>IsValid</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsValid => Signature.SequenceEqual(new byte[] { 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00 });
        #endregion

        #endregion

        #region protected overide methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            properties.Add(EedidProperty.Edid.Header.IsValid, IsValid);
            properties.Add(EedidProperty.Edid.Header.Signature, new ReadOnlyCollection<byte>(Signature));
        }
        #endregion

        #endregion
    }
}
