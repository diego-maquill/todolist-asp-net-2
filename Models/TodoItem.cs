using System;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public string Id { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }
}