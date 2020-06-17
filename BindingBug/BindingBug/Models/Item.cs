using System;
using System.Collections.Generic;

namespace BindingBug.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public IList<ListItem1> List1 { get; set; }

        public IList<ListItem1> List2 { get; set; }
    }
}