namespace frm_login
{
    partial class AddHoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHoadon));
            this.txt_mahd = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxBenhNhan = new System.Windows.Forms.ComboBox();
            this.cbxDichVu = new System.Windows.Forms.ComboBox();
            this.cbx_toathuoc = new System.Windows.Forms.ComboBox();
            this.dateNgaylap = new System.Windows.Forms.DateTimePicker();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.controlbox_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mahd
            // 
            this.txt_mahd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mahd.DefaultText = "";
            this.txt_mahd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mahd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mahd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mahd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mahd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mahd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mahd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mahd.Location = new System.Drawing.Point(245, 53);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.PasswordChar = '\0';
            this.txt_mahd.PlaceholderText = "";
            this.txt_mahd.SelectedText = "";
            this.txt_mahd.Size = new System.Drawing.Size(381, 28);
            this.txt_mahd.TabIndex = 0;
            // 
            // cbxBenhNhan
            // 
            this.cbxBenhNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBenhNhan.FormattingEnabled = true;
            this.cbxBenhNhan.Location = new System.Drawing.Point(245, 87);
            this.cbxBenhNhan.Name = "cbxBenhNhan";
            this.cbxBenhNhan.Size = new System.Drawing.Size(381, 24);
            this.cbxBenhNhan.TabIndex = 33;
            this.cbxBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cbx_khachhang_SelectedIndexChanged);
            // 
            // cbxDichVu
            // 
            this.cbxDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDichVu.FormattingEnabled = true;
            this.cbxDichVu.Location = new System.Drawing.Point(245, 130);
            this.cbxDichVu.Name = "cbxDichVu";
            this.cbxDichVu.Size = new System.Drawing.Size(381, 24);
            this.cbxDichVu.TabIndex = 35;
            // 
            // cbx_toathuoc
            // 
            this.cbx_toathuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_toathuoc.FormattingEnabled = true;
            this.cbx_toathuoc.Location = new System.Drawing.Point(245, 174);
            this.cbx_toathuoc.Name = "cbx_toathuoc";
            this.cbx_toathuoc.Size = new System.Drawing.Size(381, 24);
            this.cbx_toathuoc.TabIndex = 36;
            // 
            // dateNgaylap
            // 
            this.dateNgaylap.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaylap.Location = new System.Drawing.Point(245, 219);
            this.dateNgaylap.Name = "dateNgaylap";
            this.dateNgaylap.Size = new System.Drawing.Size(381, 22);
            this.dateNgaylap.TabIndex = 37;
            // 
            // btn_luu
            // 
            this.btn_luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(616, 268);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(111, 42);
            this.btn_luu.TabIndex = 38;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // controlbox_exit
            // 
            this.controlbox_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlbox_exit.FillColor = System.Drawing.Color.Transparent;
            this.controlbox_exit.IconColor = System.Drawing.Color.Gray;
            this.controlbox_exit.Location = new System.Drawing.Point(775, -1);
            this.controlbox_exit.Name = "controlbox_exit";
            this.controlbox_exit.Size = new System.Drawing.Size(45, 29);
            this.controlbox_exit.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã Hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã toa thuốc";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(664, 34);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(144, 103);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 45;
            this.guna2PictureBox1.TabStop = false;
            // 
            // AddHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 364);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlbox_exit);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.dateNgaylap);
            this.Controls.Add(this.cbx_toathuoc);
            this.Controls.Add(this.cbxDichVu);
            this.Controls.Add(this.cbxBenhNhan);
            this.Controls.Add(this.txt_mahd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddHoadon";
            this.Load += new System.EventHandler(this.AddHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_mahd;
        private System.Windows.Forms.ComboBox cbxBenhNhan;
        private System.Windows.Forms.ComboBox cbxDichVu;
        private System.Windows.Forms.ComboBox cbx_toathuoc;
        private System.Windows.Forms.DateTimePicker dateNgaylap;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private Guna.UI2.WinForms.Guna2ControlBox controlbox_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}