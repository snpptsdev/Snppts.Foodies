using System;

namespace Snppts.Foodies
{
    public class Smoothie
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string NameToUpper { get { return Name.ToUpper(); } }
    }
}

