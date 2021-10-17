using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTree : ContentPage
    {
        public AddTree()
        {
            InitializeComponent();
        }
        private async void ToView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewTrees());
        }
    }
}