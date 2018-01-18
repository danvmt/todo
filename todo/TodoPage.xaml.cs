using Xamarin.Forms;
using System.Collections.ObjectModel;
using System;

namespace Todo
{
    public partial class TodoPage : ContentPage
    {
        //ObservableCollection<TodoItem> todoItems = new ObservableCollection<TodoItem>();
            
        public TodoPage()
        {
            InitializeComponent();

            listView.ItemTemplate = new DataTemplate(typeof(CustomCell));

            listView.ItemsSource = AppContext.TodoList.TodoItems;
            listView.IsPullToRefreshEnabled = true;

            //todoView.ItemTem
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new AddItemPage());
        }

        private void OnDelete(object sender, EventArgs e)
        {
            var menuItem = ((MenuItem)sender);
            var todoItem = menuItem.BindingContext as TodoItem;

            if (todoItem != null)
            {
                AppContext.TodoList.TodoItems.Remove(todoItem);
            }
        }
    }
}
