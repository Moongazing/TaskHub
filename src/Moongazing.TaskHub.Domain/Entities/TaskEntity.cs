using Moongazing.Core.Persistence.Repositories;
using Moongazing.TaskHub.Domain.Enums;

namespace Moongazing.TaskHub.Domain.Entities;

public class TaskEntity : Entity<Guid>
{

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public TaskPriority Priority { get; set; }
    public Enums.TaskStatus Status { get; set; }
    public ICollection<Task>? SubTasks { get; set; }
    public Guid? ParentTaskId { get; set; }
    public Task? ParentTask { get; set; }

    public TaskEntity(Guid id,
                      string title,
                      string description,
                      TaskPriority priority,
                      Enums.TaskStatus taskStatus)
        : base(id)
    {
        
        Title = title;
        Description = description;
        Priority = priority;
        Status = taskStatus;
    }

}
