
namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // Data Block Descriptor: Established Timings III Descriptor Definition
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Revision Number           BYTE        0ah, other values reserved.              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Resolutions 0             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 640 x 350 @ 85 Hz        |
    // |                                                    _ 1 _ _ _ _ _ _ 640 x 400 @ 85 Hz        |
    // |                                                    _ _ 1 _ _ _ _ _ 720 x 400 @ 85 Hz        |
    // |                                                    _ _ _ 1 _ _ _ _ 640 x 480 @ 85 Hz        |
    // |                                                    _ _ _ _ 1 _ _ _ 848 x 480 @ 60 Hz        |
    // |                                                    _ _ _ _ _ 1 _ _ 800 x 600 @ 85 Hz        |
    // |                                                    _ _ _ _ _ _ 1 _ 1024 x 768 @ 85 Hz       |
    // |                                                    _ _ _ _ _ _ _ 1 1152 x 864 @ 75 Hz       |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Resolutions 1             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 1280 x 768 @ 60 Hz (RB)  |
    // |                                                    _ 1 _ _ _ _ _ _ 1280 x 768 @ 60 Hz       |
    // |                                                    _ _ 1 _ _ _ _ _ 1280 x 768 @ 75 Hz       |
    // |                                                    _ _ _ 1 _ _ _ _ 1280 x 768 @ 85 Hz       |
    // |                                                    _ _ _ _ 1 _ _ _ 1280 x 960 @ 60 Hz       |
    // |                                                    _ _ _ _ _ 1 _ _ 1280 x 960 @ 85 Hz       |
    // |                                                    _ _ _ _ _ _ 1 _ 1280 x 1024 @ 60 Hz      |
    // |                                                    _ _ _ _ _ _ _ 1 1280 x 1024 @ 85 Hz      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Resolutions 2             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 1360 x 768 @ 60 Hz       |
    // |                                                    _ 1 _ _ _ _ _ _ 1440 x 900 @ 60 Hz (RB)  |
    // |                                                    _ _ 1 _ _ _ _ _ 1440 x 900 @ 60 Hz       |
    // |                                                    _ _ _ 1 _ _ _ _ 1440 x 900 @ 75 Hz       |
    // |                                                    _ _ _ _ 1 _ _ _ 1440 x 900 @ 85 Hz       |
    // |                                                    _ _ _ _ _ 1 _ _ 1400 x 1050 @ 60 Hz (RB) |
    // |                                                    _ _ _ _ _ _ 1 _ 1400 x 1050 @ 60 Hz      |
    // |                                                    _ _ _ _ _ _ _ 1 1400 x 1050 @ 75 Hz      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Resolutions 3             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 1400 x 1050 @ 85 Hz      |
    // |                                                    _ 1 _ _ _ _ _ _ 1680 x 1050 @ 60 Hz (RB) |
    // |                                                    _ _ 1 _ _ _ _ _ 1680 x 1050 @ 60 Hz      |
    // |                                                    _ _ _ 1 _ _ _ _ 1680 x 1050 @ 75 Hz      |
    // |                                                    _ _ _ _ 1 _ _ _ 1680 x 1050 @ 85 Hz      |
    // |                                                    _ _ _ _ _ 1 _ _ 1600 x 1200 @ 60 Hz      |
    // |                                                    _ _ _ _ _ _ 1 _ 1600 x 1200 @ 65 Hz      |
    // |                                                    _ _ _ _ _ _ _ 1 1600 x 1200 @ 70 Hz      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Resolutions 4             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 1600 x 1200 @ 75 Hz      |
    // |                                                    _ 1 _ _ _ _ _ _ 1600 x 1200 @ 85 Hz      |
    // |                                                    _ _ 1 _ _ _ _ _ 1792 x 1344 @ 60 Hz      |
    // |                                                    _ _ _ 1 _ _ _ _ 1792 x 1344 @ 75 Hz      |
    // |                                                    _ _ _ _ 1 _ _ _ 1856 x 1392 @ 60 Hz      |
    // |                                                    _ _ _ _ _ 1 _ _ 1856 x 1392 @ 75 Hz      |
    // |                                                    _ _ _ _ _ _ 1 _ 1920 x 1200 @ 60 Hz (RB) |
    // |                                                    _ _ _ _ _ _ _ 1 1920 x 1200 @ 60 Hz      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Resolutions 5             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ 0 0 0 0 1920 x 1200 @ 75 Hz      |
    // |                                                    _ 1 _ _ 0 0 0 0 1920 x 1200 @ 85 Hz      |
    // |                                                    _ _ 1 _ 0 0 0 0 1920 x 1440 @ 60 Hz      |
    // |                                                    _ _ _ 1 0 0 0 0 1920 x 1440 @ 75 Hz      |
    // |                                                    _ _ _ _ 0 0 0 0 Reserved bits: set 0000h |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h -> 0bh   Future resolutions        5 BYTEs     Shall be set to '00h' each byte.         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.EstablishedTimingsIII"/>.
    /// </summary> 
    internal sealed class EstablishedTimingsIIIDescriptor : BaseDataSection
    {
        #region constructor/s

        #region [public] EstablishedTimingsIIIDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data of this block untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="EstablishedTimingsIIIDescriptor"/> class with the data of this block untreated.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        public EstablishedTimingsIIIDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) Revision: Gets a value representing 'Revision Number' field
        /// <summary>
        /// Gets a value representing <c>Revision Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Revision => RawData[0x00];
        #endregion

        #region Resolutions 0

        #region [private] (byte) Resolutions0: Gets a value representing 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Resolutions0 => RawData[0x01];
        #endregion

        #region [private] (bool) Is640X350X85: Gets a value representing the '640 x 350 @ 85 Hz' characteristic of 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing the <c>640 x 350 @ 85 Hz</c> characteristic of <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is640X350X85 => Resolutions0.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (bool) Is640X400X85: Gets a value representing the '640 x 400 @ 85 Hz' characteristic of 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing the <c>640 x 400 @ 85 Hz</c> characteristic of <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is640X400X85 => Resolutions0.CheckBit(Bits.Bit06);
        #endregion

        #region [private] (bool) Is720X400X85: Gets a value representing the '720 x 400 @ 85 Hz' characteristic of 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing the <c>720 x 400 @ 85 Hz</c> characteristic of <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is720X400X85 => Resolutions0.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (bool) Is640X480X85: Gets a value representing the '640 x 480 @ 85 Hz' characteristic of 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing the <c>640 x 480 @ 85 Hz</c> characteristic of <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is640X480X85 => Resolutions0.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (bool) Is848X480X60: Gets a value representing the '848 x 480 @ 60 Hz' characteristic of 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing the <c>848 x 480 @ 60 Hz</c> characteristic of <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is848X480X60 => Resolutions0.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) Is800X600X85: Gets a value representing the '800 x 600 @ 85 Hz' characteristic of 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing the <c>800 x 600 @ 85 Hz</c> characteristic of <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is800X600X85 => Resolutions0.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) Is1024X768X85: Gets a value representing the '1024 x 768 @ 85 Hz' characteristic of 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing the <c>1024 x 768 @ 85 Hz</c> characteristic of <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1024X768X85 => Resolutions0.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) Is1152X864X75: Gets a value representing the '1152 x 864 @ 75 Hz' characteristic of 'Resolutions 0' field
        /// <summary>
        /// Gets a value representing the <c>1152 x 864 @ 75 Hz</c> characteristic of <c>Resolutions 0</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1152X864X75 => Resolutions0.CheckBit(Bits.Bit00);
        #endregion

        #endregion

        #region Resolutions 1

        #region [private] (byte) Resolutions1: Gets a value representing 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Resolutions1 => RawData[0x02];
        #endregion

        #region [private] (bool) Is1280X768X60Rb: Gets a value representing the '1280 x 768 @ 60 Hz Reduce Blanking' characteristic of 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 768 @ 60 Hz Reduce Blanking</c> characteristic of <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280X768X60Rb => Resolutions1.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (bool) Is1280X768X60: Gets a value representing the '1280 x 768 @ 60 Hz' characteristic of 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 768 @ 60 Hz</c> characteristic of <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280X768X60 => Resolutions1.CheckBit(Bits.Bit06);
        #endregion

        #region [private] (bool) Is1280X768X75: Gets a value representing the '1280 x 768 @ 75 Hz' characteristic of 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 768 @ 75 Hz</c> characteristic of <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280X768X75 => Resolutions1.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (bool) Is1280X768X85: Gets a value representing the '1280 x 768 @ 85 Hz' characteristic of 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 768 @ 85 Hz</c> characteristic of <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280X768X85 => Resolutions1.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (bool) Is1280X768X85: Gets a value representing the '1280 x 960 @ 60 Hz' characteristic of 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 960 @ 60 Hz</c> characteristic of <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280X960X60 => Resolutions1.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) Is1280X960X85: Gets a value representing the '1280 x 960 @ 85 Hz' characteristic of 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 960 @ 85 Hz</c> characteristic of <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280X960X85 => Resolutions1.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) Is1280X1024X60: Gets a value representing the '1280 x 1024 @ 60 Hz' characteristic of 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 1024 @ 60 Hz</c> characteristic of <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280X1024X60 => Resolutions1.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) Is1280X1024X85: Gets a value representing the '1280 x 1024 @ 85 Hz' characteristic of 'Resolutions 1' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 1024 @ 85 Hz</c> characteristic of <c>Resolutions 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280X1024X85 => Resolutions1.CheckBit(Bits.Bit00);
        #endregion

        #endregion

        #region Resolutions 2

        #region [private] (byte) Resolutions2: Gets a value representing 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Resolutions2 => RawData[0x03];
        #endregion

        #region [private] (bool) Is1280X1024X85: Gets a value representing the '1280 x 768 @ 60 Hz' characteristic of 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing the <c>1280 x 768 @ 60 Hz</c> characteristic of <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1360X768X60 => Resolutions2.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (bool) Is1440X900X60Rb: Gets a value representing the '1440 x 900 @ 60 Hz Reduce Blanking' characteristic of 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing the <c>1440 x 900 @ 60 Hz Reduce Blanking</c> characteristic of <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1440X900X60Rb => Resolutions2.CheckBit(Bits.Bit06);
        #endregion

        #region [private] (bool) Is1440X900X60: Gets a value representing the '1440 x 900 @ 60 Hz Reduce Blanking' characteristic of 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing the <c>1440 x 900 @ 60 Hz</c> characteristic of <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1440X900X60 => Resolutions2.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (bool) Is1440X900X75: Gets a value representing the '1440 x 900 @ 75 Hz' characteristic of 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing the <c>1440 x 900 @ 75 Hz</c> characteristic of <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1440X900X75 => Resolutions2.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (bool) Is1440X900X75: Gets a value representing the '1440 x 900 @ 85 Hz' characteristic of 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing the <c>1440 x 900 @ 85 Hz</c> characteristic of <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1440X900X85 => Resolutions2.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) Is1400X1050X60Rb: Gets a value representing the '1400 x 1050 @ 60 Hz Reduce Blanking' characteristic of 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing the <c>1400 x 1050 @ 60 Hz Reduce Blanking</c> characteristic of <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1400X1050X60Rb => Resolutions2.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) Is1400X1050X60: Gets a value representing the '1400 x 1050 @ 60 Hz' characteristic of 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing the <c>1400 x 1050 @ 60 Hz</c> characteristic of <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1400X1050X60 => Resolutions2.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) Is1400X1050X75: Gets a value representing the '1400 x 1050 @ 75 Hz' characteristic of 'Resolutions 2' field
        /// <summary>
        /// Gets a value representing the <c>1400 x 1050 @ 75 Hz</c> characteristic of <c>Resolutions 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1400X1050X75 => Resolutions2.CheckBit(Bits.Bit00);
        #endregion

        #endregion

        #region Resolutions 3

        #region [private] (byte) Resolutions3: Gets a value representing 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Resolutions3 => RawData[0x04];
        #endregion

        #region [private] (bool) Is1400X1050X85: Gets a value representing the '1400 x 1050 @ 85 Hz' characteristic of 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing the <c>1400 x 1050 @ 85 Hz</c> characteristic of <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1400X1050X85 => Resolutions3.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (bool) Is1680X1050X60Rb: Gets a value representing the '1680 x 1050 @ 60 Hz Reduce Blanking' characteristic of 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing the <c>1680 x 1050 @ 60 Hz Reduce Blanking</c> characteristic of <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1680X1050X60Rb => Resolutions3.CheckBit(Bits.Bit06);
        #endregion

        #region [private] (bool) Is1680X1050X60: Gets a value representing the '1680 x 1050 @ 60 Hz' characteristic of 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing the <c>1680 x 1050 @ 60 Hz</c> characteristic of <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1680X1050X60 => Resolutions3.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (bool) Is1680X1050X75: Gets a value representing the '1680 x 1050 @ 75 Hz' characteristic of 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing the <c>1680 x 1050 @ 75 Hz</c> characteristic of <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1680X1050X75 => Resolutions3.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (bool) Is1680X1050X85: Gets a value representing the '1680 x 1050 @ 85 Hz' characteristic of 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing the <c>1680 x 1050 @ 85 Hz</c> characteristic of <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1680X1050X85 => Resolutions3.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) Is1600X1200X60: Gets a value representing the '1600 x 1200 @ 60 Hz' characteristic of 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing the <c>1600 x 1200 @ 60 Hz</c> characteristic of <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1600X1200X60 => Resolutions3.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) Is1600X1200X65: Gets a value representing the '1600 x 1200 @ 65 Hz' characteristic of 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing the <c>1600 x 1200 @ 65 Hz</c> characteristic of <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1600X1200X65 => Resolutions3.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) Is1600X1200X65: Gets a value representing the '1600 x 1200 @ 70 Hz' characteristic of 'Resolutions 3' field
        /// <summary>
        /// Gets a value representing the <c>1600 x 1200 @ 70 Hz</c> characteristic of <c>Resolutions 3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1600X1200X70 => Resolutions3.CheckBit(Bits.Bit00);
        #endregion

        #endregion

        #region Resolutions 4

        #region [private] (byte) Resolutions4: Gets a value representing 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Resolutions4 => RawData[0x05];
        #endregion

        #region [private] (bool) Is1600X1200X75: Gets a value representing the '1600 x 1200 @ 75 Hz' characteristic of 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing the <c>1600 x 1200 @ 75 Hz</c> characteristic of <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1600X1200X75 => Resolutions4.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (bool) Is1600X1200X85: Gets a value representing the '1600 x 1200 @ 85 Hz' characteristic of 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing the <c>1600 x 1200 @ 85 Hz</c> characteristic of <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1600X1200X85 => Resolutions4.CheckBit(Bits.Bit06);
        #endregion

        #region [private] (bool) Is1792X1344X60: Gets a value representing the '1792 x 1344 @ 60 Hz' characteristic of 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing the <c>1792 x 1344 @ 60 Hz</c> characteristic of <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1792X1344X60 => Resolutions4.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (bool) Is1792X1344X75: Gets a value representing the '1792 x 1344 @ 75 Hz' characteristic of 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing the <c>1792 x 1344 @ 75 Hz</c> characteristic of <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1792X1344X75 => Resolutions4.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (bool) Is1856X1392X60: Gets a value representing the '1856 x 1392 @ 60 Hz' characteristic of 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing the <c>1856 x 1392 @ 60 Hz</c> characteristic of <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1856X1392X60 => Resolutions4.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) Is1856X1392X75: Gets a value representing the '1856 x 1392 @ 75 Hz' characteristic of 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing the <c>1856 x 1392 @ 75 Hz</c> characteristic of <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1856X1392X75 => Resolutions4.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) Is1920X1200X60Rb: Gets a value representing the '1920 x 1200 @ 60 Hz Reduce Blanking' characteristic of 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing the <c>1920 x 1200 @ 60 Hz Reduce Blanking</c> characteristic of <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1920X1200X60Rb => Resolutions4.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) Is1920X1200X60: Gets a value representing the '1920 x 1200 @ 60 Hz' characteristic of 'Resolutions 4' field
        /// <summary>
        /// Gets a value representing the <c>1920 x 1200 @ 60 Hz</c> characteristic of <c>Resolutions 4</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1920X1200X60 => Resolutions4.CheckBit(Bits.Bit00);
        #endregion

        #endregion

        #region Resolutions 5

        #region [private] (byte) Resolutions5: Gets a value representing 'Resolutions 5' field
        /// <summary>
        /// Gets a value representing <c>Resolutions 5</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Resolutions5 => RawData[0x06];
        #endregion

        #region [private] (bool) Is1920X1200X75: Gets a value representing the '1920 x 1200 @ 75 Hz' characteristic of 'Resolutions 5' field
        /// <summary>
        /// Gets a value representing the <c>1920 x 1200 @ 75 Hz</c> characteristic of <c>Resolutions 5</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1920X1200X75 => Resolutions5.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (bool) Is1920X1200X85: Gets a value representing the '1920 x 1200 @ 85 Hz' characteristic of 'Resolutions 5' field
        /// <summary>
        /// Gets a value representing the <c>1920 x 1200 @ 85 Hz</c> characteristic of <c>Resolutions 5</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1920X1200X85 => Resolutions5.CheckBit(Bits.Bit06);
        #endregion

        #region [private] (bool) Is1920X1440X60: Gets a value representing the '1920 x 1440 @ 60 Hz' characteristic of 'Resolutions 5' field
        /// <summary>
        /// Gets a value representing the <c>1920 x 1440 @ 60 Hz</c> characteristic of <c>Resolutions 5</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1920X1440X60 => Resolutions5.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (bool) Is1920X1440X75: Gets a value representing the '1920 x 1440 @ 75 Hz' characteristic of 'Resolutions 5' field
        /// <summary>
        /// Gets a value representing the <c>1920 x 1440 @ 75 Hz</c> characteristic of <c>Resolutions 5</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1920X1440X75 => Resolutions5.CheckBit(Bits.Bit04);
        #endregion

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
            properties.Add(EedidProperty.Edid.DataBlock.Definition.EstablishedTimingsIII.Revision, Revision);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.EstablishedTimingsIII.Resolutions, GetResolutionCollection());
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] (ReadOnlyCollection<MonitorResolutionInfo>) GetResolutionCollection(): Gets a read-only list that contains the available resolutions
        /// <summary>
        /// Gets a read-only collection that contains the available resolutions.
        /// </summary>
        /// <returns>
        /// A Read-only collection that contains the available resolutions.
        /// </returns>
        private ReadOnlyCollection<MonitorResolutionInfo> GetResolutionCollection()
        {
            var items = new List<MonitorResolutionInfo>();

            if (Is640X350X85)
            {
                items.Add(new MonitorResolutionInfo(640, 350, 85, ""));
            }

            if (Is640X400X85)
            {
                items.Add(new MonitorResolutionInfo(640, 400, 85, ""));
            }

            if (Is640X480X85)
            {
                items.Add(new MonitorResolutionInfo(640, 480, 85, ""));
            }

            if (Is720X400X85)
            {
                items.Add(new MonitorResolutionInfo(720, 400, 85, ""));
            }

            if (Is800X600X85)
            {
                items.Add(new MonitorResolutionInfo(800, 600, 85, ""));
            }

            if (Is848X480X60)
            {
                items.Add(new MonitorResolutionInfo(848, 480, 60, ""));
            }

            if (Is1024X768X85)
            {
                items.Add(new MonitorResolutionInfo(1024, 768, 85, ""));
            }

            if (Is1152X864X75)
            {
                items.Add(new MonitorResolutionInfo(1152, 864, 75, ""));
            }

            if (Is1280X768X60)
            {
                items.Add(new MonitorResolutionInfo(1280, 768, 60, ""));
            }

            if (Is1280X768X60Rb)
            {
                items.Add(new MonitorResolutionInfo(1280, 768, 60, true, ""));
            }

            if (Is1280X768X75)
            {
                items.Add(new MonitorResolutionInfo(1280, 768, 75, ""));
            }

            if (Is1280X768X85)
            {
                items.Add(new MonitorResolutionInfo(1280, 768, 85, ""));
            }

            if (Is1280X960X60)
            {
                items.Add(new MonitorResolutionInfo(1280, 960, 60, ""));
            }

            if (Is1280X960X85)
            {
                items.Add(new MonitorResolutionInfo(1280, 960, 85, ""));
            }

            if (Is1280X1024X60)
            {
                items.Add(new MonitorResolutionInfo(1280, 1024, 60, ""));
            }

            if (Is1280X1024X85)
            {
                items.Add(new MonitorResolutionInfo(1280, 1024, 85, ""));
            }

            if (Is1360X768X60)
            {
                items.Add(new MonitorResolutionInfo(1360, 768, 60, ""));
            }

            if (Is1400X1050X60)
            {
                items.Add(new MonitorResolutionInfo(1400, 1050, 60, ""));
            }

            if (Is1400X1050X60Rb)
            {
                items.Add(new MonitorResolutionInfo(1400, 1050, 60, true, ""));
            }

            if (Is1400X1050X75)
            {
                items.Add(new MonitorResolutionInfo(1400, 1050, 75, ""));
            }

            if (Is1400X1050X85)
            {
                items.Add(new MonitorResolutionInfo(1400, 1050, 85, ""));
            }

            if (Is1440X900X60)
            {
                items.Add(new MonitorResolutionInfo(1440, 900, 60, ""));
            }

            if (Is1440X900X60Rb)
            {
                items.Add(new MonitorResolutionInfo(1440, 900, 60, true, ""));
            }

            if (Is1440X900X75)
            {
                items.Add(new MonitorResolutionInfo(1440, 900, 75, ""));
            }

            if (Is1440X900X85)
            {
                items.Add(new MonitorResolutionInfo(1440, 900, 85, ""));
            }

            if (Is1600X1200X60)
            {
                items.Add(new MonitorResolutionInfo(1600, 1200, 60, ""));
            }

            if (Is1600X1200X65)
            {
                items.Add(new MonitorResolutionInfo(1600, 1200, 65, ""));
            }

            if (Is1600X1200X70)
            {
                items.Add(new MonitorResolutionInfo(1600, 1200, 70, ""));
            }

            if (Is1600X1200X75)
            {
                items.Add(new MonitorResolutionInfo(1600, 1200, 75, ""));
            }

            if (Is1600X1200X85)
            {
                items.Add(new MonitorResolutionInfo(1600, 1200, 85, ""));
            }

            if (Is1680X1050X60)
            {
                items.Add(new MonitorResolutionInfo(1680, 1050, 60, ""));
            }

            if (Is1680X1050X60Rb)
            {
                items.Add(new MonitorResolutionInfo(1680, 1050, 60, true, ""));
            }

            if (Is1680X1050X75)
            {
                items.Add(new MonitorResolutionInfo(1680, 1050, 75, ""));
            }

            if (Is1680X1050X85)
            {
                items.Add(new MonitorResolutionInfo(1680, 1050, 85, ""));
            }

            if (Is1792X1344X60)
            {
                items.Add(new MonitorResolutionInfo(1792, 1344, 60, ""));
            }

            if (Is1792X1344X75)
            {
                items.Add(new MonitorResolutionInfo(1792, 1344, 75, ""));
            }

            if (Is1856X1392X60)
            {
                items.Add(new MonitorResolutionInfo(1856, 1392, 60, ""));
            }

            if (Is1856X1392X75)
            {
                items.Add(new MonitorResolutionInfo(1856, 1392, 75, ""));
            }

            if (Is1920X1200X60)
            {
                items.Add(new MonitorResolutionInfo(1920, 1200, 60, ""));
            }

            if (Is1920X1200X60Rb)
            {
                items.Add(new MonitorResolutionInfo(1920, 1200, 60, true, ""));
            }

            if (Is1920X1200X75)
            {
                items.Add(new MonitorResolutionInfo(1920, 1200, 75, ""));
            }

            if (Is1920X1200X85)
            {
                items.Add(new MonitorResolutionInfo(1920, 1200, 85, ""));
            }

            if (Is1920X1440X60)
            {
                items.Add(new MonitorResolutionInfo(1920, 1440, 60, ""));
            }

            if (Is1920X1440X75)
            {
                items.Add(new MonitorResolutionInfo(1920, 1440, 75, ""));
            }

            return items.AsReadOnly();
        }

        #endregion

        #endregion
    }
}
