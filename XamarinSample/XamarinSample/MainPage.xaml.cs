using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

       

        private void ToDo_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToDoPage());
        }

        private void Back_End_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BackEndCalculations());
        }

        private void GridButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }
    }
}
