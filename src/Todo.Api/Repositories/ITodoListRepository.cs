using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Api.Models;

namespace Todo.Api.Repositories
{
    public interface ITodoListRepository
    {
        Task<IEnumerable<TodoList>> GetAsync();
        Task<TodoList> GetAsync(long id);
        Task UpdateAsync(TodoList todoList);
        Task AddAsync(TodoList todoList);
        Task RemoveAsync(long id);
    }
}
