namespace AppC
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.datagridview2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dt_dky = new DevExpress.XtraEditors.DateEdit();
            this.dt_hhan = new DevExpress.XtraEditors.DateEdit();
            this.et_name = new System.Windows.Forms.TextBox();
            this.et_ctpha = new System.Windows.Forms.TextBox();
            this.et_ctdong = new System.Windows.Forms.TextBox();
            this.et_tram = new System.Windows.Forms.TextBox();
            this.et_thon = new System.Windows.Forms.TextBox();
            this.et_mact = new System.Windows.Forms.TextBox();
            this.bt_create = new DevExpress.XtraEditors.SimpleButton();
            this.bt_edit = new DevExpress.XtraEditors.SimpleButton();
            this.bt_delete = new DevExpress.XtraEditors.SimpleButton();
            this.Home = new System.Windows.Forms.Button();
            this.bt_load = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.et_ghichu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_dky.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_dky.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hhan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tùy chỉnh danh sách khách hàng\r\n";
            // 
            // datagridview2
            // 
            this.datagridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview2.Location = new System.Drawing.Point(0, 315);
            this.datagridview2.Name = "datagridview2";
            this.datagridview2.RowTemplate.Height = 24;
            this.datagridview2.Size = new System.Drawing.Size(848, 135);
            this.datagridview2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thôn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã hiệu công tơ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hạn kiểm định";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày kiểm định";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Công tơ - Pha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Công tơ - Dòng";
            // 
            // dt_dky
            // 
            this.dt_dky.EditValue = null;
            this.dt_dky.Location = new System.Drawing.Point(552, 105);
            this.dt_dky.Name = "dt_dky";
            this.dt_dky.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_dky.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_dky.Size = new System.Drawing.Size(186, 22);
            this.dt_dky.TabIndex = 16;
            // 
            // dt_hhan
            // 
            this.dt_hhan.EditValue = null;
            this.dt_hhan.Location = new System.Drawing.Point(552, 138);
            this.dt_hhan.Name = "dt_hhan";
            this.dt_hhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hhan.Size = new System.Drawing.Size(186, 22);
            this.dt_hhan.TabIndex = 17;
            // 
            // et_name
            // 
            this.et_name.Location = new System.Drawing.Point(147, 69);
            this.et_name.Name = "et_name";
            this.et_name.Size = new System.Drawing.Size(186, 22);
            this.et_name.TabIndex = 20;
            // 
            // et_ctpha
            // 
            this.et_ctpha.Location = new System.Drawing.Point(147, 194);
            this.et_ctpha.Name = "et_ctpha";
            this.et_ctpha.Size = new System.Drawing.Size(186, 22);
            this.et_ctpha.TabIndex = 21;
            // 
            // et_ctdong
            // 
            this.et_ctdong.Location = new System.Drawing.Point(147, 167);
            this.et_ctdong.Name = "et_ctdong";
            this.et_ctdong.Size = new System.Drawing.Size(186, 22);
            this.et_ctdong.TabIndex = 22;
            // 
            // et_tram
            // 
            this.et_tram.Location = new System.Drawing.Point(147, 136);
            this.et_tram.Name = "et_tram";
            this.et_tram.Size = new System.Drawing.Size(186, 22);
            this.et_tram.TabIndex = 23;
            // 
            // et_thon
            // 
            this.et_thon.Location = new System.Drawing.Point(147, 103);
            this.et_thon.Name = "et_thon";
            this.et_thon.Size = new System.Drawing.Size(186, 22);
            this.et_thon.TabIndex = 24;
            // 
            // et_mact
            // 
            this.et_mact.Location = new System.Drawing.Point(552, 69);
            this.et_mact.Name = "et_mact";
            this.et_mact.Size = new System.Drawing.Size(186, 22);
            this.et_mact.TabIndex = 25;
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(287, 264);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(100, 27);
            this.bt_create.TabIndex = 26;
            this.bt_create.Text = "Create";
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(487, 264);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(100, 27);
            this.bt_edit.TabIndex = 27;
            this.bt_edit.Text = "Edit";
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(694, 264);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(100, 27);
            this.bt_delete.TabIndex = 28;
            this.bt_delete.Text = "Delete";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(761, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 29;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(95, 264);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(100, 27);
            this.bt_load.TabIndex = 30;
            this.bt_load.Text = "Load";
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ghi chú";
            // 
            // et_ghichu
            // 
            this.et_ghichu.Location = new System.Drawing.Point(552, 172);
            this.et_ghichu.Name = "et_ghichu";
            this.et_ghichu.Size = new System.Drawing.Size(186, 22);
            this.et_ghichu.TabIndex = 32;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.et_ghichu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.et_mact);
            this.Controls.Add(this.et_thon);
            this.Controls.Add(this.et_tram);
            this.Controls.Add(this.et_ctdong);
            this.Controls.Add(this.et_ctpha);
            this.Controls.Add(this.et_name);
            this.Controls.Add(this.dt_hhan);
            this.Controls.Add(this.dt_dky);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridview2);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_dky.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_dky.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hhan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.DateEdit dt_dky;
        private DevExpress.XtraEditors.DateEdit dt_hhan;
        private System.Windows.Forms.TextBox et_name;
        private System.Windows.Forms.TextBox et_ctpha;
        private System.Windows.Forms.TextBox et_ctdong;
        private System.Windows.Forms.TextBox et_tram;
        private System.Windows.Forms.TextBox et_thon;
        private System.Windows.Forms.TextBox et_mact;
        private DevExpress.XtraEditors.SimpleButton bt_create;
        private DevExpress.XtraEditors.SimpleButton bt_edit;
        private DevExpress.XtraEditors.SimpleButton bt_delete;
        private System.Windows.Forms.Button Home;
        private DevExpress.XtraEditors.SimpleButton bt_load;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox et_ghichu;
    }
}