namespace WinFormsApp1
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
            textBoxInitialDeposit = new TextBox();
            textBoxYears = new TextBox();
            textBoxInterestRate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonResult = new Button();
            richTextBoxResult = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // textBoxInitialDeposit
            // 
            textBoxInitialDeposit.Location = new Point(62, 57);
            textBoxInitialDeposit.Name = "textBoxInitialDeposit";
            textBoxInitialDeposit.Size = new Size(125, 23);
            textBoxInitialDeposit.TabIndex = 0;
            textBoxInitialDeposit.TextChanged += AllTextBoxes_TextChanged;
            textBoxInitialDeposit.KeyPress += textBoxInitialDeposit_KeyPress;
            // 
            // textBoxYears
            // 
            textBoxYears.Location = new Point(193, 57);
            textBoxYears.Name = "textBoxYears";
            textBoxYears.Size = new Size(135, 23);
            textBoxYears.TabIndex = 1;
            textBoxYears.TextChanged += AllTextBoxes_TextChanged;
            textBoxYears.KeyPress += textBoxYears_KeyPress;
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Location = new Point(334, 57);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(118, 23);
            textBoxInterestRate.TabIndex = 2;
            textBoxInterestRate.TextChanged += AllTextBoxes_TextChanged;
            textBoxInterestRate.KeyPress += textBoxInterestRate_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 39);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Начальный вклад";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 39);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество лет";
            // 
            // label3
            // 
            label3.Location = new Point(334, 22);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 5;
            label3.Text = "Годовая процентная ставка";
            // 
            // buttonResult
            // 
            buttonResult.Enabled = false;
            buttonResult.Location = new Point(163, 97);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(195, 47);
            buttonResult.TabIndex = 6;
            buttonResult.Text = "Рассчитать сумму накоплений";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Location = new Point(58, 159);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(418, 273);
            richTextBoxResult.TabIndex = 7;
            richTextBoxResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 456);
            Controls.Add(richTextBoxResult);
            Controls.Add(buttonResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxInterestRate);
            Controls.Add(textBoxYears);
            Controls.Add(textBoxInitialDeposit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInitialDeposit;
        private TextBox textBoxYears;
        private TextBox textBoxInterestRate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonResult;
        private RichTextBox richTextBoxResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
