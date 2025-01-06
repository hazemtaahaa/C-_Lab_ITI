namespace Ado.NetConnectedMode
{
    partial class frmSelectV2
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
            comboBoxAuth = new ComboBox();
            label1 = new Label();
            gridAuthors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridAuthors).BeginInit();
            SuspendLayout();
            // 
            // comboBoxAuth
            // 
            comboBoxAuth.FormattingEnabled = true;
            comboBoxAuth.Location = new Point(139, 44);
            comboBoxAuth.Name = "comboBoxAuth";
            comboBoxAuth.Size = new Size(275, 28);
            comboBoxAuth.TabIndex = 0;
            comboBoxAuth.SelectedIndexChanged += comboBoxAuth_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Authors";
            // 
            // gridAuthors
            // 
            gridAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAuthors.Location = new Point(12, 109);
            gridAuthors.Name = "gridAuthors";
            gridAuthors.RowHeadersWidth = 51;
            gridAuthors.Size = new Size(776, 313);
            gridAuthors.TabIndex = 2;
            // 
            // frmSelectV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridAuthors);
            Controls.Add(label1);
            Controls.Add(comboBoxAuth);
            Name = "frmSelectV2";
            Text = "frmSelectV2";
            ((System.ComponentModel.ISupportInitialize)gridAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAuth;
        private Label label1;
        private DataGridView gridAuthors;
    }
}