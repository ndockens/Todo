using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Api.Models
{
    public class TodoList
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<TodoItem> Items { get; private set; }

        public void AddItem(string name)
        {
            if (Items.Any(x => x.Name == name))
                throw new Exception("An item with that name already exists.");

            var id = Items.Max(x => x.Id) + 1;

            Items.Add(new TodoItem { Id = id, Name = name, IsComplete = false });
        }

        public void RemoveItem(long id)
        {
            var item = GetItem(id);
            Items.Remove(item);
        }

        public TodoItem GetItem(long id)
        {
            var item = Items.FirstOrDefault(x => x.Id == id);

            if (item == null)
                throw new Exception("Item does not exist.");

            return item;
        }

        public TodoItem GetItemByName(string name)
        {
            var item = Items.FirstOrDefault(x => x.Name == name);

            if (item == null)
                throw new Exception("Item does not exist.");

            return item;
        }
    }
}
