using System;
using Xamarin.Forms;
using FreshMvvm;

namespace Snppts.Foodies
{
    
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            var master = new HamburgerPage();
            Master = master;

            // The root page of your application
            var navContainer = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<FoodPageModel>());
            navContainer.BarTextColor = Color.FromHex("#3c3947");
            Detail = navContainer;
        }
    }
}

