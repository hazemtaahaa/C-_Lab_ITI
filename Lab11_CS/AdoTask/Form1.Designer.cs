namespace AdoTask
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
            grdViwe = new DataGridView();
            btnInsert = new Button();
            btnGetAll = new Button();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dptCmBox = new ComboBox();
            label5 = new Label();
            txtNumDown = new NumericUpDown();
            btnUpdate = new Button();
            cmbboxNames = new ComboBox();
            btnGetByName = new Button();
            resLable = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grdViwe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNumDown).BeginInit();
            SuspendLayout();
            // 
            // grdViwe
            // 
            grdViwe.BackgroundColor = SystemColors.ControlDarkDark;
            grdViwe.BorderStyle = BorderStyle.Fixed3D;
            grdViwe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdViwe.Location = new Point(12, 47);
            grdViwe.Margin = new Padding(3, 4, 3, 4);
            grdViwe.Name = "grdViwe";
            grdViwe.RowHeadersWidth = 51;
            grdViwe.Size = new Size(634, 504);
            grdViwe.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(665, 264);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(287, 29);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(667, 377);
            btnGetAll.Margin = new Padding(3, 4, 3, 4);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(289, 31);
            btnGetAll.TabIndex = 2;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(744, 47);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(196, 27);
            txtFName.TabIndex = 3;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(745, 95);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(196, 27);
            txtLName.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(746, 141);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(196, 27);
            txtAddress.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(657, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 7;
            label1.Text = "First_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(657, 102);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 8;
            label2.Text = "Last_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 148);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(656, 183);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 10;
            label4.Text = "Age";
            // 
            // dptCmBox
            // 
            dptCmBox.FormattingEnabled = true;
            dptCmBox.Location = new Point(747, 219);
            dptCmBox.Margin = new Padding(3, 4, 3, 4);
            dptCmBox.Name = "dptCmBox";
            dptCmBox.Size = new Size(209, 28);
            dptCmBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 222);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 12;
            label5.Text = "Department";
            // 
            // txtNumDown
            // 
            txtNumDown.Location = new Point(748, 180);
            txtNumDown.Margin = new Padding(3, 4, 3, 4);
            txtNumDown.Name = "txtNumDown";
            txtNumDown.Size = new Size(41, 27);
            txtNumDown.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(833, 337);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 32);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbboxNames
            // 
            cmbboxNames.FormattingEnabled = true;
            cmbboxNames.Location = new Point(667, 301);
            cmbboxNames.Margin = new Padding(3, 4, 3, 4);
            cmbboxNames.Name = "cmbboxNames";
            cmbboxNames.Size = new Size(286, 28);
            cmbboxNames.TabIndex = 15;
            // 
            // btnGetByName
            // 
            btnGetByName.Location = new Point(665, 337);
            btnGetByName.Margin = new Padding(3, 4, 3, 4);
            btnGetByName.Name = "btnGetByName";
            btnGetByName.Size = new Size(162, 32);
            btnGetByName.TabIndex = 16;
            btnGetByName.Text = "Get By Name";
            btnGetByName.UseVisualStyleBackColor = true;
            btnGetByName.Click += btnGetByName_Click;
            // 
            // resLable
            // 
            resLable.AutoSize = true;
            resLable.Location = new Point(674, 467);
            resLable.Name = "resLable";
            resLable.Size = new Size(0, 20);
            resLable.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(667, 416);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(289, 31);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 600);
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
            Controls.Add(btnInsert);
            Controls.Add(grdViwe);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grdViwe).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNumDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdViwe;
        private Button btnInsert;
        private Button btnGetAll;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox dptCmBox;
        private Label label5;
        private NumericUpDown txtNumDown;
        private Button btnUpdate;
        private ComboBox cmbboxNames;
        private Button btnGetByName;
        private Label resLable;
        private Button btnDelete;
    }
}
