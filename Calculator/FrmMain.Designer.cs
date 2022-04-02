namespace Calculator
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnDifference = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.PnlNumbers = new System.Windows.Forms.Panel();
            this.Btn00 = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PnlNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 43);
            this.panel1.TabIndex = 1;
            // 
            // TxtResult
            // 
            this.TxtResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtResult.Location = new System.Drawing.Point(0, 0);
            this.TxtResult.Margin = new System.Windows.Forms.Padding(1);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(310, 38);
            this.TxtResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnTotal);
            this.groupBox1.Controls.Add(this.BtnMult);
            this.groupBox1.Controls.Add(this.BtnDiv);
            this.groupBox1.Controls.Add(this.BtnDifference);
            this.groupBox1.Controls.Add(this.BtnPlus);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.PnlNumbers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(312, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BtnTotal
            // 
            this.BtnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTotal.Location = new System.Drawing.Point(245, 21);
            this.BtnTotal.Margin = new System.Windows.Forms.Padding(1);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(59, 173);
            this.BtnTotal.TabIndex = 20;
            this.BtnTotal.Text = "=";
            this.BtnTotal.UseVisualStyleBackColor = true;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Location = new System.Drawing.Point(186, 166);
            this.BtnMult.Margin = new System.Windows.Forms.Padding(1);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(54, 28);
            this.BtnMult.TabIndex = 19;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(186, 136);
            this.BtnDiv.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(54, 25);
            this.BtnDiv.TabIndex = 18;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnDifference
            // 
            this.BtnDifference.Location = new System.Drawing.Point(186, 101);
            this.BtnDifference.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDifference.Name = "BtnDifference";
            this.BtnDifference.Size = new System.Drawing.Size(54, 30);
            this.BtnDifference.TabIndex = 17;
            this.BtnDifference.Text = "-";
            this.BtnDifference.UseVisualStyleBackColor = true;
            this.BtnDifference.Click += new System.EventHandler(this.BtnDifference_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(186, 61);
            this.BtnPlus.Margin = new System.Windows.Forms.Padding(1);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(54, 35);
            this.BtnPlus.TabIndex = 16;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(186, 21);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(1);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(54, 35);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // PnlNumbers
            // 
            this.PnlNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNumbers.Controls.Add(this.Btn00);
            this.PnlNumbers.Controls.Add(this.BtnDot);
            this.PnlNumbers.Controls.Add(this.Btn4);
            this.PnlNumbers.Controls.Add(this.Btn5);
            this.PnlNumbers.Controls.Add(this.Btn6);
            this.PnlNumbers.Controls.Add(this.Btn7);
            this.PnlNumbers.Controls.Add(this.Btn8);
            this.PnlNumbers.Controls.Add(this.Btn0);
            this.PnlNumbers.Controls.Add(this.Btn9);
            this.PnlNumbers.Controls.Add(this.Btn3);
            this.PnlNumbers.Controls.Add(this.Btn2);
            this.PnlNumbers.Controls.Add(this.Btn1);
            this.PnlNumbers.Location = new System.Drawing.Point(2, 10);
            this.PnlNumbers.Margin = new System.Windows.Forms.Padding(1);
            this.PnlNumbers.Name = "PnlNumbers";
            this.PnlNumbers.Size = new System.Drawing.Size(179, 185);
            this.PnlNumbers.TabIndex = 12;
            // 
            // Btn00
            // 
            this.Btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn00.Location = new System.Drawing.Point(12, 140);
            this.Btn00.Margin = new System.Windows.Forms.Padding(1);
            this.Btn00.Name = "Btn00";
            this.Btn00.Size = new System.Drawing.Size(45, 35);
            this.Btn00.TabIndex = 23;
            this.Btn00.UseVisualStyleBackColor = true;
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDot.Location = new System.Drawing.Point(116, 140);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(45, 35);
            this.BtnDot.TabIndex = 22;
            this.BtnDot.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn4.Location = new System.Drawing.Point(12, 53);
            this.Btn4.Margin = new System.Windows.Forms.Padding(1);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(45, 35);
            this.Btn4.TabIndex = 21;
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn5.Location = new System.Drawing.Point(63, 53);
            this.Btn5.Margin = new System.Windows.Forms.Padding(1);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(45, 35);
            this.Btn5.TabIndex = 20;
            this.Btn5.UseVisualStyleBackColor = true;
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn6.Location = new System.Drawing.Point(116, 53);
            this.Btn6.Margin = new System.Windows.Forms.Padding(1);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(45, 35);
            this.Btn6.TabIndex = 19;
            this.Btn6.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn7.Location = new System.Drawing.Point(12, 95);
            this.Btn7.Margin = new System.Windows.Forms.Padding(1);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(45, 35);
            this.Btn7.TabIndex = 18;
            this.Btn7.UseVisualStyleBackColor = true;
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn8.Location = new System.Drawing.Point(63, 95);
            this.Btn8.Margin = new System.Windows.Forms.Padding(1);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(45, 35);
            this.Btn8.TabIndex = 17;
            this.Btn8.UseVisualStyleBackColor = true;
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn0.Location = new System.Drawing.Point(63, 140);
            this.Btn0.Margin = new System.Windows.Forms.Padding(1);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(45, 35);
            this.Btn0.TabIndex = 16;
            this.Btn0.UseVisualStyleBackColor = true;
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn9.Location = new System.Drawing.Point(116, 95);
            this.Btn9.Margin = new System.Windows.Forms.Padding(1);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(45, 35);
            this.Btn9.TabIndex = 15;
            this.Btn9.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn3.Location = new System.Drawing.Point(116, 11);
            this.Btn3.Margin = new System.Windows.Forms.Padding(1);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(45, 35);
            this.Btn3.TabIndex = 14;
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn2.Location = new System.Drawing.Point(63, 11);
            this.Btn2.Margin = new System.Windows.Forms.Padding(1);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(45, 35);
            this.Btn2.TabIndex = 13;
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn1.Location = new System.Drawing.Point(12, 11);
            this.Btn1.Margin = new System.Windows.Forms.Padding(1);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(45, 35);
            this.Btn1.TabIndex = 12;
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.PnlNumbers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PnlNumbers;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn00;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnDifference;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnTotal;
    }
}

