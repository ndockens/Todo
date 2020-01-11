using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Api.Models;

namespace Todo.Api.Services
{
    public interface ITodoItemsService
    {
        Task<IEnumerable<TodoItem>> GetTodoItemsAsync();
        Task<TodoItem> GetTodoItemAsync(long id);
        Task UpdateTodoItemAsync(long id, TodoItem todoItem);
        Task<TodoItem> CreateTodoItemAsync(TodoItem todoItem);
        Task<TodoItem> DeleteTodoItemAsync(long id);
    }
}
