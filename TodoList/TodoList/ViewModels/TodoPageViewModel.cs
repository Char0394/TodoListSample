using System;
using System.ComponentModel;

namespace TodoList.ViewModels
{
    public class TodoPageViewModel: INotifyPropertyChanged
    {
        public TodoPageViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
