using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinForms_Udemy.Models;

namespace XamarinForms_Udemy.Service.Interface
{
    internal interface ISearchService
    {
        IEnumerable<Search> GetSearches(String filter = null);
        void DeleteSearch(Search item);
    }
}
