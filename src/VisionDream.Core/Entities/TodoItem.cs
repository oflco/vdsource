// Copyright (c) 2023 VisionDream Authors. Web: https://visiondreamict.wordpress.com/.
// Licensed under the MIT license. See LICENSE file for license information.

using VisionDream.Core.Common;
using VisionDream.Core.Enums;

namespace VisionDream.Core.Entities
{
    public class TodoItem : AuditableEntity
    {
        public long Id { get; set; }

        public int ListId { get; set; }

        public string? Title { get; set; }

        public string? Note { get; set; }

        public bool Done { get; set; }

        public DateTime? Reminder { get; set; }

        public PriorityLevel Priority { get; set; }


        public TodoList? List { get; set; }
    }
}
