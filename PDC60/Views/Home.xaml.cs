using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            AnimateCarousel();
        }

        Timer timer;

        private void AnimateCarousel()
        {
            timer = new Timer(5000) { AutoReset = true, Enabled = true };

            timer.Elapsed += (s, e) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    if (landingpage.Position == 2)
                    {
                        landingpage.Position = 0;
                        return;
                    }
                    landingpage.Position += 1;
                });
            };
        }
    }
}