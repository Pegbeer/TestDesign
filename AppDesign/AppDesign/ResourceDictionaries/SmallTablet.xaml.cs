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
    public partial class SmallTablet : ResourceDictionary
    {
        public static SmallTablet SharedInstance { get; } = new SmallTablet();
        public SmallTablet()
        {
            InitializeComponent();
        }
    }
}