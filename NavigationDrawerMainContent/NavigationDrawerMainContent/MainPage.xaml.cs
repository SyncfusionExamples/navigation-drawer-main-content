using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationDrawerMainContent
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            hamburgerButton.ImageSource = (FileImageSource)ImageSource.FromFile("burgericon.png");
            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Profile");
            list.Add("Inbox");
            list.Add("Out box");
            list.Add("Sent");
            list.Add("Draft");
            listView.ItemsSource = list;
        }
        void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem.ToString() == "Home")
                contentLabel.Text = "Home";
            else if (e.SelectedItem.ToString() == "Profile")
                contentLabel.Text = "Profile";
            else if (e.SelectedItem.ToString() == "Inbox")
                contentLabel.Text = "Inbox";
            else if (e.SelectedItem.ToString() == "Out box")
                contentLabel.Text = "Out box";
            else if (e.SelectedItem.ToString() == "Sent")
                contentLabel.Text = "Sent";
            else if (e.SelectedItem.ToString() == "Draft")
                contentLabel.Text = "The folder is empty";
            navigationDrawer.ToggleDrawer();
        }
    }
}
