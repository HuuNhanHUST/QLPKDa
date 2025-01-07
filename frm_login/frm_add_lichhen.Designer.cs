namespace frm_login
{
    partial class frm_add_lichhen
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
            this.cbxDichVu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxBenhNhan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNgayHenGN = new System.Windows.Forms.DateTimePicker();
            this.dateNgayHenTT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaLichHen = new Guna.UI2.WinForms.Guna2TextBox();
            this.controlbox_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.time_giohenTT = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbxDichVu
            // 
            this.cbxDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDichVu.FormattingEnabled = true;
            this.cbxDichVu.Location = new System.Drawing.Point(173, 215);
            this.cbxDichVu.Name = "cbxDichVu";
            this.cbxDichVu.Size = new System.Drawing.Size(591, 24);
            this.cbxDichVu.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(42, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Dịch vụ:";
            // 
            // cbxBenhNhan
            // 
            this.cbxBenhNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBenhNhan.FormattingEnabled = true;
            this.cbxBenhNhan.Location = new System.Drawing.Point(172, 182);
            this.cbxBenhNhan.Name = "cbxBenhNhan";
            this.cbxBenhNhan.Size = new System.Drawing.Size(591, 24);
            this.cbxBenhNhan.TabIndex = 32;
            this.cbxBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cbxBenhNhan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(42, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Bệnh nhân:";
            // 
            // dateNgayHenGN
            // 
            this.dateNgayHenGN.CustomFormat = "dd/MM/yyyy";
            this.dateNgayHenGN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayHenGN.Location = new System.Drawing.Point(173, 142);
            this.dateNgayHenGN.Name = "dateNgayHenGN";
            this.dateNgayHenGN.Size = new System.Drawing.Size(590, 22);
            this.dateNgayHenGN.TabIndex = 30;
            // 
            // dateNgayHenTT
            // 
            this.dateNgayHenTT.CustomFormat = "dd/MM/yyyy";
            this.dateNgayHenTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayHenTT.Location = new System.Drawing.Point(174, 102);
            this.dateNgayHenTT.Name = "dateNgayHenTT";
            this.dateNgayHenTT.Size = new System.Drawing.Size(291, 22);
            this.dateNgayHenTT.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngày hẹn GN:";
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(667, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 45);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(42, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ngày hẹn TT:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã lịch hẹn";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Location = new System.Drawing.Point(172, 255);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "Ghi chú";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(593, 23);
            this.txtGhiChu.TabIndex = 23;
            // 
            // txtMaLichHen
            // 
            this.txtMaLichHen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLichHen.DefaultText = "";
            this.txtMaLichHen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLichHen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLichHen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLichHen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLichHen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLichHen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLichHen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLichHen.Location = new System.Drawing.Point(173, 55);
            this.txtMaLichHen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLichHen.Name = "txtMaLichHen";
            this.txtMaLichHen.PasswordChar = '\0';
            this.txtMaLichHen.PlaceholderText = "Nhập mã lịch hẹn";
            this.txtMaLichHen.SelectedText = "";
            this.txtMaLichHen.Size = new System.Drawing.Size(592, 23);
            this.txtMaLichHen.TabIndex = 22;
            // 
            // controlbox_exit
            // 
            this.controlbox_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlbox_exit.FillColor = System.Drawing.Color.Transparent;
            this.controlbox_exit.IconColor = System.Drawing.Color.Gray;
            this.controlbox_exit.Location = new System.Drawing.Point(775, 0);
            this.controlbox_exit.Name = "controlbox_exit";
            this.controlbox_exit.Size = new System.Drawing.Size(45, 29);
            this.controlbox_exit.TabIndex = 35;
            // 
            // time_giohenTT
            // 
            this.time_giohenTT.CustomFormat = "HH:mm";
            this.time_giohenTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_giohenTT.Location = new System.Drawing.Point(474, 102);
            this.time_giohenTT.Name = "time_giohenTT";
            this.time_giohenTT.ShowUpDown = true;
            this.time_giohenTT.Size = new System.Drawing.Size(291, 22);
            this.time_giohenTT.TabIndex = 36;
            // 
            // frm_add_lichhen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 364);
            this.Controls.Add(this.time_giohenTT);
            this.Controls.Add(this.controlbox_exit);
            this.Controls.Add(this.cbxDichVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxBenhNhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateNgayHenGN);
            this.Controls.Add(this.dateNgayHenTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMaLichHen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_add_lichhen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_lichhen";
            this.Load += new System.EventHandler(this.frm_add_lichhen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDichVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBenhNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateNgayHenGN;
        private System.Windows.Forms.DateTimePicker dateNgayHenTT;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLichHen;
        private Guna.UI2.WinForms.Guna2ControlBox controlbox_exit;
        private System.Windows.Forms.DateTimePicker time_giohenTT;
    }
}