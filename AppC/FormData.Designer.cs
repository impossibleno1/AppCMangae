namespace AppC
{
    partial class FormData
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
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydangky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview1
            // 
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.fullname,
            this.diachi,
            this.matram,
            this.ngaydangky,
            this.ngayhethan});
            this.datagridview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview1.Location = new System.Drawing.Point(0, 28);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowTemplate.Height = 24;
            this.datagridview1.Size = new System.Drawing.Size(647, 305);
            this.datagridview1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(647, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Họ và tên";
            this.fullname.Name = "fullname";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // matram
            // 
            this.matram.DataPropertyName = "matram";
            this.matram.HeaderText = "Mã Trạm";
            this.matram.Name = "matram";
            // 
            // ngaydangky
            // 
            this.ngaydangky.DataPropertyName = "ngaydangky";
            this.ngaydangky.HeaderText = "Ngày đăng ký";
            this.ngaydangky.Name = "ngaydangky";
            // 
            // ngayhethan
            // 
            this.ngayhethan.DataPropertyName = "ngayhethan";
            this.ngayhethan.HeaderText = "Ngày hết hạn";
            this.ngayhethan.Name = "ngayhethan";
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 333);
            this.Controls.Add(this.datagridview1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormData";
            this.Text = "FormData";
            this.Load += new System.EventHandler(this.FormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn matram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydangky;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhethan;
    }
}