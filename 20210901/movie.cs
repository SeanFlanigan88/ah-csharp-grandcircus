using System;

namespace _20210901
{

    public class Movie
    {
        private string _title = "";

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        private string _category = string.Empty;


        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public override string ToString()
        {
            return $"Title: {Title} Category: {Category}";
        }

    }
}