using System.ComponentModel;
using SQLite;
using TodoList.Helpers;

namespace TodoList.Models
{
    public class Item: INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Text { get; set; }
        public TodoStatus Status { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
