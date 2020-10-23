using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Tbl_btn = new Button { Text = "Endtry/Editor" };
            Button Tbl1_btn = new Button { Text = "ListView" };
            Button Tbl2_btn = new Button { Text = "DataPicker" };
            Button Tbl3_btn = new Button { Text = "TableView" };
            Button Tbl4_btn = new Button { Text = "WebView" };
            Button Tbl5_btn = new Button { Text = "Timer" };

            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            st.Children.Add(Tbl1_btn);
            st.Children.Add(Tbl2_btn);
            st.Children.Add(Tbl3_btn);
            st.Children.Add(Tbl4_btn);
            st.Children.Add(Tbl5_btn);

            Content = st;
            Tbl_btn.Clicked += Tbl_btn_Clicked;
            Tbl1_btn.Clicked += Tbl1_btn_Clicked;
            Tbl2_btn.Clicked += Tbl2_btn_Clicked;
            Tbl3_btn.Clicked += Tbl3_btn_Clicked;
            Tbl4_btn.Clicked += Tbl4_btn_Clicked;
            Tbl5_btn.Clicked += Tbl5_btn_Clicked;
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void Tbl1_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new  Page2());

        }
        private async void Tbl2_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        private async void Tbl3_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
        private async void Tbl4_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
        private async void Tbl5_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page6());
        }
    }
}