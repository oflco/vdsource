// Copyright (c) VisionDream Authors.
// Licensed under the MIT License.

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
