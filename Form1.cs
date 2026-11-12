using System;
using System.Collections.Generic;
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
    }
}
