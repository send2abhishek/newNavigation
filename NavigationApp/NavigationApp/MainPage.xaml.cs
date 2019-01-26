using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NavigationApp.Models;
using NavigationApp.ViewPage;

namespace NavigationApp
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            var list = new List<Contacts>
            {
                new Contacts{ Fname ="Abhishek Aryan"},
                new Contacts{ Fname ="Aryan"}
                

            };

            myList.ItemsSource = list;






        }

        private void MyList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var contact = e.Item as Contacts;

            Detail = new NavigationPage(new DetailsPage(contact));
           

            //await Navigation.PushAsync(new DetailsPage(contact));

            //In order to present details we need to set IsPresented = false

            IsPresented = false;


        }
    }
}
