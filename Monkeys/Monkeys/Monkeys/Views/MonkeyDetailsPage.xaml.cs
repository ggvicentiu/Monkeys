using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monkeys.Models;
using Monkeys.ViewModels;
using Xamarin.Forms;

namespace Monkeys.Views
{
    public partial class MonkeyDetailsPage : ContentPage
    {
        public MonkeyDetailsPage(Monkey monkey)
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel(monkey);
        }
    }
}
