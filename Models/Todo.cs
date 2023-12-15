using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TWTodoList.Models;

[Table("todos")]
public class Todo{
    [Key]
    [Column("id")]
    public int Id {get; set;}
    [Required]
    [MaxLength(50)]
    //[Column("title", TypeName = "nvarchar(100)")]
    public string Title {get; set;}
    [Required]
    public DateTime Date {get; set;}
    [Required]
    public bool IsCompleted {get; set;}
    public Todo(string title, DateTime date, bool isCompleted = false)
    {
        Title = title;
        Date = date;
        IsCompleted = isCompleted;
    }
    public Todo(int id, string title, DateTime date, bool isCompleted = false)
    {
        Id = id;
        Title = title;
        Date = date;
        IsCompleted = isCompleted;
    }
}