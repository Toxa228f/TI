namespace Lab2
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
            openFileButton = new Button();
            saveFileButton = new Button();
            startListBox = new ListBox();
            startRegisterTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            finalListBox = new ListBox();
            label4 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            keyListBox = new RichTextBox();
            SuspendLayout();
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(12, 12);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(200, 61);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Открыть файл";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // saveFileButton
            // 
            saveFileButton.Location = new Point(627, 12);
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(200, 61);
            saveFileButton.TabIndex = 1;
            saveFileButton.Text = "Сохранить файл";
            saveFileButton.UseVisualStyleBackColor = true;
            saveFileButton.Click += saveFileButton_Click;
            // 
            // startListBox
            // 
            startListBox.FormattingEnabled = true;
            startListBox.ItemHeight = 25;
            startListBox.Location = new Point(12, 136);
            startListBox.Name = "startListBox";
            startListBox.Size = new Size(381, 254);
            startListBox.TabIndex = 2;
            // 
            // startRegisterTextBox
            // 
            startRegisterTextBox.Location = new Point(218, 40);
            startRegisterTextBox.Name = "startRegisterTextBox";
            startRegisterTextBox.Size = new Size(403, 33);
            startRegisterTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 12);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 4;
            label1.Text = "Исходные биты регистра";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(303, 25);
            label2.TabIndex = 5;
            label2.Text = "Исходный файл в двоичном виде";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 108);
            label3.Name = "label3";
            label3.Size = new Size(326, 25);
            label3.TabIndex = 6;
            label3.Text = "Полученный файл в двоичном виде";
            // 
            // finalListBox
            // 
            finalListBox.FormattingEnabled = true;
            finalListBox.ItemHeight = 25;
            finalListBox.Location = new Point(446, 136);
            finalListBox.Name = "finalListBox";
            finalListBox.Size = new Size(381, 254);
            finalListBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 409);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 8;
            label4.Text = "Полученные биты ключа";
            // 
            // button1
            // 
            button1.Location = new Point(627, 437);
            button1.Name = "button1";
            button1.Size = new Size(200, 79);
            button1.TabIndex = 10;
            button1.Text = "Зашифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // keyListBox
            // 
            keyListBox.Location = new Point(12, 437);
            keyListBox.Name = "keyListBox";
            keyListBox.Size = new Size(609, 79);
            keyListBox.TabIndex = 11;
            keyListBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 530);
            Controls.Add(keyListBox);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(finalListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startRegisterTextBox);
            Controls.Add(startListBox);
            Controls.Add(saveFileButton);
            Controls.Add(openFileButton);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFileButton;
        private Button saveFileButton;
        private ListBox startListBox;
        private TextBox startRegisterTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox finalListBox;
        private Label label4;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox keyListBox;
    }
}
