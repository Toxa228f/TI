namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            shipherMetodComboBox = new ComboBox();
            startTextBox = new RichTextBox();
            finalTextBox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            shipherFunctionComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            keyTextBox = new RichTextBox();
            errorKeyLabel = new Label();
            результатШифрованияToolStripMenuItem = new ToolStripMenuItem();
            параметрыПрограммыToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            textDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)textDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 0;
            label1.Text = "Выберите тип кодировки";
            // 
            // shipherMetodComboBox
            // 
            shipherMetodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shipherMetodComboBox.Font = new Font("Segoe UI", 14F);
            shipherMetodComboBox.FormattingEnabled = true;
            shipherMetodComboBox.Items.AddRange(new object[] { "Метод децимаций", "Виженер (самоген.)" });
            shipherMetodComboBox.Location = new Point(12, 47);
            shipherMetodComboBox.Name = "shipherMetodComboBox";
            shipherMetodComboBox.Size = new Size(295, 39);
            shipherMetodComboBox.TabIndex = 1;
            shipherMetodComboBox.SelectedIndexChanged += ShipherTypeComboBox_SelectedIndexChanged;
            // 
            // startTextBox
            // 
            startTextBox.Location = new Point(12, 123);
            startTextBox.Name = "startTextBox";
            startTextBox.Size = new Size(729, 285);
            startTextBox.TabIndex = 2;
            startTextBox.Text = "";
            startTextBox.TextChanged += startTextBox_TextChanged;
            // 
            // finalTextBox
            // 
            finalTextBox.Location = new Point(762, 123);
            finalTextBox.Name = "finalTextBox";
            finalTextBox.ReadOnly = true;
            finalTextBox.Size = new Size(729, 285);
            finalTextBox.TabIndex = 3;
            finalTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 4;
            label2.Text = "Исходный текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(762, 89);
            label3.Name = "label3";
            label3.Size = new Size(263, 32);
            label3.TabIndex = 5;
            label3.Text = "Зашифрованный текст";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // shipherFunctionComboBox
            // 
            shipherFunctionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shipherFunctionComboBox.Font = new Font("Segoe UI", 14F);
            shipherFunctionComboBox.FormattingEnabled = true;
            shipherFunctionComboBox.Items.AddRange(new object[] { "Шифрация", "Дешифрация" });
            shipherFunctionComboBox.Location = new Point(317, 47);
            shipherFunctionComboBox.Name = "shipherFunctionComboBox";
            shipherFunctionComboBox.Size = new Size(295, 39);
            shipherFunctionComboBox.TabIndex = 9;
            shipherFunctionComboBox.SelectedIndexChanged += shipherFunctionComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(317, 12);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 32);
            label4.TabIndex = 8;
            label4.Text = "Выберите функцию";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(631, 12);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 32);
            label5.TabIndex = 10;
            label5.Text = "Введите ключ";
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(631, 47);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(543, 39);
            keyTextBox.TabIndex = 11;
            keyTextBox.Text = "";
            keyTextBox.TextChanged += keyTextBox_TextChanged;
            // 
            // errorKeyLabel
            // 
            errorKeyLabel.AutoSize = true;
            errorKeyLabel.Font = new Font("Segoe UI", 14F);
            errorKeyLabel.Location = new Point(811, 12);
            errorKeyLabel.Margin = new Padding(5, 0, 5, 0);
            errorKeyLabel.Name = "errorKeyLabel";
            errorKeyLabel.Size = new Size(0, 32);
            errorKeyLabel.TabIndex = 12;
            // 
            // результатШифрованияToolStripMenuItem
            // 
            результатШифрованияToolStripMenuItem.Name = "результатШифрованияToolStripMenuItem";
            результатШифрованияToolStripMenuItem.Size = new Size(352, 36);
            результатШифрованияToolStripMenuItem.Text = "Зашифрованный текст";
            // 
            // параметрыПрограммыToolStripMenuItem
            // 
            параметрыПрограммыToolStripMenuItem.Name = "параметрыПрограммыToolStripMenuItem";
            параметрыПрограммыToolStripMenuItem.Size = new Size(352, 36);
            параметрыПрограммыToolStripMenuItem.Text = "Параметры программы";
            // 
            // button1
            // 
            button1.Location = new Point(1253, 12);
            button1.Name = "button1";
            button1.Size = new Size(240, 48);
            button1.TabIndex = 13;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += saveButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1253, 66);
            button2.Name = "button2";
            button2.Size = new Size(240, 48);
            button2.TabIndex = 14;
            button2.Text = "Открыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += openButton_Click;
            // 
            // textDataGridView
            // 
            textDataGridView.AllowUserToAddRows = false;
            textDataGridView.AllowUserToDeleteRows = false;
            textDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            textDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            textDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            textDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            textDataGridView.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            textDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            textDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            textDataGridView.Location = new Point(12, 427);
            textDataGridView.Name = "textDataGridView";
            textDataGridView.ReadOnly = true;
            textDataGridView.RowHeadersWidth = 51;
            textDataGridView.Size = new Size(1479, 193);
            textDataGridView.TabIndex = 15;
            textDataGridView.CellContentClick += textDataGridView_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 632);
            Controls.Add(textDataGridView);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(errorKeyLabel);
            Controls.Add(keyTextBox);
            Controls.Add(label5);
            Controls.Add(shipherFunctionComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(finalTextBox);
            Controls.Add(startTextBox);
            Controls.Add(shipherMetodComboBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Шифратор";
            ((System.ComponentModel.ISupportInitialize)textDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox shipherMetodComboBox;
        private RichTextBox startTextBox;
        private RichTextBox finalTextBox;
        private Label label2;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ComboBox shipherFunctionComboBox;
        private Label label4;
        private Label label5;
        private RichTextBox keyTextBox;
        private Label errorKeyLabel;
        private ToolStripMenuItem результатШифрованияToolStripMenuItem;
        private ToolStripMenuItem параметрыПрограммыToolStripMenuItem;
        private Button button1;
        private Button button2;
        private DataGridView textDataGridView;
    }
}
