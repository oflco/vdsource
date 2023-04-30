// Copyright (c) 2023 VisionDream Authors. Web: https://visiondreamict.wordpress.com/.
// Licensed under the MIT license. See LICENSE file for license information.

namespace VisionDream
{
    /// <summary>
    /// VisionDream console runner program.
    /// </summary>
    public class VDConsole
    {
        private static readonly string AppTitle = $"VisionDream.VDConsole";
        private static Profile? VDProfile = null;

        /// <summary>
        /// VisionDream console runner program main method.
        /// </summary>
        /// <param name="args">
        /// <see cref="string"/>[] objects parsed
        /// to the <see cref="Main"/> method.
        /// </param>
        /// <remarks>
        /// <para>
        /// The <see cref="Main"/> method is the main entry point
        /// to the <see cref="VDConsole"/> runner program.
        /// </para>
        /// </remarks>
        static void Main(string[] args)
        {
            Console.WriteLine($"{AppTitle} started...\n");

            VDProfile = new Profile();
            Console.WriteLine($"{VDProfile}");

            Console.WriteLine($"{AppTitle} finished...");
        }
    }
}
