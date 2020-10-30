using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDesign.ResourceDictionaries
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LargeTablet : ResourceDictionary
    {
        public static LargeTablet SharedInstance { get; } = new LargeTablet();
        public LargeTablet()
        {
            InitializeComponent();
        }
    }
}