namespace frm_login
{
    partial class frm_danhsachbenhnhan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_danhsachbenhnhan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_timbnhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_timbnhan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbx_sort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_taitep = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_soluongbenhnhan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.dta_dsbenhnhan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TenBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dta_dsbenhnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txt_timbnhan);
            this.guna2Panel1.Controls.Add(this.btn_timbnhan);
            this.guna2Panel1.Controls.Add(this.cbx_sort);
            this.guna2Panel1.Controls.Add(this.btn_taitep);
            this.guna2Panel1.Controls.Add(this.btn_sua);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.lbl_soluongbenhnhan);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1040, 68);
            this.guna2Panel1.TabIndex = 0;
            // 
            // txt_timbnhan
            // 
            this.txt_timbnhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timbnhan.DefaultText = "";
            this.txt_timbnhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_timbnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_timbnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_timbnhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_timbnhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_timbnhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_timbnhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_timbnhan.Location = new System.Drawing.Point(497, 18);
            this.txt_timbnhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_timbnhan.Name = "txt_timbnhan";
            this.txt_timbnhan.PasswordChar = '\0';
            this.txt_timbnhan.PlaceholderText = "";
            this.txt_timbnhan.SelectedText = "";
            this.txt_timbnhan.Size = new System.Drawing.Size(143, 31);
            this.txt_timbnhan.TabIndex = 9;
            this.txt_timbnhan.TextChanged += new System.EventHandler(this.txt_timbnhan_TextChanged);
            // 
            // btn_timbnhan
            // 
            this.btn_timbnhan.AutoSize = false;
            this.btn_timbnhan.BackColor = System.Drawing.Color.Transparent;
            this.btn_timbnhan.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timbnhan.Location = new System.Drawing.Point(438, 25);
            this.btn_timbnhan.Name = "btn_timbnhan";
            this.btn_timbnhan.Size = new System.Drawing.Size(70, 19);
            this.btn_timbnhan.TabIndex = 8;
            this.btn_timbnhan.Text = "Search";
            // 
            // cbx_sort
            // 
            this.cbx_sort.BackColor = System.Drawing.Color.Transparent;
            this.cbx_sort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_sort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_sort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_sort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_sort.ItemHeight = 30;
            this.cbx_sort.Items.AddRange(new object[] {
            "Tên",
            "Địa chỉ"});
            this.cbx_sort.Location = new System.Drawing.Point(261, 13);
            this.cbx_sort.Name = "cbx_sort";
            this.cbx_sort.Size = new System.Drawing.Size(154, 36);
            this.cbx_sort.TabIndex = 7;
            this.cbx_sort.SelectedIndexChanged += new System.EventHandler(this.cbx_sort_SelectedIndexChanged);
            // 
            // btn_taitep
            // 
            this.btn_taitep.BorderColor = System.Drawing.Color.Gray;
            this.btn_taitep.BorderThickness = 1;
            this.btn_taitep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_taitep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_taitep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_taitep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_taitep.FillColor = System.Drawing.Color.Transparent;
            this.btn_taitep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_taitep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_taitep.Image = ((System.Drawing.Image)(resources.GetObject("btn_taitep.Image")));
            this.btn_taitep.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_taitep.Location = new System.Drawing.Point(715, 12);
            this.btn_taitep.Name = "btn_taitep";
            this.btn_taitep.Size = new System.Drawing.Size(63, 37);
            this.btn_taitep.TabIndex = 5;
            this.btn_taitep.Click += new System.EventHandler(this.btn_taitep_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BorderColor = System.Drawing.Color.Gray;
            this.btn_sua.BorderThickness = 1;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.FillColor = System.Drawing.Color.Transparent;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sua.Location = new System.Drawing.Point(934, 12);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(63, 37);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(207, 25);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(70, 19);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Sort by";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(75, 25);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(180, 56);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Bệnh nhân";
            // 
            // lbl_soluongbenhnhan
            // 
            this.lbl_soluongbenhnhan.AutoSize = false;
            this.lbl_soluongbenhnhan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_soluongbenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluongbenhnhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_soluongbenhnhan.Location = new System.Drawing.Point(12, 12);
            this.lbl_soluongbenhnhan.Name = "lbl_soluongbenhnhan";
            this.lbl_soluongbenhnhan.Size = new System.Drawing.Size(68, 44);
            this.lbl_soluongbenhnhan.TabIndex = 0;
            this.lbl_soluongbenhnhan.Text = "76";
            // 
            // btn_them
            // 
            this.btn_them.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_them.BorderRadius = 5;
            this.btn_them.BorderThickness = 1;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.Transparent;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_them.Location = new System.Drawing.Point(808, 643);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(91, 31);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_xoa.BorderRadius = 5;
            this.btn_xoa.BorderThickness = 1;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_xoa.Location = new System.Drawing.Point(925, 643);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(93, 31);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dta_dsbenhnhan
            // 
            this.dta_dsbenhnhan.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dta_dsbenhnhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dta_dsbenhnhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dta_dsbenhnhan.ColumnHeadersHeight = 40;
            this.dta_dsbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dta_dsbenhnhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenhNhan,
            this.ColumnAvatar,
            this.TenBenhNhan,
            this.SoDienThoai,
            this.DiaChi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dta_dsbenhnhan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dta_dsbenhnhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dta_dsbenhnhan.Location = new System.Drawing.Point(12, 116);
            this.dta_dsbenhnhan.Name = "dta_dsbenhnhan";
            this.dta_dsbenhnhan.RowHeadersVisible = false;
            this.dta_dsbenhnhan.RowHeadersWidth = 51;
            this.dta_dsbenhnhan.RowTemplate.Height = 50;
            this.dta_dsbenhnhan.Size = new System.Drawing.Size(1006, 486);
            this.dta_dsbenhnhan.TabIndex = 3;
            this.dta_dsbenhnhan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dta_dsbenhnhan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dta_dsbenhnhan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dta_dsbenhnhan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dta_dsbenhnhan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dta_dsbenhnhan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dta_dsbenhnhan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dta_dsbenhnhan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dta_dsbenhnhan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dta_dsbenhnhan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dta_dsbenhnhan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dta_dsbenhnhan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dta_dsbenhnhan.ThemeStyle.HeaderStyle.Height = 40;
            this.dta_dsbenhnhan.ThemeStyle.ReadOnly = false;
            this.dta_dsbenhnhan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dta_dsbenhnhan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dta_dsbenhnhan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dta_dsbenhnhan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dta_dsbenhnhan.ThemeStyle.RowsStyle.Height = 50;
            this.dta_dsbenhnhan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dta_dsbenhnhan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dta_dsbenhnhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dta_dsbenhnhan_CellClick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaBenhNhan.DataPropertyName = "MaBenhNhan";
            this.MaBenhNhan.FillWeight = 42.78075F;
            this.MaBenhNhan.HeaderText = "ID";
            this.MaBenhNhan.MinimumWidth = 6;
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.Width = 40;
            // 
            // ColumnAvatar
            // 
            this.ColumnAvatar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnAvatar.DataPropertyName = "ColumnAvatar";
            this.ColumnAvatar.FillWeight = 171.123F;
            this.ColumnAvatar.HeaderText = "";
            this.ColumnAvatar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnAvatar.MinimumWidth = 6;
            this.ColumnAvatar.Name = "ColumnAvatar";
            this.ColumnAvatar.Width = 40;
            // 
            // TenBenhNhan
            // 
            this.TenBenhNhan.DataPropertyName = "TenBenhNhan";
            this.TenBenhNhan.FillWeight = 97.68271F;
            this.TenBenhNhan.HeaderText = "Basic info";
            this.TenBenhNhan.MinimumWidth = 6;
            this.TenBenhNhan.Name = "TenBenhNhan";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.FillWeight = 97.68271F;
            this.SoDienThoai.HeaderText = "Phone Number";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 97.68271F;
            this.DiaChi.HeaderText = "Address";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // frm_danhsachbenhnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1040, 701);
            this.Controls.Add(this.dta_dsbenhnhan);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_danhsachbenhnhan";
            this.Text = "frm_danhsachbenhnhan";
            this.Load += new System.EventHandler(this.frm_danhsachbenhnhan_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dta_dsbenhnhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_soluongbenhnhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_taitep;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2DataGridView dta_dsbenhnhan;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_sort;
        private Guna.UI2.WinForms.Guna2TextBox txt_timbnhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel btn_timbnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewImageColumn ColumnAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}