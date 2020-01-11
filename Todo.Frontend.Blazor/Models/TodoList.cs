using System;
using System.Collections.Generic;

namespace Todo.Frontend.Blazor.Models
{
    public class TodoList
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<TodoItem> Items { get; set; }
    }
}