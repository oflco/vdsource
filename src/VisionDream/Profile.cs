// Copyright (c) 2023 VisionDream Authors. Web: https://visiondreamict.wordpress.com/.
// Licensed under the MIT license. See LICENSE file for license information.

namespace VisionDream
{
    public class Profile
    {
        private static readonly string Company = VDInfo.Company;
        private static readonly string Industry = VDInfo.Industry;
        private static readonly string Slogan = VDInfo.Slogan;
        private static readonly string Email = VDInfo.Email;
        private static readonly string Website = VDInfo.Website;

        /// <summary>
        /// The <see cref="ToString"/> method returns a string
        /// representing a VisionDream.<see cref="Profile"/> object.
        /// </summary>
        /// <returns>
        /// A string representing a VisionDream.<see cref="Profile"/> object.
        /// </returns>
        public override string ToString()
        {
            return $"Profile Information:{Environment.NewLine}" +
                   $"Company: {Company}{Environment.NewLine}" +
                   $"Industry: {Industry}{Environment.NewLine}" +
                   $"Slogan: {Slogan}{Environment.NewLine}" +
                   $"Email: {Email}{Environment.NewLine}" +
                   $"Website: {Website}{Environment.NewLine}";
        }
    }
}
