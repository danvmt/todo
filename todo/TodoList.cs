using System;
using System.Collections.ObjectModel;

namespace Todo
{
    public class TodoList
    {
        private ObservableCollection<TodoItem> todoItems = new ObservableCollection<TodoItem>();

        public ObservableCollection<TodoItem> TodoItems
        {
            get { return todoItems;  }
        }

        static string[] images = { "blinky.png", "clyde.png", "inky.png", "pinky.png" }; 

        public TodoList()
        {
            //todoItems.Add(new TodoItem { Text = "Todo 1", Detail = "Add new things to do", Image  = "inky.png" });
            //todoItems.Add(new TodoItem { Text = "Todo 2", Detail = "Do things to do" , Image = "blinky.png"});
            //todoItems.Add(new TodoItem { Text = "Todo 3", Detail = "Delete done things", Image = "inky.png" });

            var rand = new Random();

            for (int i = 0; i < 10000; i++)
            {
                var todo = new TodoItem { Text = "Todo " + i, Detail = "Yada yada", Image = images[rand.Next(4)] };
                todoItems.Add(todo);
            }

        }

        public void AddItem(string itemText, string detailText, string pickerImage)
        {
            todoItems.Add(new TodoItem { Text = itemText, Detail = detailText, Image = pickerImage});
        }
    }
}
