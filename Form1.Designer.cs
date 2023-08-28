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
            inputExpression = new TextBox();
            outputExpression = new TextBox();
            slopetxt = new TextBox();
            intercepttxt = new TextBox();
            evaluate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            draw = new Button();
            pictureBox = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // inputExpression
            // 
            inputExpression.Location = new Point(235, 27);
            inputExpression.Name = "inputExpression";
            inputExpression.Size = new Size(100, 23);
            inputExpression.TabIndex = 1;
            // 
            // outputExpression
            // 
            outputExpression.Location = new Point(235, 85);
            outputExpression.Name = "outputExpression";
            outputExpression.Size = new Size(100, 23);
            outputExpression.TabIndex = 2;
            // 
            // slopetxt
            // 
            slopetxt.Location = new Point(235, 166);
            slopetxt.Name = "slopetxt";
            slopetxt.Size = new Size(100, 23);
            slopetxt.TabIndex = 3;
            // 
            // intercepttxt
            // 
            intercepttxt.Location = new Point(235, 211);
            intercepttxt.Name = "intercepttxt";
            intercepttxt.Size = new Size(100, 23);
            intercepttxt.TabIndex = 4;
            // 
            // evaluate
            // 
            evaluate.Location = new Point(235, 126);
            evaluate.Name = "evaluate";
            evaluate.Size = new Size(100, 23);
            evaluate.TabIndex = 6;
            evaluate.Text = "Evaluate";
            evaluate.UseVisualStyleBackColor = true;
            evaluate.Click += evaluate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 35);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 7;
            label1.Text = "Input Expression";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 93);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 8;
            label2.Text = "Output Expression";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 174);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Slope";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 219);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "Intercept";
            // 
            // draw
            // 
            draw.Location = new Point(235, 263);
            draw.Name = "draw";
            draw.Size = new Size(100, 23);
            draw.TabIndex = 11;
            draw.Text = "Draw Line";
            draw.UseVisualStyleBackColor = true;
            draw.Click += draw_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(465, 27);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(288, 267);
            pictureBox.TabIndex = 12;
            pictureBox.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(235, 327);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 13;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(pictureBox);
            Controls.Add(draw);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(evaluate);
            Controls.Add(intercepttxt);
            Controls.Add(slopetxt);
            Controls.Add(outputExpression);
            Controls.Add(inputExpression);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputExpression;
        private TextBox outputExpression;
        private TextBox slopetxt;
        private TextBox intercepttxt;
        private Button evaluate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button draw;
        private PictureBox pictureBox;
        private Button button2;
    }
}