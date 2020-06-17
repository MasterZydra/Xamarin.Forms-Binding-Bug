using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BindingBug.Models;

namespace BindingBug.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            List<ListItem1> shortList = new List<ListItem1>();
            shortList.Add(new ListItem1());

            List<ListItem1> mediumList = new List<ListItem1>();
            mediumList.Add(new ListItem1());
            mediumList.Add(new ListItem1());
            mediumList.Add(new ListItem1());

            List<ListItem1> longList = new List<ListItem1>();
            longList.Add(new ListItem1());
            longList.Add(new ListItem1());
            longList.Add(new ListItem1());
            longList.Add(new ListItem1());
            longList.Add(new ListItem1());
            longList.Add(new ListItem1());

            List<ListItem1> veryLongList = new List<ListItem1>();
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());
            veryLongList.Add(new ListItem1());

            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description.", List1=shortList, List2=mediumList },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description.", List1=mediumList, List2=longList },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description.", List1=longList, List2=veryLongList },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description.", List1=shortList, List2=veryLongList },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description.", List1=mediumList, List2=longList },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description.", List1=longList, List2=mediumList }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}