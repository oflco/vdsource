// Copyright (c) 2023 VisionDream Authors. Web: https://visiondreamict.wordpress.com/.
// Licensed under the MIT license. See LICENSE file for license information.

namespace VisionDream.Core.Exceptions
{
    /// <summary>
    /// Custom active directory account invalid exception.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The custom <see cref="AdAccountInvalidException"/> class inherits
    /// from the base <see cref="Exception"/> class.
    /// </para>
    /// </remarks>
    public class AdAccountInvalidException : Exception
    {
        /// <summary>
        /// Creates a new <see cref="AdAccountInvalidException"/> object
        /// using its <see langword="public"/> parameter constructor (ctor)
        /// and initializes the instance with the parsed parameters.
        /// </summary>
        /// <param name="adAccount">
        /// <see cref="string"/> object to add to a new
        /// <see cref="AdAccountInvalidException"/>.
        /// </param>
        /// <param name="ex">
        /// <see cref="string"/> object to add to a new
        /// <see cref="AdAccountInvalidException"/>.
        /// </param>
        /// <remarks>
        /// <para>
        /// The parsed parameters (<paramref name="adAccount"/> and
        /// <paramref name="ex"/>) also initialize the <see langword="base"/>
        /// <see cref="Exception"/> object parameters.
        /// </para>
        /// </remarks>
        public AdAccountInvalidException(string adAccount, Exception ex)
            : base($"AD Account \"{adAccount}\" is invalid.", ex)
        {
        }
    }
}
