namespace Ado.NetConnectedMode
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
            gridAuthors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridAuthors).BeginInit();
            SuspendLayout();
            // 
            // gridAuthors
            // 
            gridAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAuthors.Location = new Point(0, 0);
            gridAuthors.Name = "gridAuthors";
            gridAuthors.RowHeadersWidth = 51;
            gridAuthors.Size = new Size(798, 447);
            gridAuthors.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridAuthors);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridAuthors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridAuthors;
    }
}
