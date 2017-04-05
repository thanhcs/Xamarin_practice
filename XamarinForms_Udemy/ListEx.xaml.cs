using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms_Udemy.Models;
using XamarinForms_Udemy.Service;

namespace XamarinForms_Udemy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEx : ContentPage
    {
        ObservableCollection<SearchGroup> items;
        public ListEx()
        {
            InitializeComponent();
            var allItems = new SearchService();
            items = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", "S")
                {

                }
            }
            listView.BindingContext = items;
        }
    }
}
