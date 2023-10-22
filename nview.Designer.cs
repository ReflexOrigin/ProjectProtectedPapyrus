namespace ProjectProtectedPapyrus
{
    partial class nview
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
            this.NoteDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NoteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteDataGridView
            // 
            this.NoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.NoteDataGridView.Name = "NoteDataGridView";
            this.NoteDataGridView.Size = new System.Drawing.Size(801, 318);
            this.NoteDataGridView.TabIndex = 0;
            this.NoteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteDataGridView_CellContentClick);
            // 
            // nview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoteDataGridView);
            this.Name = "nview";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.nview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NoteDataGridView;
    }
}