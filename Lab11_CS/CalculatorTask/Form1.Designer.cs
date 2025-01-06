namespace CalculatorTask
{
    partial class FrmCalc
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
            txtRes = new TextBox();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            BtnPlusOpr = new Button();
            btnMultiple = new Button();
            btnNum0 = new Button();
            btnMinus = new Button();
            btnDot = new Button();
            btnClear = new Button();
            btnDived = new Button();
            btnDelet = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtRes
            // 
            txtRes.BackColor = SystemColors.InactiveCaptionText;
            txtRes.BorderStyle = BorderStyle.None;
            txtRes.Cursor = Cursors.IBeam;
            txtRes.Enabled = false;
            txtRes.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            txtRes.ForeColor = SystemColors.ControlLightLight;
            txtRes.Location = new Point(28, 37);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(309, 33);
            txtRes.TabIndex = 0;
            // 
            // btnNum1
            // 
            btnNum1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum1.Location = new Point(28, 93);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(60, 60);
            btnNum1.TabIndex = 0;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNums;
            // 
            // btnNum2
            // 
            btnNum2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum2.Location = new Point(97, 93);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(60, 60);
            btnNum2.TabIndex = 1;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNums;
            // 
            // btnNum3
            // 
            btnNum3.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum3.Location = new Point(170, 93);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(60, 60);
            btnNum3.TabIndex = 2;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNums;
            // 
            // btnNum4
            // 
            btnNum4.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum4.Location = new Point(28, 155);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(60, 60);
            btnNum4.TabIndex = 5;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNums;
            // 
            // btnNum5
            // 
            btnNum5.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum5.Location = new Point(97, 155);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(60, 60);
            btnNum5.TabIndex = 4;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNums;
            // 
            // btnNum6
            // 
            btnNum6.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum6.Location = new Point(170, 155);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(60, 60);
            btnNum6.TabIndex = 3;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNums;
            // 
            // btnNum7
            // 
            btnNum7.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum7.Location = new Point(28, 221);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(60, 60);
            btnNum7.TabIndex = 8;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNums;
            // 
            // btnNum8
            // 
            btnNum8.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum8.Location = new Point(97, 221);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(60, 60);
            btnNum8.TabIndex = 7;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNums;
            // 
            // btnNum9
            // 
            btnNum9.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum9.Location = new Point(170, 221);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(60, 60);
            btnNum9.TabIndex = 6;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNums;
            // 
            // BtnPlusOpr
            // 
            BtnPlusOpr.BackColor = SystemColors.ControlText;
            BtnPlusOpr.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            BtnPlusOpr.ForeColor = SystemColors.ButtonHighlight;
            BtnPlusOpr.Location = new Point(246, 287);
            BtnPlusOpr.Name = "BtnPlusOpr";
            BtnPlusOpr.Size = new Size(91, 60);
            BtnPlusOpr.TabIndex = 9;
            BtnPlusOpr.Text = "+";
            BtnPlusOpr.UseVisualStyleBackColor = false;
            BtnPlusOpr.Click += btnOper_Click;
            // 
            // btnMultiple
            // 
            btnMultiple.BackColor = SystemColors.ControlText;
            btnMultiple.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnMultiple.ForeColor = SystemColors.ButtonHighlight;
            btnMultiple.Location = new Point(246, 155);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(91, 60);
            btnMultiple.TabIndex = 10;
            btnMultiple.Text = "x";
            btnMultiple.UseVisualStyleBackColor = false;
            btnMultiple.Click += btnOper_Click;
            // 
            // btnNum0
            // 
            btnNum0.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnNum0.Location = new Point(97, 287);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(60, 60);
            btnNum0.TabIndex = 11;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += btnNums;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ControlText;
            btnMinus.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnMinus.ForeColor = SystemColors.ButtonHighlight;
            btnMinus.Location = new Point(246, 221);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(91, 60);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnOper_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnDot.Location = new Point(28, 287);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 60);
            btnDot.TabIndex = 13;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnNums;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnClear.Location = new Point(170, 287);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 60);
            btnClear.TabIndex = 14;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDived
            // 
            btnDived.BackColor = SystemColors.ControlText;
            btnDived.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnDived.ForeColor = SystemColors.ButtonHighlight;
            btnDived.Location = new Point(246, 93);
            btnDived.Name = "btnDived";
            btnDived.Size = new Size(91, 60);
            btnDived.TabIndex = 15;
            btnDived.Text = "/";
            btnDived.UseVisualStyleBackColor = false;
            btnDived.Click += btnOper_Click;
            // 
            // btnDelet
            // 
            btnDelet.BackColor = SystemColors.ControlText;
            btnDelet.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnDelet.ForeColor = SystemColors.ButtonHighlight;
            btnDelet.Location = new Point(246, 353);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(91, 60);
            btnDelet.TabIndex = 16;
            btnDelet.Text = "D";
            btnDelet.UseVisualStyleBackColor = false;
            btnDelet.Click += btnDelet_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ControlText;
            btnEqual.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            btnEqual.ForeColor = SystemColors.ButtonHighlight;
            btnEqual.Location = new Point(28, 353);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(202, 60);
            btnEqual.TabIndex = 17;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqulas_Click;
            // 
            // FrmCalc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(349, 450);
            Controls.Add(btnEqual);
            Controls.Add(btnDelet);
            Controls.Add(btnDived);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(btnMinus);
            Controls.Add(btnNum0);
            Controls.Add(btnMultiple);
            Controls.Add(BtnPlusOpr);
            Controls.Add(btnNum7);
            Controls.Add(btnNum8);
            Controls.Add(btnNum9);
            Controls.Add(btnNum4);
            Controls.Add(btnNum5);
            Controls.Add(btnNum6);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(txtRes);
            Name = "FrmCalc";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRes;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button BtnPlusOpr;
        private Button btnMultiple;
        private Button btnNum0;
        private Button btnMinus;
        private Button btnDot;
        private Button btnClear;
        private Button btnDived;
        private Button btnDelet;
        private Button btnEqual;
    }
}
