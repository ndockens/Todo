using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApi2.Models;
using MyApi2.Repositories;

namespace MyApi2.Services
{
    public class TodoItemsService : ITodoItemsService
    {
        private readonly ITodoItemsRepository _todoItemsRepository;

        public TodoItemsService(ITodoItemsRepository toDoItemsRepository)
        {
            _todoItemsRepository = toDoItemsRepository;
        }

        public async Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
        {
            return await _todoItemsRepository.GetTodoItemsAsync();
        }

        public async Task<TodoItem> GetTodoItemAsync(long id)
        {
            return await _todoItemsRepository.GetTodoItemAsync(id);
        }

        public async Task<TodoItem> CreateTodoItemAsync(TodoItem todoItem)
        {
            await _todoItemsRepository.CreateTodoItemAsync(todoItem);
            var createdItem = await _todoItemsRepository.GetTodoItemAsync(todoItem.Id);

            return createdItem;
        }

        public async Task UpdateTodoItemAsync(long id, TodoItem todoItem)
        {
            await _todoItemsRepository.UpdateTodoItemAsync(id, todoItem);
        }

        public async Task<TodoItem> DeleteTodoItemAsync(long id)
        {
            var todoItem = await _todoItemsRepository.GetTodoItemAsync(id);

            if (todoItem == null)
                return null;

            await _todoItemsRepository.DeleteTodoItemAsync(id);

            return todoItem;
        }
    }
}
