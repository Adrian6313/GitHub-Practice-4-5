using System;
using System.Collections.Generic;
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
        }

        private void BtnAddTask_Click(object? sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Введите название задачи!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _tasks.ToList();

            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            int total = _tasks.Count;
            int done = _tasks.Count(t => t.IsCompleted);
            int active = total - done;

            lblStatusInfo.Text = $"Задач: {total} | Завершено: {done} | В работе: {active}";
        }
    }
}
