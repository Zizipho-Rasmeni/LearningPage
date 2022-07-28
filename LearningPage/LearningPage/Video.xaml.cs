using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Video : ContentPage
    {
        public Video()
        {
            InitializeComponent();
        }

        private void Videos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Video());
        }


    }
}