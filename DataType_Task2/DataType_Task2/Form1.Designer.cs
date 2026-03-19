namespace DataType_Task2
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
            textBoxDiagonal = new TextBox();
            label1 = new Label();
            buttonResult = new Button();
            richTextBoxRhombus = new RichTextBox();
            SuspendLayout();
            // 
            // textBoxDiagonal
            // 
            textBoxDiagonal.Location = new Point(128, 32);
            textBoxDiagonal.Name = "textBoxDiagonal";
            textBoxDiagonal.Size = new Size(127, 23);
            textBoxDiagonal.TabIndex = 0;
            textBoxDiagonal.TextChanged += textBoxDiagonal_TextChanged;
            textBoxDiagonal.KeyPress += textBoxDiagonal_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 35);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "N = ";
            // 
            // buttonResult
            // 
            buttonResult.Enabled = false;
            buttonResult.Location = new Point(92, 71);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(163, 37);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Вывести ромб";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // richTextBoxRhombus
            // 
            richTextBoxRhombus.Location = new Point(12, 129);
            richTextBoxRhombus.Name = "richTextBoxRhombus";
            richTextBoxRhombus.Size = new Size(368, 309);
            richTextBoxRhombus.TabIndex = 3;
            richTextBoxRhombus.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(richTextBoxRhombus);
            Controls.Add(buttonResult);
            Controls.Add(label1);
            Controls.Add(textBoxDiagonal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDiagonal;
        private Label label1;
        private Button buttonResult;
        private RichTextBox richTextBoxRhombus;
    }
}
