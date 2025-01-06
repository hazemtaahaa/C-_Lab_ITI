namespace Ado.NetConnectedMode
{
    partial class frmInsert
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtAddress = new TextBox();
            btnInsert = new Button();
            lblRes = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 46);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 109);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 163);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 215);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // txtId
            // 
            txtId.Location = new Point(218, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(316, 27);
            txtId.TabIndex = 4;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(218, 109);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(316, 27);
            txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(218, 163);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(316, 27);
            txtLName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(218, 215);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(316, 27);
            txtAddress.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(218, 318);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(472, 318);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 20);
            lblRes.TabIndex = 9;
            // 
            // frmInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRes);
            Controls.Add(btnInsert);
            Controls.Add(txtAddress);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInsert";
            Text = "frmInsert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtAddress;
        private Button btnInsert;
        private Label lblRes;
    }
}