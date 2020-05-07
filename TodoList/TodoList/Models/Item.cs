using System.ComponentModel;
using TodoList.Helpers;

namespace TodoList.Models
{
    public class Item: INotifyPropertyChanged
    {
        public Item(string text)
        {
            Text = text;
        }
        public string Text { get; set; }
        public TodoStatus Status { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
