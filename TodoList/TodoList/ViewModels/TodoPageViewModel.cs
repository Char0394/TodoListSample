using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Acr.UserDialogs;
using Prism.Commands;
using Prism.Services;
using TodoList.Models;

namespace TodoList.ViewModels
{
    public class TodoPageViewModel: INotifyPropertyChanged
    {
        IUserDialogs _userDialogs;

        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        public TodoPageViewModel(IUserDialogs userDialogs)
        {
            _userDialogs = userDialogs;
        }

        public DelegateCommand AddNewItemCommand => new DelegateCommand(async() =>
        {
            var result= await _userDialogs.PromptAsync("Insert Item");
            if (!string.IsNullOrEmpty(result.Text))
            {
                Items.Add(new Item(result.Text));
            }
        });
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
