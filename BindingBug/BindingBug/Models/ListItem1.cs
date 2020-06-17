using System;
using System.Linq;

namespace BindingBug.Models
{
    public class ListItem1
    {
        private string RandomString(int len)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, len).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public ListItem1()
        {
            Id = RandomString(5);
            Text = RandomString(10);
            Place = RandomString(10);
        }

        public string Id { get; set; }
        public string Text { get; set; }
        public string Place { get; set; }

        public string DetailString
        {
            get => Id + ": " + Text + " in " + Place;
        }
    }
}
