
using System.Collections.Generic;
using System.Collections.ObjectModel;

using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA
{
    /// <summary>
    /// Contains all availables section properties for a <see cref="CeaBlock"/> block.
    /// </summary>
    internal static class CeaProperty
    {
        #region [public] (enum) Information: Definition of properties for a section of type 'Information'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.Information"/>.
        /// </summary>
        public enum Information
        {
            [PropertyName("Revision")]
            [PropertyDescription("Revision")]
            [PropertyType(typeof(byte))]
            Revision,

            [PropertyName("Implemented")]
            [PropertyDescription("Implemented")]
            [PropertyType(typeof(string))]
            Implemented,
        }
        #endregion

        #region [public] (enum) MonitorSupport: Definition of properties for a section of type 'MonitorSupport'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.MonitorSupport"/>.
        /// </summary>
        public enum MonitorSupport
        {
            [PropertyName("Is Dvt Underscan")]
            [PropertyDescription("")]
            [PropertyType(typeof(bool))]
            IsDvtUnderscan,

            [PropertyName("Basic Audio Supported")]
            [PropertyDescription("")]
            [PropertyType(typeof(bool))]
            BasicAudioSupported,

            [PropertyName("YCbCr4:4:4 Supported")]
            [PropertyDescription("")]
            [PropertyType(typeof(bool))]
            YCbCr444Supported,

            [PropertyName("YCbCr4:2:2 Supported")]
            [PropertyDescription("")]
            [PropertyType(typeof(bool))]
            YCbCr422Supported,
        }
        #endregion

        #region [public] (enum) Checksum: Definition of properties for a section of type 'CheckSum'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.Checksum"/>.
        /// </summary>
        public enum Checksum
        {
            [PropertyName("Status")]
            [PropertyDescription("Status")]
            [PropertyType(typeof(bool))]
            Ok,

            [PropertyDescription("Checksum datablock value")]
            [PropertyType(typeof(byte))]
            [PropertyName("Value")]
            Value,
        }
        #endregion

        #region [public] (enum) DetailedTiming: Definition of properties for a section of type 'DetailedTimings'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.DetailedTiming"/>.
        /// </summary>
        public enum DetailedTiming
        {
            [PropertyName("Timings")]
            [PropertyDescription("Timings")]
            [PropertyType(typeof(List<SectionPropertiesTable>))]
            Timings,
        }
        #endregion

        #region [public] (enum) DetailedTimingDescriptor: Definition of properties for a section of type 'DetailedTimings'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.DetailedTiming"/>.
        /// </summary>
        public enum DetailedTimingDescriptor
        {
            [PropertyName("Pixel Clock")]
            [PropertyDescription("Pixel Clock")]
            [PropertyType(typeof(int))]
            PixelClock,

            [PropertyName("Horizontal Resolution")]
            [PropertyDescription("Horizontal Resolution")]
            [PropertyType(typeof(int))]
            HorizontalResolution,

            [PropertyName("Horizontal Blanking")]
            [PropertyDescription("Horizontal Blanking")]
            [PropertyType(typeof(int))]
            HorizontalBlanking,

            [PropertyName("Vertical Lines")]
            [PropertyDescription("Vertical Lines")]
            [PropertyType(typeof(int))]
            VerticalLines,

            [PropertyName("Vertical Blanking")]
            [PropertyDescription("Vertical Blanking")]
            [PropertyType(typeof(int))]
            VerticalBlanking,

            [PropertyName("Horizontal Front Porch")]
            [PropertyDescription("Horizontal Front Porch")]
            [PropertyType(typeof(int))]
            HorizontalFrontPorch,

            [PropertyName("Horizontal Sync Pulse Width")]
            [PropertyDescription("Horizontal Sync Pulse Width")]
            [PropertyType(typeof(int))]
            HorizontalSyncPulseWidth,

            [PropertyName("Vertical Front Porch")]
            [PropertyDescription("Vertical Front Porch")]
            [PropertyType(typeof(int))]
            VerticalFrontPorch,

            [PropertyName("Vertical Sync Pulse Width")]
            [PropertyDescription("Vertical Sync Pulse Width")]
            [PropertyType(typeof(int))]
            VerticalSyncPulseWidth,

            [PropertyName("Horizontal Image Size")]
            [PropertyDescription("Horizontal Image Size")]
            [PropertyType(typeof(int))]
            HorizontalImageSize,

            [PropertyName("Vertical Image Size")]
            [PropertyDescription("Vertical Image Size")]
            [PropertyType(typeof(int))]
            VerticalImageSize,

            [PropertyName("Interlaced")]
            [PropertyDescription("Interlaced")]
            [PropertyType(typeof(int))]
            HorizontalBorder,

            [PropertyName("Vertical Border")]
            [PropertyDescription("Vertical Border")]
            [PropertyType(typeof(int))]
            VerticalBorder,

            [PropertyName("Interlaced")]
            [PropertyDescription("Interlaced")]
            [PropertyType(typeof(bool))]
            Interlaced,

            [PropertyName("Stereo Viewing Support")]
            [PropertyDescription("Stereo Viewing Support")]
            [PropertyType(typeof(string))]
            StereoViewingSupport,

            [PropertyName("Sync Signal Type")]
            [PropertyDescription("Sync Signal Type")]
            [PropertyType(typeof(string))]
            SyncSignalType,
        }
        #endregion

        #region [public] (enum) DataBlockTags: Definition of sections for a section of type 'DataBlockCollection'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.DataBlockCollection"/>.
        /// </summary>
        public enum DataBlockTags
        {
            [PropertyName("Audio")]
            [PropertyDescription("Audio DataBlock Tag")]
            [PropertyType(typeof(SectionPropertiesTable))]
            Audio,

            [PropertyName("Extended")]
            [PropertyDescription("Extended DataBlock Tag")]
            [PropertyType(typeof(SectionPropertiesTable))]
            Extended,

            [PropertyName("Reserved")]
            [PropertyDescription("Reserved DataBlock Tag")]
            [PropertyType(typeof(SectionPropertiesTable))]
            Reserved,

            [PropertyName("Speaker")]
            [PropertyDescription("Speaker DataBlock Tag")]
            [PropertyType(typeof(SectionPropertiesTable))]
            Speaker,

            [PropertyName("Video")]
            [PropertyDescription("Video DataBlock Tag")]
            [PropertyType(typeof(SectionPropertiesTable))]
            Video,

            [PropertyName("Vendor")]
            [PropertyDescription("Vendor DataBlock Tag")]
            [PropertyType(typeof(SectionPropertiesTable))]
            Vendor,

            [PropertyName("VESA")]
            [PropertyDescription("VESA DataBlock Tag")]
            [PropertyType(typeof(SectionPropertiesTable))]
            VESA,
        }
        #endregion

        #region [public] (enum) AudioDataBlock: Definition of properties for 'Audio' datablock section of 'DataBlockCollection' section
        /// <summary>
        /// Definition of properties for <b>Audio</b> datablock section of <see cref="CeaSection.DataBlockCollection"/> section.
        /// </summary>
        public enum AudioDataBlock
        {
            [PropertyName("Audio Descriptor")]
            [PropertyDescription("Audio Descriptor Index")]
            [PropertyType(typeof(byte))]
            Descriptor,

            [PropertyName("Audio Bit Depth")]
            [PropertyDescription("Audio Bit Depth")]
            [PropertyType(typeof(ReadOnlyCollection<string>))]
            BitDepth,

            [PropertyName("Audio Channels")]
            [PropertyDescription("Audio Channels")]
            [PropertyType(typeof(ushort))]
            Channels,

            [PropertyName("Audio Format")]
            [PropertyDescription("Audio Format")]
            [PropertyType(typeof(string))]
            Format,

            [PropertyName("Audio Max Bitrate")]
            [PropertyDescription("Audio Max Bitrate")]
            [PropertyType(typeof(int))]
            MaxBitrate,

            [PropertyName("Audio Sampling Frequencies")]
            [PropertyDescription("Audio Sampling Frequencies")]
            [PropertyType(typeof(ReadOnlyCollection<string>))]
            SamplingFrequencies
        }
        #endregion

        #region [public] (enum) ExtendedColorimetryDataBlock: Definition of properties for a section of type 'DataBlockCollection'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.DataBlockCollection"/>.
        /// </summary>
        public enum ExtendedColorimetryDataBlock
        {
            [PropertyName("Adobe RGB")]
            [PropertyDescription("Adobe RGB")]
            [PropertyType(typeof(bool))]
            AdobeRGB,

            [PropertyName("Adobe YCC601")]
            [PropertyDescription("Adobe YCC601")]
            [PropertyType(typeof(bool))]
            AdobeYCC601,

            [PropertyName("sYCC601")]
            [PropertyDescription("sYCC601")]
            [PropertyType(typeof(bool))]
            sYCC601,

            [PropertyName("xvYCC709")]
            [PropertyDescription("xvYCC709")]
            [PropertyType(typeof(bool))]
            xvYCC709,

            [PropertyName("xvYCC601")]
            [PropertyDescription("xvYCC601")]
            [PropertyType(typeof(bool))]
            xvYCC601
        }
        #endregion

        #region [public] (enum) ExtendedMiscellaneousAudioFieldsDataBlock: Definition of properties for a section of type 'DataBlockCollection'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.DataBlockCollection"/>.
        /// </summary>
        public enum ExtendedMiscellaneousAudioFieldsDataBlock
        {
        }
        #endregion

        #region [public] (enum) ExtendedVendorSpecificAudioDataBlock: Definition of properties for a section of type 'DataBlockCollection'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.DataBlockCollection"/>.
        /// </summary>
        public enum ExtendedVendorSpecificAudioDataBlock
        {
        }
        #endregion

        #region [public] (enum) ExtendedVendorSpecificVideoDataBlock: Definition of properties for a section of type 'DataBlockCollection'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.DataBlockCollection"/>.
        /// </summary>
        public enum ExtendedVendorSpecificVideoDataBlock
        {
        }
        #endregion

        #region [public] (enum) ExtendedVideoCapabilityDataBlock: Definition of properties for a section of type 'DataBlockCollection'
        /// <summary>
        /// Definition of properties for a section of type <see cref="CeaSection.DataBlockCollection"/>.
        /// </summary>
        public enum ExtendedVideoCapabilityDataBlock
        {
            [PropertyName("CE Overscan/Underscan")]
            [PropertyDescription("CE Overscan/Underscan")]
            [PropertyType(typeof(string))]
            CEOverscan,

            [PropertyName("IT Overscan/Underscan")]
            [PropertyDescription("IT Overscan/Underscan")]
            [PropertyType(typeof(string))]
            ITOverscan,

            [PropertyName("PT Overscan/Underscan")]
            [PropertyDescription("PT Overscan/Underscan")]
            [PropertyType(typeof(string))]
            PTOverscan,

            [PropertyName("Quantization Range RGB")]
            [PropertyDescription("Quantization Range RGB")]
            [PropertyType(typeof(string))]
            QuantizationRangeRGB,

            [PropertyName("Quantization Range YCC")]
            [PropertyDescription("Quantization Range YCC")]
            [PropertyType(typeof(string))]
            QuantizationRangeYCC
        }
        #endregion

        #region [public] (enum) ReservedDataBlock: Definition of properties for 'Reserved' datablock section of 'DataBlockCollection' section
        /// <summary>
        /// Definition of properties for <b>Reserved</b> datablock section of <see cref="CeaSection.DataBlockCollection"/> section.
        /// </summary>
        public enum ReservedDataBlock
        {
            [PropertyName("Data")]
            [PropertyDescription("Raw data")]
            [PropertyType(typeof(ReadOnlyCollection<byte>))]
            Data,
        }
        #endregion

        #region [public] (enum) SpeakerDataBlock: Definition of properties for 'Speaker' datablock section of 'DataBlockCollection' section
        /// <summary>
        /// Definition of properties for <b>Speaker</b> datablock section of <see cref="CeaSection.DataBlockCollection"/> section.
        /// </summary>
        public enum SpeakerDataBlock
        {
            [PropertyName("Front Left/Right High")]
            [PropertyDescription("Front Left/Right High")]
            [PropertyType(typeof(bool))]
            FrontLeftRightHigh,

            [PropertyName("Front Left/Right Wide")]
            [PropertyDescription("Front Left/Right Wide")]
            [PropertyType(typeof(bool))]
            FrontLeftRightWide,

            [PropertyName("Rear Left/Right Center")]
            [PropertyDescription("Rear Left/Right Center")]
            [PropertyType(typeof(bool))]
            RearLeftRightCenter,

            [PropertyName("Front Left/Right Center")]
            [PropertyDescription("Front Left/Right Center")]
            [PropertyType(typeof(bool))]
            FrontLeftRightCenter,

            [PropertyName("Rear Center")]
            [PropertyDescription("Rear Center")]
            [PropertyType(typeof(bool))]
            RearCenter,

            [PropertyName("Rear Left/Right")]
            [PropertyDescription("Rear Left/Right")]
            [PropertyType(typeof(bool))]
            RearLeftRight,

            [PropertyName("Front Center")]
            [PropertyDescription("Front Center")]
            [PropertyType(typeof(bool))]
            FrontCenter,

            [PropertyName("LFE Channel")]
            [PropertyDescription("LFE Channel")]
            [PropertyType(typeof(bool))]
            LFEChannel,

            [PropertyName("Front Left/Right")]
            [PropertyDescription("Front Left/Right")]
            [PropertyType(typeof(bool))]
            FrontLeftRight,

            [PropertyName("Top Center")]
            [PropertyDescription("Top Center")]
            [PropertyType(typeof(bool))]
            TopCenter,

            [PropertyName("Front Center High")]
            [PropertyDescription("Front Center High")]
            [PropertyType(typeof(bool))]
            FrontCenterHigh,
        }
        #endregion

        #region [public] (enum) VendorDataBlock: Definition of properties for 'Vendor' datablock section of 'DataBlockCollection' section
        /// <summary>
        /// Definition of properties for <b>Vendor</b> datablock section of <see cref="CeaSection.DataBlockCollection"/> section.
        /// </summary>
        public enum VendorDataBlock
        {
            [PropertyName("IEEE Registration Identifier")]
            [PropertyDescription("IEEE Registration Identifier")]
            [PropertyType(typeof(int))]
            IEEERegistrationIdentifier,

            [PropertyName("Physical Address")]
            [PropertyDescription("Consumer Electronics Control (CEC) physical address")]
            [PropertyType(typeof(int))]
            PhysicalAddress,

            [PropertyName("Flags")]
            [PropertyDescription("Flags")]
            [PropertyType(typeof(ReadOnlyCollection<string>))]
            Flags,

            [PropertyName("Maximum TMDS clock")]
            [PropertyDescription("Maximum TMDS clock")]
            [PropertyType(typeof(int))]
            MaxClock,

            [PropertyName("Vendor Specific Payload")]
            [PropertyDescription("Vendor Specific Payload")]
            [PropertyType(typeof(ReadOnlyCollection<byte>))]
            VendorPayload,
        }
        #endregion

        #region [public] (enum) VideoDataBlock: Definition of properties for 'Video' datablock section of 'DataBlockCollection' section
        /// <summary>
        /// Definition of properties for <b>Video</b> datablock section of <see cref="CeaSection.DataBlockCollection"/> section.
        /// </summary>
        public enum VideoDataBlock
        {
            [PropertyName("Supported Timings")]
            [PropertyDescription("Supported Timings")]
            [PropertyType(typeof(ReadOnlyCollection<string>))]
            SupportedTimings,
        }
        #endregion
    }
}
