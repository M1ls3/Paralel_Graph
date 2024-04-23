namespace Paralel_Graph
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.button_e = new System.Windows.Forms.Button();
            this.button_x1 = new System.Windows.Forms.Button();
            this.button_x2 = new System.Windows.Forms.Button();
            this.label_e = new System.Windows.Forms.Label();
            this.label_x1 = new System.Windows.Forms.Label();
            this.label_x2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_e
            // 
            this.textBox_e.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_e.Location = new System.Drawing.Point(71, 12);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(156, 40);
            this.textBox_e.TabIndex = 0;
            this.textBox_e.Text = "0,01";
            // 
            // textBox_x1
            // 
            this.textBox_x1.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_x1.Location = new System.Drawing.Point(71, 66);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(156, 40);
            this.textBox_x1.TabIndex = 1;
            this.textBox_x1.Text = "0,5";
            // 
            // textBox_x2
            // 
            this.textBox_x2.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_x2.Location = new System.Drawing.Point(71, 120);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(156, 40);
            this.textBox_x2.TabIndex = 2;
            this.textBox_x2.Text = "0,75";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Default_SC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.Location = new System.Drawing.Point(978, 12);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(138, 70);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Calc";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // button_e
            // 
            this.button_e.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_e.Location = new System.Drawing.Point(233, 12);
            this.button_e.Name = "button_e";
            this.button_e.Size = new System.Drawing.Size(113, 40);
            this.button_e.TabIndex = 4;
            this.button_e.Text = "Set";
            this.button_e.UseVisualStyleBackColor = true;
            this.button_e.Click += new System.EventHandler(this.button_e_Click);
            // 
            // button_x1
            // 
            this.button_x1.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_x1.Location = new System.Drawing.Point(233, 66);
            this.button_x1.Name = "button_x1";
            this.button_x1.Size = new System.Drawing.Size(113, 40);
            this.button_x1.TabIndex = 5;
            this.button_x1.Text = "Set";
            this.button_x1.UseVisualStyleBackColor = true;
            this.button_x1.Click += new System.EventHandler(this.button_x1_Click);
            // 
            // button_x2
            // 
            this.button_x2.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_x2.Location = new System.Drawing.Point(233, 120);
            this.button_x2.Name = "button_x2";
            this.button_x2.Size = new System.Drawing.Size(113, 40);
            this.button_x2.TabIndex = 6;
            this.button_x2.Text = "Set";
            this.button_x2.UseVisualStyleBackColor = true;
            this.button_x2.Click += new System.EventHandler(this.button_x2_Click);
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_e.Location = new System.Drawing.Point(25, 16);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(40, 34);
            this.label_e.TabIndex = 7;
            this.label_e.Text = "e:";
            // 
            // label_x1
            // 
            this.label_x1.AutoSize = true;
            this.label_x1.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x1.Location = new System.Drawing.Point(14, 70);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(52, 34);
            this.label_x1.TabIndex = 8;
            this.label_x1.Text = "x1:";
            // 
            // label_x2
            // 
            this.label_x2.AutoSize = true;
            this.label_x2.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x2.Location = new System.Drawing.Point(12, 124);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(59, 34);
            this.label_x2.TabIndex = 9;
            this.label_x2.Text = "x2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "x + ln (x) = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Default_SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "2x - cos (x) = 0";
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.plotView1.Location = new System.Drawing.Point(20, 231);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(545, 380);
            this.plotView1.TabIndex = 12;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView2
            // 
            this.plotView2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.plotView2.Location = new System.Drawing.Point(571, 231);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(545, 380);
            this.plotView2.TabIndex = 13;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Font = new System.Drawing.Font("Default_SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer1.Location = new System.Drawing.Point(16, 614);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(93, 24);
            this.labelAnswer1.TabIndex = 14;
            this.labelAnswer1.Text = "Answer:";
            this.labelAnswer1.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Font = new System.Drawing.Font("Default_SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer2.Location = new System.Drawing.Point(567, 614);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(93, 24);
            this.labelAnswer2.TabIndex = 15;
            this.labelAnswer2.Text = "Answer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 654);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_x2);
            this.Controls.Add(this.label_x1);
            this.Controls.Add(this.label_e);
            this.Controls.Add(this.button_x2);
            this.Controls.Add(this.button_x1);
            this.Controls.Add(this.button_e);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBox_x2);
            this.Controls.Add(this.textBox_x1);
            this.Controls.Add(this.textBox_e);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button button_e;
        private System.Windows.Forms.Button button_x1;
        private System.Windows.Forms.Button button_x2;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Label label_x1;
        private System.Windows.Forms.Label label_x2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelAnswer2;
    }
}

