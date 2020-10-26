using System;

namespace Todo.Models
{
    public class NewTodoEventArgs : EventArgs
    {
        public TodoItem NewTodo { get; set; }
    }
}