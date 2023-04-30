// Copyright (c) 2023 VisionDream Authors. Web: https://visiondreamict.wordpress.com/.
// Licensed under the MIT license. See LICENSE file for license information.

namespace VisionDream
{
    /// <summary>
    /// VisionDream information type.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The <see cref="VDInfo"/> class provides VisionDream static information.
    /// </para>
    /// </remarks>
    public static class VDInfo
    {
        #region Fields
        private static readonly string _company = "VisionDream";
        private static readonly string _industry = "ICT Solutions";
        private static readonly string _slogan = "Your Vision, Your Dream";
        private static readonly string _email = "hello@visiondream.co.za";
        private static readonly string _website = "https://visiondreamict.wordpress.com/";
        #endregion

        #region Properties
        public static string Company => _company;
        public static string Industry => _industry;
        public static string Slogan => _slogan;
        public static string Email => _email;
        public static string Website => _website;
        #endregion
    }
}
