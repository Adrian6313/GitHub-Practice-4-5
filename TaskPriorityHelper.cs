using System.Drawing;

namespace GitPractice
{
    /// <summary>
    /// Вспомогательный класс для визуального оформления приоритетов задач.
    /// Реализован вторым участником команды в рамках демонстрации совместной работы в Git.
    /// </summary>
    public static class TaskPriorityHelper
    {
        public static Color GetPriorityColor(TaskPriority priority)
        {
            return priority switch
            {
                TaskPriority.Критический => Color.FromArgb(231, 76, 60),  // Red
                TaskPriority.Высокий => Color.FromArgb(230, 126, 34),     // Orange
                TaskPriority.Средний => Color.FromArgb(241, 196, 15),     // Yellow
                TaskPriority.Низкий => Color.FromArgb(46, 204, 113),      // Green
                _ => Color.Gray
            };
        }

        public static string GetPriorityBadge(TaskPriority priority)
        {
            return priority switch
            {
                TaskPriority.Критический => "[!!!] Критический",
                TaskPriority.Высокий => "[!!] Высокий",
                TaskPriority.Средний => "[!] Средний",
                TaskPriority.Низкий => "[*] Низкий",
                _ => "[?] Неизвестно"
            };
        }
    }
}
