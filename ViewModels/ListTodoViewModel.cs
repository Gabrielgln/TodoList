using TWTodoList.Models;

namespace TWTodoList.ViewModels;

class ListTodoViewModel
{
    public List<Todo> Todos { get; set; }
    public ListTodoViewModel()
    {
        Todos = new List<Todo>();
    }
    public ListTodoViewModel(List<Todo> todos)
    {
        Todos = todos;
    }
}