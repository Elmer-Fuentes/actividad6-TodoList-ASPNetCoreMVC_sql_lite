using System.ComponentModel.DataAnnotations;
namespace TodoListMvc.Models;
public class TodoItem
{
    public int Id { get; set; }
    [Required(ErrorMessage="El título es obligatorio.")][StringLength(100)][Display(Name="Título")]
    public string Title { get; set; } = string.Empty;
    [StringLength(500)][Display(Name="Descripción")]
    public string? Description { get; set; }
    [Required][Display(Name="Estado")]
    public TodoStatus Status { get; set; } = TodoStatus.PENDIENTE;
    [Display(Name="Fecha de creación")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
