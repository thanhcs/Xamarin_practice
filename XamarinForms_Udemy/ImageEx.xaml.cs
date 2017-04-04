using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms_Udemy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageEx : ContentPage
    {
        public ImageEx()
        {
            InitializeComponent();
            image.Source = new UriImageSource {
                Uri = new Uri("http://lorempixel.com/1920/1080/city/1"),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1);
            };
        }
    }
}
