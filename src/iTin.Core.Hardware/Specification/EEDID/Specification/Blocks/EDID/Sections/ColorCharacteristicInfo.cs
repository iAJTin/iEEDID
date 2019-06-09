﻿
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Drawing;

    using Helpers;
    using Helpers.Enumerations;

    // EDID Section Information: ColorCharacteristics -> ColorCharacteristicDetail
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                        Lenght      Description                                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Red/Green Low Order Bits    BYTE      Rx1 Rx0 Ry1 Ry0 Gx1 Gx0 Gy1 Gy0                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Blue/White Low Order Bits   BYTE      Bx1 Bx0 By1 By0 Wx1 Wx0 Wy1 Wy0                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Red-x High Order Bits       BYTE      Red-x: Bits 9 → 2                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Red-y High Order Bits       BYTE      Red-y: Bits 9 → 2                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Green-x Low Order Bits      BYTE      Green-x: Bits 9 → 2                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Green-y Low Order Bits      BYTE      Green-y: Bits 9 → 2                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Blue-x High Order Bits      BYTE      Blue-x: Bits 9 → 2                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Blue-y High Order Bits      BYTE      Blue-y: Bits 9 → 2                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          White-x High Order Bits     BYTE      White-x: Bits 9 → 2                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          White-y High Order Bits     BYTE      White-y: Bits 9 → 2                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.ColorCharacteristics" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary>
    sealed class ColorCharacteristicDetail : BaseDataSection
    {
        #region constructor/s

        #region [public] ColorCharacteristicDetail(ReadOnlyCollection<byte>, ColorManagementDataDescriptor.KnownColor): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.ColorCharacteristicDetail" /> class with the data in this section untreated.
        /// </summary>
        /// <param name="color">Color to get</param>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public ColorCharacteristicDetail(ReadOnlyCollection<byte> sectionData, ColorManagementDataDescriptor.KnownColor color) : base(sectionData)
        {
            var vCx = 0.0;
            var vCy = 0.0;

            var color1 = color;
            int cx = LogicHelper.Word((byte)((sectionData[0x00] >> (color1 == ColorManagementDataDescriptor.KnownColor.Red || color1 == ColorManagementDataDescriptor.KnownColor.Blue ? 6 : (color1 == ColorManagementDataDescriptor.KnownColor.Green || color1 == ColorManagementDataDescriptor.KnownColor.White ? 2 : 0)) & 0x03) << 6), sectionData[0x01]) >> 6;
            int cy = LogicHelper.Word((byte)((sectionData[0x00] >> (color1 == ColorManagementDataDescriptor.KnownColor.Red || color1 == ColorManagementDataDescriptor.KnownColor.Blue ? 4 : (color1 == ColorManagementDataDescriptor.KnownColor.Green || color1 == ColorManagementDataDescriptor.KnownColor.White ? 0 : 0)) & 0x03) << 6), sectionData[0x02]) >> 6;

            for (var i = 0; i <= 9; vCx += cx.CheckBit((Bits)i) ? System.Math.Pow(2, i - 10) : 0, vCy += cy.CheckBit((Bits)i) ? System.Math.Pow(2, i - 10) : 0, i++)
            {}

            Value = new PointF((float)vCx, (float)vCy);
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (PointF) Value: Gets a value that represents the color
        /// <summary>
        /// Gets a value that represents the color.
        /// </summary>
        /// <value>
        /// Value of the specified color.
        /// </value>
        public PointF Value { get; }
        #endregion

        #endregion
    }
}
