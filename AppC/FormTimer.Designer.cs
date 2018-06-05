namespace AppC
{
    partial class FormTimer
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
            this.datagridview3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview3)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview3
            // 
            this.datagridview3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview3.Location = new System.Drawing.Point(0, 98);
            this.datagridview3.Name = "datagridview3";
            this.datagridview3.RowTemplate.Height = 24;
            this.datagridview3.Size = new System.Drawing.Size(479, 155);
            this.datagridview3.TabIndex = 0;
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 253);
            this.Controls.Add(this.datagridview3);
            this.Name = "FormTimer";
            this.Text = "FormTimer";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview3;
    }
}