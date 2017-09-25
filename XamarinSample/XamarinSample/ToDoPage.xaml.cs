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
    public partial class Page2 : ContentPage
    {
        public List<string> TodoItems { get; set; }
        public Page2()
        {
            InitializeComponent();

            this.TodoItems = new List<string>();
        }

        private void addTodoItemButton_Clicked(object sender, EventArgs e)
        {
            this.TodoItems.Add(newToDoItemEntry.Text);

            newToDoItemEntry.Text = "";

            todoItemsListView.ItemsSource = this.TodoItems;
        }

        private void removeToDoItemsButton_Clicked(object sender, EventArgs e)
        {
            this.TodoItems.Clear();

            todoItemsListView.ItemsSource = new List<string>();
        }
    }
}