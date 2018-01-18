using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Todo
{
    public partial class AddItemPage : ContentPage
    {
        public AddItemPage()
        {
            InitializeComponent();
        }

        private void Handle_Completed(object sender, EventArgs e)
        {
            var itemText = ItemEntry.Text;
            var detailText = DetailEntry.Text;
            var pickerImage = PacmanPicker.SelectedItem + ".png";

            //Add item
            AppContext.TodoList.AddItem(itemText, detailText, pickerImage);

            ItemEntry.Text = "";
            DetailEntry.Text = "";

            Navigation.PopToRootAsync();

        }
    }
}
