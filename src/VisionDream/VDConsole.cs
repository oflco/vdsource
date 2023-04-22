// Copyright (c) VisionDream Authors.
// Licensed under the MIT License.

namespace VisionDream
{
    /// <summary>
    /// VisionDream console runner.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The <see cref="VDConsole"/> class of the program runner.
    /// </para>
    /// </remarks>
    public class VDConsole
    {
        private static readonly string AppTitle = $"VisionDream.VDConsole";

        /// <summary>
        /// VisionDream console program main method.
        /// </summary>
        /// <param name="args">
        /// <see cref="string"/>[] objects to parse to the <see cref="Main"/>.
        /// </param>
        /// <remarks>
        /// <para>
        /// <see cref="Main"/> method is an entry point of the console
        /// program runner.
        /// </para>
        /// </remarks>
        static void Main(string[] args)
        {
            Console.WriteLine($"{AppTitle} started...\n");
        }

        /// <summary>
        /// <see cref="ToString"/> method returns a string that
        /// represents the <see cref="VDConsole"/> object.
        /// </summary>
        /// <returns>
        /// A string that represents the <see cref="VDConsole"/> object.
        /// </returns>
        public override string ToString()
        {
            return $"{AppTitle} started...";
        }
    }
}
