namespace Lab3
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
            label1 = new Label();
            pTextBox = new TextBox();
            qTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            kTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            rTextBox = new TextBox();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 26);
            label1.TabIndex = 0;
            label1.Text = "Введите p:";
            // 
            // pTextBox
            // 
            pTextBox.Location = new Point(130, 12);
            pTextBox.Name = "pTextBox";
            pTextBox.Size = new Size(172, 34);
            pTextBox.TabIndex = 1;
            // 
            // qTextBox
            // 
            qTextBox.Location = new Point(130, 52);
            qTextBox.Name = "qTextBox";
            qTextBox.Size = new Size(172, 34);
            qTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 2;
            label2.Text = "Введите q:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 15);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(268, 26);
            label3.TabIndex = 4;
            label3.Text = "Введите закрытый ключ Кс:";
            // 
            // kTextBox
            // 
            kTextBox.Location = new Point(586, 12);
            kTextBox.Name = "kTextBox";
            kTextBox.Size = new Size(291, 34);
            kTextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(332, 51);
            button1.Name = "button1";
            button1.Size = new Size(195, 34);
            button1.TabIndex = 6;
            button1.Text = "Открыть файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 91);
            button2.Name = "button2";
            button2.Size = new Size(195, 34);
            button2.TabIndex = 7;
            button2.Text = "Сохранить файл";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 182);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(863, 169);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // rTextBox
            // 
            rTextBox.Location = new Point(130, 92);
            rTextBox.Name = "rTextBox";
            rTextBox.Size = new Size(172, 34);
            rTextBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 95);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 26);
            label4.TabIndex = 9;
            label4.Text = "Введите r:";
            // 
            // button3
            // 
            button3.Location = new Point(635, 55);
            button3.Name = "button3";
            button3.Size = new Size(195, 34);
            button3.TabIndex = 11;
            button3.Text = "Зашифровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(635, 95);
            button4.Name = "button4";
            button4.Size = new Size(195, 34);
            button4.TabIndex = 12;
            button4.Text = "Расшифровать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 153);
            label5.Name = "label5";
            label5.Size = new Size(105, 26);
            label5.TabIndex = 13;
            label5.Text = "Результат:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 359);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(rTextBox);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(kTextBox);
            Controls.Add(label3);
            Controls.Add(qTextBox);
            Controls.Add(label2);
            Controls.Add(pTextBox);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox pTextBox;
        private TextBox qTextBox;
        private Label label2;
        private Label label3;
        private TextBox kTextBox;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private TextBox rTextBox;
        private Label label4;
        private Button button3;
        private Button button4;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
