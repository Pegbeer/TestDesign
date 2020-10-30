using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDesign
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            SizeChanged += MenuPage_SizeChanged;
            InitializeComponent();
            
        }

        private void MenuPage_SizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height > this.Width;
            MainStack.Orientation = (isPortrait ? StackOrientation.Vertical : StackOrientation.Horizontal);
            if (isPortrait)
            {
                LoadVerticalStyles();
                LoadVerticalFonts();
                MainFrame.IsVisible = false;
                MainFrame.TranslateTo(0, 0, 100);
                hideFrame.IsVisible = true;
                hideFrame.IsEnabled = true;
            }
            else
            {
                LoadHorizontalStyles();
                LoadHorizontalFonts();
                hideFrame.IsVisible = false;
                hideFrame.IsEnabled = false;
                MainFrame.IsVisible = true;
                MainFrame.TranslateTo(0, 0, 200);
                MainFrame.IsEnabled = true;
                gridButtons.TranslateTo(0, 0, 200);
            }
        }

        private async void displayFrame_Tapped(object sender, EventArgs e)
        {
            if (!MainFrame.IsVisible)
            {
                await imgFrame.RotateTo(90, 100);
                await gridButtons.TranslateTo(600, 0, 200);
                gridButtons.IsVisible = false;
                MainFrame.IsVisible = true;
                MainFrame.IsEnabled = true;
                await MainFrame.TranslateTo(0,100, 200);
                
            }
            else
            {
                await imgFrame.RotateTo(0, 200);
                await MainFrame.TranslateTo(0, 0, 200);
                MainFrame.IsVisible = false;
                MainFrame.IsEnabled = false;
                gridButtons.IsVisible = true;
                await gridButtons.TranslateTo(0, 0, 200);
            }
        }

        private void LoadHorizontalStyles()
        {
            actionsGrid.Style = (Style)Application.Current.Resources["HorizontalMenuGrid"];
            subActionsGrid.Style = (Style)Application.Current.Resources["SubMenuHorizontalGrid"];
            mainStatusStack.Style = (Style)Application.Current.Resources["MainStatusStackHorizontal"];
        }

        private void LoadVerticalStyles()
        {
            actionsGrid.Style = (Style)Application.Current.Resources["VerticalMenuGrid"];
            subActionsGrid.Style = (Style)Application.Current.Resources["SubMenuVerticalGrid"];
            mainStatusStack.Style = (Style)Application.Current.Resources["MainStatusStackVertical"];
        }

        private void LoadHorizontalFonts()
        {
            var subframes = subActionsGrid.Children.Take(5).OfType<Frame>().ToList();
            var substacks = subframes.Take(5).Select(x => x.Content as StackLayout);
            foreach (var item in substacks)
            {
                item.Children.OfType<Label>().FirstOrDefault().Style = (Style)Application.Current.Resources["SubMenuFontHorizontal"];
                item.Children.OfType<Image>().FirstOrDefault().Style = (Style)Application.Current.Resources["SubMenuImageHorizontal"];
            }

            var frames = actionsGrid.Children.Take(8).OfType<Frame>().ToList();
            var stacks = frames.Take(8).Select(c => c.Content as StackLayout);
            foreach (var item in stacks)
            {
                item.Children.OfType<Label>().FirstOrDefault().Style = (Style)Application.Current.Resources["MenuFontHorizontal"];
                item.Children.OfType<Image>().FirstOrDefault().Style = (Style)Application.Current.Resources["MenuImageHorizontal"];
            }

            var statusframe = mainStatusStack.Children.Take(3).OfType<Frame>().ToList();
            var statustack = statusframe.Take(3).Select(t => t.Content as StackLayout);
            foreach (var item in statustack)
            {
                item.Children.OfType<Image>().FirstOrDefault().Style = (Style)Application.Current.Resources["StatusImageFrameHorizontal"];
            }
        }

        private void LoadVerticalFonts()
        {
            var subframes = subActionsGrid.Children.Take(5).OfType<Frame>().ToList();
            var substacks = subframes.Take(5).Select(x => x.Content as StackLayout);
            foreach (var item in substacks)
            {
                item.Children.OfType<Label>().FirstOrDefault().Style = (Style)Application.Current.Resources["SubMenuFontVertical"];
                item.Children.OfType<Image>().FirstOrDefault().Style = (Style)Application.Current.Resources["SubMenuImageVertical"];
            }

            var frames = actionsGrid.Children.Take(8).OfType<Frame>().ToList();
            var stacks = frames.Take(8).Select(c => c.Content as StackLayout);
            foreach (var item in stacks)
            {
                item.Children.OfType<Label>().FirstOrDefault().Style = (Style)Application.Current.Resources["MenuFontVertical"];
                item.Children.OfType<Image>().FirstOrDefault().Style = (Style)Application.Current.Resources["MenuImageVertical"];
            }

            var statusframe = mainStatusStack.Children.Take(6).OfType<Frame>().ToList();
            var statustack = statusframe.Take(3).Select(t => t.Content as StackLayout);
            foreach (var item in statustack)
            {
                item.Children.OfType<Label>().FirstOrDefault().Style = (Style)Application.Current.Resources["SubMenuFontVertical"];
                item.Children.OfType<Image>().FirstOrDefault().Style = (Style)Application.Current.Resources["StatusImageFrameVertical"];
            }
        }
    }
    
}