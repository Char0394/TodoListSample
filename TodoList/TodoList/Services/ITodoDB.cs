using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Services
{
    public interface ITodoDB
    {
        Task<List<Item>> GetItemsAsync();
        Task<int> SaveItemAsync(Item item);
        Task<int> DeleteItemAsync(Item item);
    }
}
