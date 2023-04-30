// Copyright (c) 2023 VisionDream Authors. Web: https://visiondreamict.wordpress.com/.
// Licensed under the MIT license. See LICENSE file for license information.

using VisionDream.Core.Common;

namespace VisionDream.Core.Entities
{
    public class TodoList : AuditableEntity
    {
        public TodoList()
        {
            Items = new List<TodoItem>();
        }

        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Colour { get; set; }

        public IList<TodoItem>? Items { get; set; }
    }
}
