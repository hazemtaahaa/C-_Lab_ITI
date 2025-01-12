namespace PresentationLayer
{
    partial class PLForm
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
            resLable = new Label();
            txtNumDown = new NumericUpDown();
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
            btnUpdate = new Button();
            btnGetByName = new Button();
            cmbboxNames = new ComboBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)txtNumDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViwe).BeginInit();
            SuspendLayout();
            // 
            // resLable
            // 
            resLable.AutoSize = true;
            resLable.Location = new Point(663, 462);
            resLable.Name = "resLable";
            resLable.Size = new Size(0, 20);
            resLable.TabIndex = 54;
            // 
            // txtNumDown
            // 
            txtNumDown.Location = new Point(731, 157);
            txtNumDown.Margin = new Padding(3, 4, 3, 4);
            txtNumDown.Name = "txtNumDown";
            txtNumDown.Size = new Size(41, 27);
            txtNumDown.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(649, 164);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 47;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(641, 125);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 46;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(641, 79);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 45;
            label2.Text = "Last_Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(641, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 44;
            label1.Text = "First_Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(730, 119);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(196, 27);
            txtAddress.TabIndex = 43;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(729, 72);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(196, 27);
            txtLName.TabIndex = 42;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(728, 24);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(196, 27);
            txtFName.TabIndex = 41;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(651, 355);
            btnGetAll.Margin = new Padding(3, 4, 3, 4);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(289, 31);
            btnGetAll.TabIndex = 40;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnIInsert
            // 
            btnIInsert.Location = new Point(651, 309);
            btnIInsert.Margin = new Padding(3, 4, 3, 4);
            btnIInsert.Name = "btnIInsert";
            btnIInsert.Size = new Size(287, 29);
            btnIInsert.TabIndex = 39;
            btnIInsert.Text = "Insert";
            btnIInsert.UseVisualStyleBackColor = true;
            btnIInsert.Click += btnIInsert_Click;
            // 
            // grdViwe
            // 
            grdViwe.BackgroundColor = SystemColors.ControlDarkDark;
            grdViwe.BorderStyle = BorderStyle.Fixed3D;
            grdViwe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdViwe.Location = new Point(-4, 13);
            grdViwe.Margin = new Padding(3, 4, 3, 4);
            grdViwe.Name = "grdViwe";
            grdViwe.RowHeadersWidth = 51;
            grdViwe.Size = new Size(615, 504);
            grdViwe.TabIndex = 38;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(813, 248);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 32);
            btnUpdate.TabIndex = 57;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGetByName
            // 
            btnGetByName.Location = new Point(658, 248);
            btnGetByName.Margin = new Padding(3, 4, 3, 4);
            btnGetByName.Name = "btnGetByName";
            btnGetByName.Size = new Size(149, 32);
            btnGetByName.TabIndex = 59;
            btnGetByName.Text = "Get By Name";
            btnGetByName.UseVisualStyleBackColor = true;
            btnGetByName.Click += btnGetByName_Click;
            // 
            // cmbboxNames
            // 
            cmbboxNames.FormattingEnabled = true;
            cmbboxNames.Location = new Point(660, 212);
            cmbboxNames.Margin = new Padding(3, 4, 3, 4);
            cmbboxNames.Name = "cmbboxNames";
            cmbboxNames.Size = new Size(273, 28);
            cmbboxNames.TabIndex = 58;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(651, 394);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(289, 34);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // PLForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 582);
            Controls.Add(btnDelete);
            Controls.Add(btnGetByName);
            Controls.Add(cmbboxNames);
            Controls.Add(btnUpdate);
            Controls.Add(resLable);
            Controls.Add(txtNumDown);
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
            Name = "PLForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)txtNumDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViwe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label resLable;
        private NumericUpDown txtNumDown;
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
        private Button btnUpdate;
        private Button btnGetByName;
        private ComboBox cmbboxNames;
        private Button btnDelete;
    }
}
