namespace frm_login
{
    partial class frm_add_toathuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_toathuoc));
            this.cbxThuoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxBenhNhan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.controlbox_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // cbxThuoc
            // 
            this.cbxThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThuoc.FormattingEnabled = true;
            this.cbxThuoc.Location = new System.Drawing.Point(176, 130);
            this.cbxThuoc.Name = "cbxThuoc";
            this.cbxThuoc.Size = new System.Drawing.Size(591, 24);
            this.cbxThuoc.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(43, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "Thuốc";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxBenhNhan
            // 
            this.cbxBenhNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBenhNhan.FormattingEnabled = true;
            this.cbxBenhNhan.Location = new System.Drawing.Point(174, 89);
            this.cbxBenhNhan.Name = "cbxBenhNhan";
            this.cbxBenhNhan.Size = new System.Drawing.Size(591, 24);
            this.cbxBenhNhan.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(43, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Bệnh nhân:";
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(669, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 45);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(45, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ghi chú:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mã toa thuốc";
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
            this.txtGhiChu.Location = new System.Drawing.Point(174, 197);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "Ghi chú";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(593, 23);
            this.txtGhiChu.TabIndex = 36;
            // 
            // txtMatoa
            // 
            this.txtMatoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatoa.DefaultText = "";
            this.txtMatoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatoa.Location = new System.Drawing.Point(172, 43);
            this.txtMatoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatoa.Name = "txtMatoa";
            this.txtMatoa.PasswordChar = '\0';
            this.txtMatoa.PlaceholderText = "";
            this.txtMatoa.SelectedText = "";
            this.txtMatoa.Size = new System.Drawing.Size(592, 23);
            this.txtMatoa.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ngày Lập :";
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayLap.Location = new System.Drawing.Point(172, 240);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(591, 22);
            this.dateNgayLap.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Số lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.DefaultText = "";
            this.txt_soluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_soluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluong.Location = new System.Drawing.Point(174, 161);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.PlaceholderText = "Số lượng";
            this.txt_soluong.SelectedText = "";
            this.txt_soluong.Size = new System.Drawing.Size(593, 23);
            this.txt_soluong.TabIndex = 51;
            // 
            // controlbox_exit
            // 
            this.controlbox_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlbox_exit.FillColor = System.Drawing.Color.Transparent;
            this.controlbox_exit.IconColor = System.Drawing.Color.Gray;
            this.controlbox_exit.Location = new System.Drawing.Point(775, 0);
            this.controlbox_exit.Name = "controlbox_exit";
            this.controlbox_exit.Size = new System.Drawing.Size(45, 29);
            this.controlbox_exit.TabIndex = 52;
            // 
            // frm_add_toathuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 364);
            this.Controls.Add(this.controlbox_exit);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateNgayLap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxThuoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxBenhNhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMatoa);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_add_toathuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_toathuoc";
            this.Load += new System.EventHandler(this.frm_add_toathuoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBenhNhan;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private Guna.UI2.WinForms.Guna2TextBox txtMatoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_soluong;
        private Guna.UI2.WinForms.Guna2ControlBox controlbox_exit;
    }
}