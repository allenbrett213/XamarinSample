using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BackEndCalculations : ContentPage
    {
        public BackEndCalculations()
        {
            InitializeComponent();
        }

        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            int entry1 = Convert.ToInt32(Entry1.Text);
            int entry2 = Convert.ToInt32(Entry2.Text);

            CalculateLabel.Text = "The sum of these is: " + (entry1 + entry2);
        }
    }
}