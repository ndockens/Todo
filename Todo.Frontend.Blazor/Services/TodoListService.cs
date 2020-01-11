using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Todo.Frontend.Blazor.Models;

namespace Todo.Frontend.Blazor.Services
{
    public class TodoListService : ITodoListService
    {
        private readonly TodoList _todoList = new TodoList
        {
            Id = 1,
            Name = "My First Todo List",
            UserId = "mike01",
            CreatedAt = new DateTime(2020, 1, 5),
            Items = new List<TodoItem>
            {
                new TodoItem { Id = 1000, Name = "Walk dog", IsComplete = true },
                new TodoItem { Id = 1001, Name = "Mail packages", IsComplete = false },
                new TodoItem { Id = 1002, Name = "Wash car", IsComplete = false }
            }
        };
        
        public TodoListService()
        {
            
        }

        public async Task<TodoList> GetAsync(long id)
        {
            return await Task.FromResult(_todoList);
        }

        public async Task<TodoItem> GetItemAsync(long listId, long itemId)
        {
            return await Task.FromResult(_todoList.Items.FirstOrDefault(x => x.Id == itemId));
        }
    }
}