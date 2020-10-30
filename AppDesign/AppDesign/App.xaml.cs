using AppDesign.ResourceDictionaries;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDesign
{
    public partial class App : Application
    {
        const int smallWidthResolution = 800;
        const int smallHeightResolution = 1280;
        public App()
        {
            InitializeComponent();
            LoadStyles();
            MainPage = new MenuPage();
        }

        void LoadStyles()
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var width = mainDisplayInfo.Width;
            var height = mainDisplayInfo.Height;
            if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape)
            {
                if (height <= smallWidthResolution && width <= smallHeightResolution)
                {
                    dictionary.MergedDictionaries.Add(SmallTablet.SharedInstance);
                }
                else
                {
                    dictionary.MergedDictionaries.Add(LargeTablet.SharedInstance);
                }
            }
            else
            {
                if (width <= smallWidthResolution && height <= smallHeightResolution)
                {
                    dictionary.MergedDictionaries.Add(SmallTablet.SharedInstance);
                }
                else
                {
                    dictionary.MergedDictionaries.Add(LargeTablet.SharedInstance);
                }
            }

            
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {

        }
    }
}
