namespace api.Models;

public class TodoItem
{
    public int Id {get;set;}
    public string Title {get;set;} = default!;
    public bool IsDone {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.UtcNow;

    public int Priority {get; set;} = 1;
}
