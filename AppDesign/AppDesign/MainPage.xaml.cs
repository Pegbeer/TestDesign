using AppDesign.ResourceDictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDesign
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SizeChanged += MainPage_SizeChanged;
        }


        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height > this.Width;
            MainStack.Orientation = (isPortrait ? StackOrientation.Vertical : StackOrientation.Horizontal);
            if (isPortrait)
            {
                imag.Style = (Style)Application.Current.Resources["MainLogoVertical"];
                brandimg.Style = (Style)Application.Current.Resources["BrandLogoVertical"];
            }
            else
            {
                imag.Style = (Style)Application.Current.Resources["MainLogoHorizontal"];
                brandimg.Style = (Style)Application.Current.Resources["BrandLogoHorizontal"];
            }

        }
    }
}
