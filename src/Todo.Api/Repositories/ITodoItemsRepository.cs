﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Api.Models;

namespace Todo.Api.Repositories
{
    public interface ITodoItemsRepository
    {
        Task<IEnumerable<TodoItem>> GetTodoItemsAsync();
        Task<TodoItem> GetTodoItemAsync(long id);
        Task UpdateTodoItemAsync(long id, TodoItem todoItem);
        Task CreateTodoItemAsync(TodoItem todoItem);
        Task DeleteTodoItemAsync(long id);
    }
}
