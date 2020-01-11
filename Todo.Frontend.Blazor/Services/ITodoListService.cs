using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Todo.Frontend.Blazor.Models;

namespace Todo.Frontend.Blazor.Services
{
    public interface ITodoListService
    {
        
        Task<TodoList> GetAsync(long id);
        Task<TodoItem> GetItemAsync(long listId, long itemId);
    }
}