using System;
namespace Todo
{
    public static class AppContext
    {

        private static TodoList todoList;
        public static TodoList TodoList
        {
            get { return todoList = todoList ?? new TodoList(); }
        }
    }
}