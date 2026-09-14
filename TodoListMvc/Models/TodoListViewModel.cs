namespace TodoListMvc.Models;
public class TodoListViewModel
{
    public List<TodoItem> Items { get; set; } = [];
    public string? Search { get; set; }
    public TodoStatus? Status { get; set; }
    public int Total => Items.Count;
    public int Pending => Items.Count(x=>x.Status==TodoStatus.PENDIENTE);
    public int InProgress => Items.Count(x=>x.Status==TodoStatus.EN_PROGRESO);
    public int Completed => Items.Count(x=>x.Status==TodoStatus.COMPLETADA);
}
