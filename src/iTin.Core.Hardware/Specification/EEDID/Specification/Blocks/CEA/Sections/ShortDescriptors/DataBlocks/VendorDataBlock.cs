
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Helpers.Enumerations;
    using iTin.Core.Helpers;

    /// <summary>
    /// Estructura <see cref="VendorDataBlock"/> que contiene la lógica para decodificar los datos de un bloque del tipo <see cref="ShortVendorDescriptorCeaSection"/>.
    /// </summary> 
    struct VendorDataBlock
    {
        #region private readonly members
        private readonly ReadOnlyCollection<byte> _vendorDataBlock;
        #endregion

        #region Constructor/es

        #region [public] VendorDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="VendorDataBlock"/> especificando los datos de este bloque del fabricante.
        /// </summary>
        /// <param name="vendorDataBlock">Datos de este bloque del fabricante.</param>
        public VendorDataBlock(ReadOnlyCollection<byte> vendorDataBlock)
        {
            _vendorDataBlock = vendorDataBlock;

            var vendorDataBlockArray = new byte[_vendorDataBlock.Count];
            vendorDataBlock.CopyTo(vendorDataBlockArray, 0);

            IEEERegistrationIdentifier = (LogicHelper.Word(_vendorDataBlock[0x01], _vendorDataBlock[0x02]) << 8) | _vendorDataBlock[0x00];
            PhysicalAddress = vendorDataBlockArray.GetWord(0x03);
            Flags = FlagCollection(_vendorDataBlock[0x04]);
            MaxClock = _vendorDataBlock[0x06] * 5;

            var payLoadArray = new byte[_vendorDataBlock.Count - 0x02];
            Array.Copy(vendorDataBlockArray, 0x02, payLoadArray, 0x00, _vendorDataBlock.Count - 0x02);
            PayLoad = new ReadOnlyCollection<byte>(payLoadArray);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (ReadOnlyCollection<string>) Flags: Obtiene flags.
        /// <summary>
        /// Obtiene flags.
        /// </summary>
        /// <value>Flags.</value>
        public ReadOnlyCollection<string> Flags { get; }
        #endregion

        #region [public] (int) IEEERegistrationIdentifier: Obtiene IEEE Registration Identifier.
        /// <summary>
        /// Obtiene IEEE Registration Identifier.
        /// </summary>
        /// <value>IEEE Registration Identifier.</value>
        public int IEEERegistrationIdentifier { get; }
        #endregion

        #region [public] (int) MaxClock: Obtiene Maximum TMDS clock.
        /// <summary>
        /// Obtiene Maximum TMDS clock.
        /// </summary>
        /// <value>Maximum TMDS clock.</value>
        public int MaxClock { get; }
        #endregion

        #region [public] (ReadOnlyCollection<byte>) PayLoad: Obtiene un valor que representa los datos del fabricante.
        /// <summary>
        /// Obtiene un valor que representa los datos del fabricante.
        /// </summary>
        /// <value>Datos del fabricante.</value>
        public ReadOnlyCollection<byte> PayLoad { get; }
        #endregion

        #region [public] (int) PhysicalAddress: Obtiene Physical Address.
        /// <summary>
        /// Obtiene Physical Address.
        /// </summary>
        /// <value>Physical Address.</value>
        public int PhysicalAddress { get; }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (ReadOnlyCollection<string>) FlagCollection(byte): Colección de propiedades.
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

        #endregion
    }
}
