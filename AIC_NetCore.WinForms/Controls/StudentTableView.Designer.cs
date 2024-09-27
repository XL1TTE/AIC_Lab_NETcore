namespace AIC_NetCore.WinForms.Controls
{
    partial class StudentTableView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            StudentTable = new DataGridView();
            panel2 = new Panel();
            ToGraphButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            StudentSpecialityBox = new TextBox();
            label3 = new Label();
            StudentGroupBox = new TextBox();
            label2 = new Label();
            StudentNameBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentTable).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(StudentTable);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 531);
            panel1.TabIndex = 0;
            // 
            // StudentTable
            // 
            StudentTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentTable.Location = new Point(0, 0);
            StudentTable.MultiSelect = false;
            StudentTable.Name = "StudentTable";
            StudentTable.ReadOnly = true;
            StudentTable.RowHeadersWidth = 51;
            StudentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentTable.Size = new Size(570, 531);
            StudentTable.TabIndex = 10;
            StudentTable.SelectionChanged += SelectedStudentChangedHandler;
            // 
            // panel2
            // 
            panel2.Controls.Add(ToGraphButton);
            panel2.Controls.Add(UpdateButton);
            panel2.Controls.Add(DeleteButton);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(StudentSpecialityBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(StudentGroupBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(StudentNameBox);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(577, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 528);
            panel2.TabIndex = 1;
            // 
            // ToGraphButton
            // 
            ToGraphButton.Location = new Point(48, 353);
            ToGraphButton.Name = "ToGraphButton";
            ToGraphButton.Size = new Size(94, 29);
            ToGraphButton.TabIndex = 9;
            ToGraphButton.Text = "К графику";
            ToGraphButton.UseVisualStyleBackColor = true;
            ToGraphButton.Click += GoToGraphicButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(48, 318);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Изменить";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateStudentButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(106, 283);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteStudentButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(6, 283);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddStudentButton_Click;
            // 
            // StudentSpecialityBox
            // 
            StudentSpecialityBox.Location = new Point(21, 237);
            StudentSpecialityBox.Name = "StudentSpecialityBox";
            StudentSpecialityBox.Size = new Size(162, 27);
            StudentSpecialityBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 214);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 4;
            label3.Text = "Специальность студента";
            // 
            // StudentGroupBox
            // 
            StudentGroupBox.Location = new Point(21, 184);
            StudentGroupBox.Name = "StudentGroupBox";
            StudentGroupBox.Size = new Size(162, 27);
            StudentGroupBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 161);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 2;
            label2.Text = "Группа студента";
            // 
            // StudentNameBox
            // 
            StudentNameBox.Location = new Point(21, 131);
            StudentNameBox.Name = "StudentNameBox";
            StudentNameBox.Size = new Size(162, 27);
            StudentNameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 108);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя студента";
            // 
            // StudentTableView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StudentTableView";
            Size = new Size(796, 528);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox StudentNameBox;
        private Label label1;
        private Button ToGraphButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button AddButton;
        private TextBox StudentSpecialityBox;
        private Label label3;
        private TextBox StudentGroupBox;
        private DataGridView StudentTable;
    }
}
