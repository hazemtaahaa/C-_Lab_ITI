namespace Ado.NetConnectedMode
{
    partial class frmUpdate
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
            comboBoxAuth = new ComboBox();
            lblRes = new Label();
            btnUpdate = new Button();
            txtAddress = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Authors";
            // 
            // comboBoxAuth
            // 
            comboBoxAuth.FormattingEnabled = true;
            comboBoxAuth.Location = new Point(130, 58);
            comboBoxAuth.Name = "comboBoxAuth";
            comboBoxAuth.Size = new Size(275, 28);
            comboBoxAuth.TabIndex = 2;
            comboBoxAuth.SelectedIndexChanged += comboBoxAuth_SelectedIndexChanged;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(520, 398);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 20);
            lblRes.TabIndex = 19;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(266, 398);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(266, 295);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(316, 27);
            txtAddress.TabIndex = 17;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(266, 243);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(316, 27);
            txtLName.TabIndex = 16;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(266, 189);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(316, 27);
            txtFName.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Location = new Point(266, 123);
            txtId.Name = "txtId";
            txtId.Size = new Size(316, 27);
            txtId.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 295);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 13;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 243);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 189);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 11;
            label2.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 126);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 10;
            label5.Text = "Id";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(529, 55);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(lblRes);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(comboBoxAuth);
            Name = "frmUpdate";
            Text = "frmUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxAuth;
        private Label lblRes;
        private Button btnUpdate;
        private TextBox txtAddress;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnDelete;
    }
}