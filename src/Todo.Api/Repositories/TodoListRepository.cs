using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Api.Models;

namespace Todo.Api.Repositories
{
    public class TodoListRepository : ITodoListRepository
    {
        private readonly TodoContext _context;

        public TodoListRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoList>> GetAsync()
        {
            return await _context.TodoLists.ToListAsync();
        }

        public async Task<TodoList> GetAsync(long id)
        {
            return await _context.TodoLists.FindAsync(id);
        }

        public async Task AddAsync(TodoList todoList)
        {
            _context.TodoLists.Add(todoList);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TodoList todoList)
        {
            _context.Entry(todoList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.TodoLists.Any(e => e.Id == todoList.Id))
                {
                    throw new Exception($"Todo list {todoList.Id} not found.");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task RemoveAsync(long id)
        {
            var todoList = await _context.TodoLists.FindAsync(id);

            if (todoList == null)
            {
                throw new Exception($"Todo list {id} not found.");
            }

            _context.TodoLists.Remove(todoList);
            await _context.SaveChangesAsync();
        }
    }
}
