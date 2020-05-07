using TodoList.Helpers;

namespace TodoList.Models
{
    public class Item
    {
        public string Text { get; set; }
        public TodoStatus Status { get; set; }
    }
}
