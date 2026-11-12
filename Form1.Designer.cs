namespace GitPractice
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.GroupBox grpTaskDetails;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnToggleDone;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnExportJson;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.grpTaskDetails = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnToggleDone = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnExportJson = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();

            this.pnlHeader.SuspendLayout();
            this.grpTaskDetails.SuspendLayout();
            this.grpTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 70);
            this.pnlHeader.TabIndex = 0;

            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(430, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "TaskManager — Менеджер задач";

            // lblHeaderSubtitle
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 42);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(510, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Практическая работа №4–5: Git, ветвление, слияние веток и разрешение конфликтов";

            // grpTaskDetails
            this.grpTaskDetails.Controls.Add(this.btnStats);
            this.grpTaskDetails.Controls.Add(this.btnExportJson);
            this.grpTaskDetails.Controls.Add(this.btnClearFields);
            this.grpTaskDetails.Controls.Add(this.btnToggleDone);
            this.grpTaskDetails.Controls.Add(this.btnDeleteTask);
            this.grpTaskDetails.Controls.Add(this.btnAddTask);
            this.grpTaskDetails.Controls.Add(this.dtpDueDate);
            this.grpTaskDetails.Controls.Add(this.lblDueDate);
            this.grpTaskDetails.Controls.Add(this.cmbPriority);
            this.grpTaskDetails.Controls.Add(this.lblPriority);
            this.grpTaskDetails.Controls.Add(this.txtDesc);
            this.grpTaskDetails.Controls.Add(this.lblDesc);
            this.grpTaskDetails.Controls.Add(this.txtTitle);
            this.grpTaskDetails.Controls.Add(this.lblTitle);
            this.grpTaskDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpTaskDetails.Location = new System.Drawing.Point(12, 80);
            this.grpTaskDetails.Name = "grpTaskDetails";
            this.grpTaskDetails.Size = new System.Drawing.Size(320, 480);
            this.grpTaskDetails.TabIndex = 1;
            this.grpTaskDetails.TabStop = false;
            this.grpTaskDetails.Text = "Параметры задачи";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 17);
            this.lblTitle.Text = "Название:";

            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(18, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(285, 24);

            // lblDesc
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(15, 75);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(71, 17);
            this.lblDesc.Text = "Описание:";

            // txtDesc
            this.txtDesc.Location = new System.Drawing.Point(18, 95);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(285, 80);

            // lblPriority
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(15, 185);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(76, 17);
            this.lblPriority.Text = "Приоритет:";

            // cmbPriority
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(18, 205);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(285, 25);

            // lblDueDate
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(15, 240);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(120, 17);
            this.lblDueDate.Text = "Срок выполнения:";

            // dtpDueDate
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(18, 260);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(285, 24);

            // btnAddTask
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTask.Location = new System.Drawing.Point(18, 298);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(285, 32);
            this.btnAddTask.Text = "+ Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = false;

            // btnToggleDone
            this.btnToggleDone.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnToggleDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleDone.ForeColor = System.Drawing.Color.White;
            this.btnToggleDone.Location = new System.Drawing.Point(18, 335);
            this.btnToggleDone.Name = "btnToggleDone";
            this.btnToggleDone.Size = new System.Drawing.Size(285, 28);
            this.btnToggleDone.Text = "Сменить статус (Готово)";
            this.btnToggleDone.UseVisualStyleBackColor = false;

            // btnDeleteTask
            this.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDeleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Location = new System.Drawing.Point(18, 368);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(138, 28);
            this.btnDeleteTask.Text = "Удалить";
            this.btnDeleteTask.UseVisualStyleBackColor = false;

            // btnClearFields
            this.btnClearFields.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(165, 368);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(138, 28);
            this.btnClearFields.Text = "Очистить";
            this.btnClearFields.UseVisualStyleBackColor = false;

            // btnExportJson (Ветка AddFunction)
            this.btnExportJson.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnExportJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportJson.ForeColor = System.Drawing.Color.White;
            this.btnExportJson.Location = new System.Drawing.Point(18, 403);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(285, 29);
            this.btnExportJson.Text = "Экспорт в JSON";
            this.btnExportJson.UseVisualStyleBackColor = false;

            // btnStats (Ветка AddFunction)
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.Location = new System.Drawing.Point(18, 437);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(285, 29);
            this.btnStats.Text = "Статистика и отчёт";
            this.btnStats.UseVisualStyleBackColor = false;

            // grpTasks
            this.grpTasks.Controls.Add(this.dgvTasks);
            this.grpTasks.Controls.Add(this.pnlSearch);
            this.grpTasks.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpTasks.Location = new System.Drawing.Point(345, 80);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(627, 480);
            this.grpTasks.TabIndex = 2;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Список текущих задач";

            // pnlSearch
            this.pnlSearch.Controls.Add(this.cmbFilter);
            this.pnlSearch.Controls.Add(this.lblFilter);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(3, 20);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(621, 40);

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(5, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 17);
            this.lblSearch.Text = "Поиск:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(60, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 24);

            // lblFilter
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(310, 10);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(55, 17);
            this.lblFilter.Text = "Фильтр:";

            // cmbFilter
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] { "Все задачи", "Только активные", "Только выполненные" });
            this.cmbFilter.Location = new System.Drawing.Point(375, 7);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(235, 25);

            // dgvTasks
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.Location = new System.Drawing.Point(3, 60);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(621, 417);

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusInfo });
            this.statusStrip.Location = new System.Drawing.Point(0, 569);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);

            // lblStatusInfo
            this.lblStatusInfo.Name = "lblStatusInfo";
            this.lblStatusInfo.Size = new System.Drawing.Size(160, 17);
            this.lblStatusInfo.Text = "Готово. Задач в списке: 0";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpTasks);
            this.Controls.Add(this.grpTaskDetails);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManager — Учебный проект Git & GitHub";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpTaskDetails.ResumeLayout(false);
            this.grpTaskDetails.PerformLayout();
            this.grpTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
