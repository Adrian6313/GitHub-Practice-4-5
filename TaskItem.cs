using System;

namespace GitPractice
{
    public enum TaskPriority
    {
        Низкий,
        Средний,
        Высокий,
        Критический
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; } = TaskPriority.Средний;
        public DateTime DueDate { get; set; } = DateTime.Today.AddDays(1);
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string StatusText => IsCompleted ? "Выполнено" : "В процессе";
    }
}
