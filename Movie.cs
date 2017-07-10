using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Movies
{
    class Movie
    {
        private string category;
        private string title;
        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
        public string GetCat()
        {
            return this.category;
        }
        public string GetTitle()
        {
            return this.title;
        }
    }
}
