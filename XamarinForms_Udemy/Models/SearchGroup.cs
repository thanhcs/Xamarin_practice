﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms_Udemy.Models
{
    public class SearchGroup : ObservableCollection<Search>
    {
        public string Title { get; set; }

        public SearchGroup(string title, IEnumerable<Search> searches = null) : base(searches)
        {
            Title = title;
        }
    }
}
