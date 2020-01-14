using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Api.Models;

namespace Todo.Api.Repositories
{
    public interface ITodoListRepository
    {
        Task<IEnumerable<TodoList>> GetTodoListsAsync();
        Task<TodoList> GetTodoListAsync(long id);
        Task UpdateTodoListAsync(long id, TodoList todoList);
        Task CreateTodoListAsync(TodoList todoList);
        Task DeleteTodoListAsync(long id);
    }
}
