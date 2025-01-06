namespace Ado_Disconnected_Mode
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
            btnDelete = new Button();
            resLable = new Label();
            btnGetByName = new Button();
            cmbboxNames = new ComboBox();
            btnUpdate = new Button();
            txtNumDown = new NumericUpDown();
            label5 = new Label();
            dptCmBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            btnGetAll = new Button();
            btnIInsert = new Button();
            grdViwe = new DataGridView();
            btnSync = new Button();
            ((System.ComponentModel.ISupportInitialize)txtNumDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViwe).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(253, 23);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // resLable
            // 
            resLable.AutoSize = true;
            resLable.Location = new Point(567, 351);
            resLable.Name = "resLable";
            resLable.Size = new Size(0, 15);
            resLable.TabIndex = 35;
            // 
            // btnGetByName
            // 
            btnGetByName.Location = new Point(559, 254);
            btnGetByName.Name = "btnGetByName";
            btnGetByName.Size = new Size(142, 24);
            btnGetByName.TabIndex = 34;
            btnGetByName.Text = "Get By Name";
            btnGetByName.UseVisualStyleBackColor = true;
            btnGetByName.Click += btnGetByName_Click;
            // 
            // cmbboxNames
            // 
            cmbboxNames.FormattingEnabled = true;
            cmbboxNames.Location = new Point(561, 227);
            cmbboxNames.Name = "cmbboxNames";
            cmbboxNames.Size = new Size(251, 23);
            cmbboxNames.TabIndex = 33;
            cmbboxNames.SelectedIndexChanged += cmbboxNames_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(706, 254);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 24);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNumDown
            // 
            txtNumDown.Location = new Point(631, 136);
            txtNumDown.Name = "txtNumDown";
            txtNumDown.Size = new Size(36, 23);
            txtNumDown.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(552, 167);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 30;
            label5.Text = "Department";
            // 
            // dptCmBox
            // 
            dptCmBox.FormattingEnabled = true;
            dptCmBox.Location = new Point(631, 165);
            dptCmBox.Name = "dptCmBox";
            dptCmBox.Size = new Size(183, 23);
            dptCmBox.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 138);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 28;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 112);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 27;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 26;
            label2.Text = "Last_Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(552, 44);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 25;
            label1.Text = "First_Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(630, 107);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(172, 23);
            txtAddress.TabIndex = 24;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(629, 72);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(172, 23);
            txtLName.TabIndex = 23;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(628, 36);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(172, 23);
            txtFName.TabIndex = 22;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(561, 284);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(253, 23);
            btnGetAll.TabIndex = 21;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnIInsert
            // 
            btnIInsert.Location = new Point(559, 199);
            btnIInsert.Name = "btnIInsert";
            btnIInsert.Size = new Size(251, 22);
            btnIInsert.TabIndex = 20;
            btnIInsert.Text = "Insert";
            btnIInsert.UseVisualStyleBackColor = true;
            btnIInsert.Click += btnIInsert_Click;
            // 
            // grdViwe
            // 
            grdViwe.BackgroundColor = SystemColors.ControlDarkDark;
            grdViwe.BorderStyle = BorderStyle.Fixed3D;
            grdViwe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdViwe.Location = new Point(8, 36);
            grdViwe.Name = "grdViwe";
            grdViwe.RowHeadersWidth = 51;
            grdViwe.Size = new Size(538, 378);
            grdViwe.TabIndex = 19;
            // 
            // btnSync
            // 
            btnSync.Location = new Point(551, 391);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(253, 23);
            btnSync.TabIndex = 37;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 450);
            Controls.Add(btnSync);
            Controls.Add(btnDelete);
            Controls.Add(resLable);
            Controls.Add(btnGetByName);
            Controls.Add(cmbboxNames);
            Controls.Add(btnUpdate);
            Controls.Add(txtNumDown);
            Controls.Add(label5);
            Controls.Add(dptCmBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(btnGetAll);
            Controls.Add(btnIInsert);
            Controls.Add(grdViwe);
            Name = "Form1";
            Text = "DisConnected Mode";
            ((System.ComponentModel.ISupportInitialize)txtNumDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViwe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Label resLable;
        private Button btnGetByName;
        private ComboBox cmbboxNames;
        private Button btnUpdate;
        private NumericUpDown txtNumDown;
        private Label label5;
        private ComboBox dptCmBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtLName;
        private TextBox txtFName;
        private Button btnGetAll;
        private Button btnIInsert;
        private DataGridView grdViwe;
        private Button btnSync;
    }
}
