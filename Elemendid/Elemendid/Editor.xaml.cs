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
    public partial class Editor : ContentPage
    {
        public Editor()
        {
            InitializeComponent();
        }

        public int TextChanged { get; internal set; }
        public LayoutOptions HorizontalOptions { get; internal set; }
        public LayoutOptions VerticalOptions { get; internal set; }
        public Keyboard Keyboard { get; internal set; }
    }
}