
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

// Data Block Descriptor: Color Point Descriptor Definition
// •———————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                  Lenght              Description                            |
// •———————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Additional Color      ColorPointInfo      Note:  See ColorPoint(KnownColorPoint) |
// |              Point 1                                                                          |
// •———————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Additional Color      ColorPointInfo      Note:  See ColorPoint(KnownColorPoint) |
// |              Point 2                                                                          |
// •———————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.ColorPointData" />.
/// </summary> 
internal sealed class ColorPointDataDescriptor : BaseDataSection
{
    #region private enumerations

    /// <summary>
    ///  Known colors for this block.
    /// </summary> 
    private enum KnownColorPoint
    {
        /// <summary>
        /// Red color
        /// </summary>
        Point1,

        /// <summary>
        /// Green color
        /// </summary>
        Point2
    }

    #endregion

    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Dictionary<KnownColorPoint, ColorPointDataDescriptorItem> _colorPointTable;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="ColorPointDataDescriptor"/> class with the data of this block untreated.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    public ColorPointDataDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value that represents a dictionary of color point dictionary.
    /// </summary>
    /// <value>
    /// Dictionary containing the pair color point / Value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Dictionary<KnownColorPoint, ColorPointDataDescriptorItem> ColorPointTable
    {
        get
        {
            if (_colorPointTable != null)
            {
                return _colorPointTable;
            }

            _colorPointTable = new Dictionary<KnownColorPoint, ColorPointDataDescriptorItem>();
            PopulatesAdditionalColorPointTable(_colorPointTable);
            return _colorPointTable;
        }
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Point1, ColorPoint(KnownColorPoint.Point1));
        properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Point2, ColorPoint(KnownColorPoint.Point2));
    }

    #endregion


    #region EDID 1.4 Specification

    /// <summary>
    /// Returns the value that contains the specified key.
    /// </summary>
    /// <param name="colorPoint">Color point to be recovere.</param>
    /// <returns>
    /// Value of the specified timing
    /// </returns>
    private ColorPointDataDescriptorItem ColorPoint(KnownColorPoint colorPoint)
    {
        ColorPointDataDescriptorItem result;

        try
        {
            result = ColorPointTable[colorPoint];
        }
        catch (KeyNotFoundException)
        {
            return null;
        }

        return result;
    }

    /// <summary>
    /// Returns a value that represents the color point dictionary.
    /// </summary>
    /// <param name="colorPointDictionary">Color point dictionary.</param>
    private void PopulatesAdditionalColorPointTable(IDictionary<KnownColorPoint, ColorPointDataDescriptorItem> colorPointDictionary)
    {
        var colorPointArray = new byte[0x05];
        var sectionDataArray = RawData.ToArray();

        for (int n = 0, i = 0x05; i < 0x09; i += 0x05)
        {
            Array.Copy(sectionDataArray, i, colorPointArray, 0x00, 0x04);
            var colorPointCollection = new ReadOnlyCollection<byte>(colorPointArray);
            var colorPoint = new ColorPointDataDescriptorItem(colorPointCollection);
            colorPointDictionary.Add((KnownColorPoint)n, colorPoint);
            n++;
        }
    }

    #endregion
}
