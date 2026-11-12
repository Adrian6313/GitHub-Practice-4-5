using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace GitPractice
{
    public static class TaskExporter
    {
        public static void ExportToJson(string filePath, IEnumerable<TaskItem> tasks)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
            };

            var json = JsonSerializer.Serialize(tasks, options);
            File.WriteAllText(filePath, json);
        }

        public static string GetSummaryReport(IEnumerable<TaskItem> tasks)
        {
            var list = tasks.ToList();
            int total = list.Count;
            int completed = list.Count(t => t.IsCompleted);
            int pending = total - completed;
            double completionRate = total > 0 ? (completed * 100.0 / total) : 0;

            int critical = list.Count(t => t.Priority == TaskPriority.Критический);
            int high = list.Count(t => t.Priority == TaskPriority.Высокий);

            return $"=== СТАТИСТИКА ЗАДАЧ ===\n" +
                   $"Всего задач: {total}\n" +
                   $"Выполнено: {completed} ({completionRate:F1}%)\n" +
                   $"В работе: {pending}\n\n" +
                   $"Приоритеты:\n" +
                   $"- Критический: {critical}\n" +
                   $"- Высокий: {high}\n" +
                   $"- Средний: {list.Count(t => t.Priority == TaskPriority.Средний)}\n" +
                   $"- Низкий: {list.Count(t => t.Priority == TaskPriority.Низкий)}\n" +
                   $"Сформировано: {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
        }
    }
}
