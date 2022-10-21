
using System;

using iTin.Core.Hardware.Common;

namespace iEEDID
{
    /// <summary>
    /// Extension methods for <see cref="Enum"/> types.
    /// </summary>
    internal static class EnumExtensions
    {
        /// <summary>
        /// Returns the friendly name if exist for a <paramref name="value"/> given.
        /// </summary>
        /// <param name="value">Target value</param>
        /// <returns>
        /// A <see cref="string"/> containing friendly name for <paramref name="value"/> given.
        /// </returns>
        public static string AsFriendlyName(this Enum value)
        {
            string friendlyName = value.GetPropertyName();

            return string.IsNullOrEmpty(friendlyName)
                ? value.ToString()
                : friendlyName;
        }
    }
}
