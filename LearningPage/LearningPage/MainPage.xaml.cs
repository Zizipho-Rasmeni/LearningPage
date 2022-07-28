using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearningPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void Blogs_Clicked(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new Blogs());
        }

        private void Videos_Clicked(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new Video());
        }
    }
}
