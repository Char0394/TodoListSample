using System.Collections.ObjectModel;
using System.ComponentModel;
using Acr.UserDialogs;
using Prism.Commands;
using TodoList.Models;
using TodoList.Services;

namespace TodoList.ViewModels
{
    public class TodoPageViewModel: INotifyPropertyChanged
    {
        IUserDialogs _userDialogs;
        ITodoDB _todoDB;

        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        public TodoPageViewModel(IUserDialogs userDialogs, ITodoDB todoDB)
        {
            _userDialogs = userDialogs;
            _todoDB = todoDB;
            GetItemsCommand.Execute();
        }

        public DelegateCommand GetItemsCommand => new DelegateCommand(async () =>
        {
            var data = await _todoDB.GetItemsAsync();
            Items = new ObservableCollection<Item>(data);
        });


        public DelegateCommand AddNewItemCommand => new DelegateCommand(async() =>
        {
            var result= await _userDialogs.PromptAsync("Insert Item");
            if (!string.IsNullOrEmpty(result.Text))
            {
                await _todoDB.SaveItemAsync(new Item() { Text = result.Text });
                GetItemsCommand.Execute();
            }
        });


        public DelegateCommand<Item> DeleteItemCommand => new DelegateCommand<Item>(async (param) =>
        {
            await _todoDB.DeleteItemAsync(param);
            GetItemsCommand.Execute();
        });

        public DelegateCommand<Item> UpdateItemStatus => new DelegateCommand<Item>(async (param) =>
        {
            param.Status=(param.Status == Helpers.TodoStatus.Completed) ? Helpers.TodoStatus.Pending : Helpers.TodoStatus.Completed;
            await _todoDB.SaveItemAsync(param);
            GetItemsCommand.Execute();
        });

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
