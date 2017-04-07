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
        private List<SearchGroup> searchGroupCollection;
        private SearchService _searchService;
        public ListEx()
        {
            InitializeComponent();
            
            _searchService = new SearchService();
            PopulateSearches();
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = e.NewTextValue;
            PopulateSearches(filter);
        }

        private void PopulateSearches(string filter = null)
        {
            listView.ItemsSource = searchGroupCollection = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", _searchService.GetSearches(filter))
            };

        }

        private void ListView_OnRefreshing(object sender, EventArgs e)
        {
            PopulateSearches(searchBar.Text);

            listView.EndRefresh();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Search;
            DisplayAlert("Location", item?.Location, "OK");
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var search = menuItem.CommandParameter as Search;
            _searchService.DeleteSearch(search.Id);

            searchGroupCollection[0].Remove(search);
        }
    }
}
