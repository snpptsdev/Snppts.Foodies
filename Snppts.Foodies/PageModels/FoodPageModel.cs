using System;
using PropertyChanged;
using FreshMvvm;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Snppts.Foodies
{
    [ImplementPropertyChanged]
    public class FoodPageModel : FreshBasePageModel
    {
        private Smoothie _selectedItem;

        public ObservableCollection<Smoothie> Smoothies{ get; set; }

        public Smoothie SelectedItem
        {
            get
            {
                return _selectedItem; 
            }
            set
            {
                _selectedItem = value;

                if (_selectedItem == null)
                    return;

                SelectedItem = null;
            }
        }

        public FoodPageModel()
        {
            Smoothies = new ObservableCollection<Smoothie>();
            Smoothies.Add(new Smoothie{ Name = "Blackberry-Kale Gelatinous Sludge Smoothie", Description = "Tastes like vomit.", ImagePath = "bkgss.png" });
            Smoothies.Add(new Smoothie{ Name = "Funky Asparagus Disaster Smoothie", Description = "Asparagus makes your pee stink.", ImagePath = "fads.png" });
            Smoothies.Add(new Smoothie{ Name = "Broccoli Bleck Smoothie", Description = "Broccoli doesn’t play nice with fruit.", ImagePath = "bbs.png"  });
            Smoothies.Add(new Smoothie{ Name = "Sweet Guacamole Smoothie", Description = "Avocado makes nothing taste better.", ImagePath = "sgs.png" });
        }
    }
}

