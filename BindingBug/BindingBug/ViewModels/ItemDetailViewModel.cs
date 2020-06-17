using System;
using System.Threading.Tasks;
using System.Windows.Input;
using BindingBug.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BindingBug.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }

        public ICommand Command1 => new Command(async () => await Func1());

        public ICommand Command2 => new Command(async () => await Func1());

        private async Task Func1()
        {
            await Application.Current.MainPage.DisplayAlert("Working button", "", "Ok");
        }
    }
}
