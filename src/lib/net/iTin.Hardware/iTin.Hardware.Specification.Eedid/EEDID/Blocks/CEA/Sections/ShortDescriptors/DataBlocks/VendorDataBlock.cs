﻿
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

/// <summary>
/// Structure <see cref="VendorDataBlock"/> that contains the logic to decode the data of a block of the type <see cref="ShortVendorDescriptorSection"/>.
/// </summary> 
internal readonly struct VendorDataBlock
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the structure <see cref="VendorDataBlock"/> specifying the data of this manufacturer block.
    /// </summary>
    /// <param name="vendorDataBlock">Datos de este bloque del fabricante.</param>
    public VendorDataBlock(ReadOnlyCollection<byte> vendorDataBlock)
    {
        byte[] vendorDataBlockArray = vendorDataBlock.ToArray();
        IEEERegistrationIdentifier = (vendorDataBlockArray.GetWord(0x01) << 8) | vendorDataBlockArray[0];
        PhysicalAddress = vendorDataBlockArray.GetWord(0x03);
        Flags = FlagCollection(vendorDataBlockArray[0x04]);
        MaxClock = vendorDataBlockArray[0x06] * 5;

        byte[] payLoadArray = vendorDataBlockArray.Extract((byte)0x02, (byte)(vendorDataBlockArray.Length - 0x02)).ToArray();
        PayLoad = new ReadOnlyCollection<byte>(payLoadArray);
    }
    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that contains the flags.
    /// </summary>
    /// <value>
    /// Flags.
    /// </value>
    public ReadOnlyCollection<string> Flags { get; }

    /// <summary>
    /// Gets IEEE Registration Identifier.
    /// </summary>
    /// <value>
    /// IEEE Registration Identifier.
    /// </value>
    public int IEEERegistrationIdentifier { get; }

    /// <summary>
    /// Gets Maximum TMDS clock.
    /// </summary>
    /// <value>
    /// Maximum TMDS clock.
    /// </value>
    public int MaxClock { get; }

    /// <summary>
    /// Gets a value that contains the manufacturer's data.
    /// </summary>
    /// <value>
    /// The manufacturer's data.
    /// </value>
    public ReadOnlyCollection<byte> PayLoad { get; }

    /// <summary>
    /// Gets the physical address.
    /// </summary>
    /// <value>
    /// Physical Address.
    /// </value>
    public int PhysicalAddress { get; }

    #endregion

    #region private static methods

    private static ReadOnlyCollection<string> FlagCollection(byte code)
    {
        var value1 = new[]
        {
            "DVI Dual Link"                   // 0x00
        };

        var value2 = new[]
        {
            "DC Y444",                        // 0x00
            "DC 30bit",
            "DC 36bit",
            "DC 48bit",
            "Support_Al (ACP & ISRx packets)" // 0x07
        };

        var items = new List<string>();

        for (byte i = 0x00; i <= 0x00; i++)
        {
            bool addFlag = code.CheckBit((Bits)i);
            if (addFlag)
            {
                items.Add(value1[i]);
            }
        }

        for (byte i = 0x03; i <= 0x07; i++)
        {
            var addFlag = code.CheckBit((Bits)i);
            if (addFlag)
            {
                items.Add(value2[i - 0x03]);
            }
        }

        return items.AsReadOnly();
    }

    #endregion
}
