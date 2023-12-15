using Microsoft.AspNetCore.Mvc;
using TWTodoList.Models;
using TWTodoList.ViewModels;

namespace TWTodoList.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        //ViewData["apresentacao"] = "Olá ASP .NET CORE";
        //ViewData.Add("apresentacao", "Olá ASP .NET CORE");
        //var todo = new Todo
        //{
        //    Title = "Estudar .NET",
        //    Description = "Concluir o curso .NET"
        //};
        //ViewData["todo"] = todo;
        ViewBag.Todo = "todo";
        //TempData é mais utilizado para confirmação, exemplo: Cadastrado com sucesso
        TempData["message"] = "Mensagem vinda da action Index";

        return View();
    }

    public IActionResult Message()
    {
        return View();
    }

    public IActionResult ViewModel()
    {
        //var todo = new Todo
        //{
        //    Title = "Estudar .NET",
        //    Description = "Concluir o curso .NET"
        //};
        //var viewModel = new DetailsTodoViewModel
        //{
        //    Todo = todo,
        //    PageTitle = "Detalhes da tarefa"
        //};
        return View("viewModel");
    }
}
