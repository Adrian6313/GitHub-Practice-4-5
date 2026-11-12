using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GitPractice
{
    public partial class Form1 : Form
    {
        private readonly List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        public Form1()
        {
            InitializeComponent();
            InitializeInterface();
            WireEvents();
            AddSampleData();
            RefreshGrid();
        }

        private void InitializeInterface()
        {
            cmbPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
            cmbPriority.SelectedItem = TaskPriority.Средний;
            cmbFilter.SelectedIndex = 0;

            ConfigureGridColumns();
        }

        private void ConfigureGridColumns()
        {
            dgvTasks.AutoGenerateColumns = false;
            dgvTasks.Columns.Clear();

            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TaskItem.Id),
                HeaderText = "№",
                Width = 45
            });

            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TaskItem.Title),
                HeaderText = "Название задачи",
                Width = 200
            });

            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TaskItem.Priority),
                HeaderText = "Приоритет",
                Width = 90
            });

            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TaskItem.DueDate),
                HeaderText = "Срок",
                Width = 85,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
            });

            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TaskItem.StatusText),
                HeaderText = "Статус",
                Width = 95
            });
        }

        private void WireEvents()
        {
            btnAddTask.Click += BtnAddTask_Click;
            btnToggleDone.Click += BtnToggleDone_Click;
            btnDeleteTask.Click += BtnDeleteTask_Click;
            btnClearFields.Click += BtnClearFields_Click;

            // Search and filter events
            txtSearch.TextChanged += (s, e) => RefreshGrid();
            cmbFilter.SelectedIndexChanged += (s, e) => RefreshGrid();

            // Новая функциональность ветки AddFunction
            btnExportJson.Click += BtnExportJson_Click;
            btnStats.Click += BtnStats_Click;
        }

        private void AddSampleData()
        {
            _tasks.Add(new TaskItem
            {
                Id = _nextId++,
                Title = "Изучить базовые команды Git",
                Description = "Ознакомиться с командами init, add, commit, status, log",
                Priority = TaskPriority.Высокий,
                DueDate = DateTime.Today.AddDays(2),
                IsCompleted = true
            });

            _tasks.Add(new TaskItem
            {
                Id = _nextId++,
                Title = "Создать ветку AddFunction",
                Description = "Выполнить практическую часть по ветвлению в репозитории",
                Priority = TaskPriority.Критический,
                DueDate = DateTime.Today.AddDays(1),
                IsCompleted = false
            });

            _tasks.Add(new TaskItem
            {
                Id = _nextId++,
                Title = "Подготовить отчёт DOCX",
                Description = "Оформить отчёт по требованиям практической работы №4-5",
                Priority = TaskPriority.Средний,
                DueDate = DateTime.Today.AddDays(3),
                IsCompleted = false
            });
        }

        private void BtnAddTask_Click(object? sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            
            // Enhanced Validation
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Ошибка валидации: название задачи не может быть пустым!", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (title.Length < 3)
            {
                MessageBox.Show("Ошибка валидации: длина названия задачи должна быть не менее 3 символов!", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (dtpDueDate.Value.Date < DateTime.Today.AddMonths(-1))
            {
                MessageBox.Show("Предупреждение: дата срока задачи не может быть старше одного месяца!", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var task = new TaskItem
            {
                Id = _nextId++,
                Title = title,
                Description = txtDesc.Text.Trim(),
                Priority = (TaskPriority)cmbPriority.SelectedItem!,
                DueDate = dtpDueDate.Value.Date,
                IsCompleted = false,
                CreatedAt = DateTime.Now
            };

            _tasks.Add(task);
            ClearInputFields();
            RefreshGrid();
        }

        private void BtnToggleDone_Click(object? sender, EventArgs e)
        {
            var task = GetSelectedTask();
            if (task == null)
            {
                MessageBox.Show("Выберите задачу из списка для изменения статуса.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            task.IsCompleted = !task.IsCompleted;
            RefreshGrid();
        }

        private void BtnDeleteTask_Click(object? sender, EventArgs e)
        {
            var task = GetSelectedTask();
            if (task == null)
            {
                MessageBox.Show("Выберите задачу для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Удалить задачу '{task.Title}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _tasks.Remove(task);
                RefreshGrid();
            }
        }

        private void BtnClearFields_Click(object? sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            txtDesc.Clear();
            cmbPriority.SelectedItem = TaskPriority.Средний;
            dtpDueDate.Value = DateTime.Today.AddDays(1);
            txtTitle.Focus();
        }

        private void BtnExportJson_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Экспорт списка задач в JSON",
                Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*",
                FileName = $"tasks_export_{DateTime.Now:yyyyMMdd_HHmmss}.json"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TaskExporter.ExportToJson(sfd.FileName, _tasks);
                    MessageBox.Show($"Данные успешно экспортированы!\nФайл: {sfd.FileName}", "Экспорт завершён", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnStats_Click(object? sender, EventArgs e)
        {
            var report = TaskExporter.GetSummaryReport(_tasks);
            MessageBox.Show(report, "Аналитика и статистика задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private TaskItem? GetSelectedTask()
        {
            if (dgvTasks.CurrentRow?.DataBoundItem is TaskItem item)
            {
                return item;
            }
            return null;
        }

        private void RefreshGrid()
        {
            IEnumerable<TaskItem> filtered = _tasks;

            // Apply search query
            var query = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                filtered = filtered.Where(t => 
                    t.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                    t.Description.Contains(query, StringComparison.OrdinalIgnoreCase));
            }

            // Apply status filter
            switch (cmbFilter.SelectedIndex)
            {
                case 1: // Только активные
                    filtered = filtered.Where(t => !t.IsCompleted);
                    break;
                case 2: // Только выполненные
                    filtered = filtered.Where(t => t.IsCompleted);
                    break;
            }

            dgvTasks.DataSource = null;
            dgvTasks.DataSource = filtered.ToList();

            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            int total = _tasks.Count;
            int done = _tasks.Count(t => t.IsCompleted);
            int active = total - done;

            lblStatusInfo.Text = $"[TaskManager v2.0] Задач: {total} | Завершено: {done} | В работе: {active} | Экспорт JSON активен | Время: {DateTime.Now:HH:mm:ss}";
        }
    }
}
