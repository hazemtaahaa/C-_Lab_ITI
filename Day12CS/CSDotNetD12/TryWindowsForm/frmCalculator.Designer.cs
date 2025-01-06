namespace TryWindowsForm
{
    partial class frmCalculator
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
            btnNumOne = new Button();
            btnNum2 = new Button();
            btnOperMin = new Button();
            btnOperPlus = new Button();
            btnEqulas = new Button();
            txtRes = new TextBox();
            SuspendLayout();
            // 
            // btnNumOne
            // 
            btnNumOne.Location = new Point(51, 137);
            btnNumOne.Name = "btnNumOne";
            btnNumOne.Size = new Size(94, 29);
            btnNumOne.TabIndex = 0;
            btnNumOne.Text = "1";
            btnNumOne.UseVisualStyleBackColor = true;
            btnNumOne.Click += btnNumbers_Click;
            // 
            // btnNum2
            // 
            btnNum2.Location = new Point(243, 137);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(94, 29);
            btnNum2.TabIndex = 1;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNumbers_Click;
            // 
            // btnOperMin
            // 
            btnOperMin.Location = new Point(243, 256);
            btnOperMin.Name = "btnOperMin";
            btnOperMin.Size = new Size(94, 29);
            btnOperMin.TabIndex = 2;
            btnOperMin.Text = "-";
            btnOperMin.UseVisualStyleBackColor = true;
            btnOperMin.Click += btnOper_Click;
            // 
            // btnOperPlus
            // 
            btnOperPlus.Location = new Point(51, 256);
            btnOperPlus.Name = "btnOperPlus";
            btnOperPlus.Size = new Size(94, 29);
            btnOperPlus.TabIndex = 3;
            btnOperPlus.Text = "+";
            btnOperPlus.UseVisualStyleBackColor = true;
            btnOperPlus.Click += btnOper_Click;
            // 
            // btnEqulas
            // 
            btnEqulas.Location = new Point(142, 331);
            btnEqulas.Name = "btnEqulas";
            btnEqulas.Size = new Size(94, 29);
            btnEqulas.TabIndex = 4;
            btnEqulas.Text = "=";
            btnEqulas.UseVisualStyleBackColor = true;
            btnEqulas.Click += btnEqulas_Click;
            // 
            // txtRes
            // 
            txtRes.Enabled = false;
            txtRes.Location = new Point(21, 12);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(316, 27);
            txtRes.TabIndex = 5;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
            Controls.Add(txtRes);
            Controls.Add(btnEqulas);
            Controls.Add(btnOperPlus);
            Controls.Add(btnOperMin);
            Controls.Add(btnNum2);
            Controls.Add(btnNumOne);
            Name = "frmCalculator";
            Text = "frmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNumOne;
        private Button btnNum2;
        private Button btnOperMin;
        private Button btnOperPlus;
        private Button btnEqulas;
        private TextBox txtRes;
    }
}