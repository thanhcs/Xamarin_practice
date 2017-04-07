using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinForms_Udemy.Models;

namespace XamarinForms_Udemy.Service
{
    class SearchService
    {
       List<Search> rentals;
        public SearchService()
        {
            rentals = new List<Search>
            {
                new Search()
                {
                    Id = 1,
                    Location = "West Hollyword, CA, United States",
                    CheckIn = new DateTime(2016, 9, 1),
                    CheckOut = new DateTime(2016, 11, 1)
                },
                new Search()
                {
                    Id = 2,
                    Location = "Santa Monica, CA, United States",
                    CheckIn = new DateTime(2016, 9, 1),
                    CheckOut = new DateTime(2016, 11, 1)
                },
            };
        }
        public void DeleteSearch(int searchId)
        {
            rentals.Remove(rentals.Single(s => s.Id == searchId));
        }

        public IEnumerable<Search> GetSearches(string filter = null)
        {
            if (String.IsNullOrWhiteSpace(filter))
            {
                return rentals;
            }

            return rentals.Where(i => i.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
