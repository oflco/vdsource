// Copyright (c) 2023 VisionDream Authors. Web: https://visiondreamict.wordpress.com/.
// Licensed under the MIT license. See LICENSE file for license information.

using VisionDream.Core.Entities;

namespace VisionDream.Core.Enums
{
    /// <summary>
    /// Priority level severity.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The <see cref="PriorityLevel"/> enumeration is used to
    /// <see langword="get"/>/<see langword="set"/> a <see cref="TodoItem"/>'s
    /// priority level severity, which affects its importance. A high value
    /// means a <see cref="TodoItem.Priority"/> impact is high.
    /// </para>
    /// </remarks>
    /// <seealso cref="TodoList.Items"/>
    public enum PriorityLevel
    {
        /// <summary>
        /// No priority level is set.
        /// </summary>
        None = 0,
        /// <summary>
        /// The priority level is set to low.
        /// </summary>
        Low = 1,
        /// <summary>
        /// The priority level is set to medium.
        /// </summary>
        Medium = 2,
        /// <summary>
        /// The priority level is set to high.
        /// </summary>
        High = 3
    }
}
