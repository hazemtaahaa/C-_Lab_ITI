namespace TryWindowsForm
{
    partial class frmRegister
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
            label5 = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 99);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 151);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 207);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 265);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "User Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(201, 44);
            txtFName.Name = "txtFName";
            txtFName.PlaceholderText = "First Name";
            txtFName.Size = new Size(239, 27);
            txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(201, 99);
            txtLName.Name = "txtLName";
            txtLName.PlaceholderText = "Last Name";
            txtLName.Size = new Size(239, 27);
            txtLName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(201, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(239, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(201, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(239, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(201, 265);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(239, 27);
            txtUserName.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(353, 349);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnRegister;
    }
}