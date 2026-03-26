namespace OOP_Rectangles
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
            label2 = new Label();
            textBoxCoordX = new TextBox();
            textBoxCoordY = new TextBox();
            label3 = new Label();
            textBoxWidth = new TextBox();
            label4 = new Label();
            textBoxHeight = new TextBox();
            label5 = new Label();
            buttonResult = new Button();
            labelResult = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelSquare = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Координата X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 39);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Координата Y";
            // 
            // textBoxCoordX
            // 
            textBoxCoordX.Location = new Point(10, 57);
            textBoxCoordX.Name = "textBoxCoordX";
            textBoxCoordX.Size = new Size(100, 23);
            textBoxCoordX.TabIndex = 2;
            textBoxCoordX.TextChanged += AllTextBoxes_TextChanged;
            textBoxCoordX.KeyPress += AllTextBoxes_KeyPress;
            // 
            // textBoxCoordY
            // 
            textBoxCoordY.Location = new Point(116, 57);
            textBoxCoordY.Name = "textBoxCoordY";
            textBoxCoordY.Size = new Size(100, 23);
            textBoxCoordY.TabIndex = 3;
            textBoxCoordY.TextChanged += AllTextBoxes_TextChanged;
            textBoxCoordY.KeyPress += AllTextBoxes_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 13);
            label3.Name = "label3";
            label3.Size = new Size(241, 15);
            label3.TabIndex = 4;
            label3.Text = "Введите координаты левого верхнего угла";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(299, 57);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 6;
            textBoxWidth.TextChanged += AllTextBoxes_TextChanged;
            textBoxWidth.KeyPress += AllTextBoxes_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 39);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Ширина";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(405, 57);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 8;
            textBoxHeight.TextChanged += AllTextBoxes_TextChanged;
            textBoxHeight.KeyPress += AllTextBoxes_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 39);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 7;
            label5.Text = "Высота";
            // 
            // buttonResult
            // 
            buttonResult.Enabled = false;
            buttonResult.Location = new Point(10, 109);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(206, 34);
            buttonResult.TabIndex = 9;
            buttonResult.Text = "Вычислить P и S";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(12, 156);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 10;
            // 
            // panelSquare
            // 
            panelSquare.Location = new Point(259, 109);
            panelSquare.Name = "panelSquare";
            panelSquare.Size = new Size(226, 226);
            panelSquare.TabIndex = 11;
            //panelSquare.Paint += panelSquare_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 91);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 12;
            label6.Text = "(0, 0)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 337);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 13;
            label7.Text = "(225, 225)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 337);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 14;
            label8.Text = "(0, 225)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(472, 91);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 15;
            label9.Text = "(225, 0)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 371);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panelSquare);
            Controls.Add(labelResult);
            Controls.Add(buttonResult);
            Controls.Add(textBoxHeight);
            Controls.Add(label5);
            Controls.Add(textBoxWidth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxCoordY);
            Controls.Add(textBoxCoordX);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxCoordX;
        private TextBox textBoxCoordY;
        private Label label3;
        private TextBox textBoxWidth;
        private Label label4;
        private TextBox textBoxHeight;
        private Label label5;
        private Button buttonResult;
        private Label labelResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelSquare;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
