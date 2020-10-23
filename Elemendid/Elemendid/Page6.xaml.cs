using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        Button timerButton;
        bool alive = true;
        public Page6()
        {
            timerButton = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BackgroundColor = Color.Orange

            };
            timerButton.Clicked += TimerButton_Clicked;
            Content = timerButton;

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        private bool OnTimerTick()
        {
            timerButton.Text = DateTime.Now.ToString("T");
            return alive;
        }

        private void TimerButton_Clicked(object sender, EventArgs e)
        {
            if (alive == true)
            {
                alive = false;
            }
            else
            {
                alive = true;
                Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            }
        }
    }
}
