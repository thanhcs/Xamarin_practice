using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinForms_Udemy.Models;
using XamarinForms_Udemy.Service.Interface;

namespace XamarinForms_Udemy.Service
{
    class SearchService : ISearchService
    {
        List<Search> rentals;
        public SearchService()
        {
            rentals = new List<Search>()
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
        public void DeleteSearch(Search item)
        {
            rentals.Remove(item);
        }

        public IEnumerable<Search> GetSearches(string filter = null)
        {
            if (String.IsNullOrWhiteSpace(filter))
            {
                return rentals;
            }

            return rentals.Where(i => i.Location.Contains(filter));
        }
    }
}
