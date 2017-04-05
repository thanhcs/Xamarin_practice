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
        int count;
        public ImageEx()
        {
            InitializeComponent();
            count = 1;
            image.Source = getImage();
        }

        private void OnNextHandler(object sender, EventArgs e)
        {
            if (count == 10)
            {
                count = 1;
            } else
            {
                ++count;
            }
            image.Source = getImage();
        }

        private void OnPre(object sender, EventArgs e)
        {
            if (count == 1)
            {
                count = 10;
            } else
            {
                --count;
            }
            image.Source = getImage();
        }

        private UriImageSource getImage()
        {
            return new UriImageSource
            {
                Uri = new Uri($"http://lorempixel.com/1920/1080/city/{count}"),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
        }
    }
}
