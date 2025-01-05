using System.Windows.Forms;

namespace frm_login
{
    partial class frm_saudangnhap :Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_saudangnhap));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2_top = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_val = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlbox_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnl_container = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pictureBox_val = new System.Windows.Forms.PictureBox();
            this.btn_them = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_dichvu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_hoadon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_doanhthu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_thongtin = new Guna.UI2.WinForms.Guna2Button();
            this.btn_caidat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_benhnhan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_lichhen = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tongquan = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btn_dichvu);
            this.guna2Panel1.Controls.Add(this.btn_hoadon);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btn_doanhthu);
            this.guna2Panel1.Controls.Add(this.btn_thongtin);
            this.guna2Panel1.Controls.Add(this.btn_caidat);
            this.guna2Panel1.Controls.Add(this.btn_benhnhan);
            this.guna2Panel1.Controls.Add(this.btn_lichhen);
            this.guna2Panel1.Controls.Add(this.btn_tongquan);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(168, 754);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2_top
            // 
            this.guna2Panel2_top.Controls.Add(this.lbl_val);
            this.guna2Panel2_top.Controls.Add(this.pictureBox_val);
            this.guna2Panel2_top.Controls.Add(this.btn_them);
            this.guna2Panel2_top.Controls.Add(this.guna2TextBox1);
            this.guna2Panel2_top.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2_top.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2_top.Controls.Add(this.controlbox_exit);
            this.guna2Panel2_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2_top.Location = new System.Drawing.Point(168, 0);
            this.guna2Panel2_top.Name = "guna2Panel2_top";
            this.guna2Panel2_top.Size = new System.Drawing.Size(1040, 53);
            this.guna2Panel2_top.TabIndex = 1;
            // 
            // lbl_val
            // 
            this.lbl_val.BackColor = System.Drawing.Color.Transparent;
            this.lbl_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_val.Location = new System.Drawing.Point(64, 12);
            this.lbl_val.Name = "lbl_val";
            this.lbl_val.Size = new System.Drawing.Size(3, 2);
            this.lbl_val.TabIndex = 4;
            this.lbl_val.Text = null;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.Location = new System.Drawing.Point(896, 1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(947, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // controlbox_exit
            // 
            this.controlbox_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlbox_exit.FillColor = System.Drawing.Color.Transparent;
            this.controlbox_exit.IconColor = System.Drawing.Color.Gray;
            this.controlbox_exit.Location = new System.Drawing.Point(995, 1);
            this.controlbox_exit.Name = "controlbox_exit";
            this.controlbox_exit.Size = new System.Drawing.Size(45, 29);
            this.controlbox_exit.TabIndex = 0;
            this.controlbox_exit.Click += new System.EventHandler(this.controlbox_exit_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel2_top;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnl_container
            // 
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(168, 53);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1040, 701);
            this.pnl_container.TabIndex = 2;
            this.pnl_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_container_Paint);
            // 
            // pictureBox_val
            // 
            this.pictureBox_val.Location = new System.Drawing.Point(17, 4);
            this.pictureBox_val.Name = "pictureBox_val";
            this.pictureBox_val.Size = new System.Drawing.Size(41, 43);
            this.pictureBox_val.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_val.TabIndex = 0;
            this.pictureBox_val.TabStop = false;
            // 
            // btn_them
            // 
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(234)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(837, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_them.Size = new System.Drawing.Size(39, 34);
            this.btn_them.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 16;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBox1.Location = new System.Drawing.Point(631, 4);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 35);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // btn_dichvu
            // 
            this.btn_dichvu.BackColor = System.Drawing.Color.White;
            this.btn_dichvu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_dichvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dichvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dichvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dichvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dichvu.FillColor = System.Drawing.Color.Transparent;
            this.btn_dichvu.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dichvu.ForeColor = System.Drawing.Color.Black;
            this.btn_dichvu.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_dichvu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_dichvu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_dichvu.Image = ((System.Drawing.Image)(resources.GetObject("btn_dichvu.Image")));
            this.btn_dichvu.ImageOffset = new System.Drawing.Point(-7, 0);
            this.btn_dichvu.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_dichvu.Location = new System.Drawing.Point(12, 373);
            this.btn_dichvu.Name = "btn_dichvu";
            this.btn_dichvu.Size = new System.Drawing.Size(140, 43);
            this.btn_dichvu.TabIndex = 9;
            this.btn_dichvu.Text = "Dịch vụ";
            this.btn_dichvu.Click += new System.EventHandler(this.btn_dichvu_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.BackColor = System.Drawing.Color.White;
            this.btn_hoadon.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_hoadon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hoadon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hoadon.FillColor = System.Drawing.Color.Transparent;
            this.btn_hoadon.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.btn_hoadon.ForeColor = System.Drawing.Color.Black;
            this.btn_hoadon.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_hoadon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_hoadon.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_hoadon.Image = ((System.Drawing.Image)(resources.GetObject("btn_hoadon.Image")));
            this.btn_hoadon.ImageOffset = new System.Drawing.Point(-8, 0);
            this.btn_hoadon.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_hoadon.Location = new System.Drawing.Point(12, 324);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(140, 43);
            this.btn_hoadon.TabIndex = 8;
            this.btn_hoadon.Text = "Hóa đơn";
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-4, 0);
            this.guna2Button1.Location = new System.Drawing.Point(12, 275);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(140, 43);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "  Toa thuốc";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_doanhthu
            // 
            this.btn_doanhthu.BackColor = System.Drawing.Color.White;
            this.btn_doanhthu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_doanhthu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_doanhthu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_doanhthu.FillColor = System.Drawing.Color.Transparent;
            this.btn_doanhthu.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthu.ForeColor = System.Drawing.Color.Black;
            this.btn_doanhthu.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_doanhthu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_doanhthu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_doanhthu.Image = ((System.Drawing.Image)(resources.GetObject("btn_doanhthu.Image")));
            this.btn_doanhthu.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btn_doanhthu.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_doanhthu.Location = new System.Drawing.Point(12, 226);
            this.btn_doanhthu.Name = "btn_doanhthu";
            this.btn_doanhthu.Size = new System.Drawing.Size(140, 43);
            this.btn_doanhthu.TabIndex = 6;
            this.btn_doanhthu.Text = "Doanh thu";
            this.btn_doanhthu.Click += new System.EventHandler(this.btn_doanhthu_Click);
            // 
            // btn_thongtin
            // 
            this.btn_thongtin.BackColor = System.Drawing.Color.White;
            this.btn_thongtin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_thongtin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thongtin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thongtin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thongtin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thongtin.FillColor = System.Drawing.Color.Transparent;
            this.btn_thongtin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thongtin.ForeColor = System.Drawing.Color.Black;
            this.btn_thongtin.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_thongtin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_thongtin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_thongtin.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongtin.Image")));
            this.btn_thongtin.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btn_thongtin.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_thongtin.Location = new System.Drawing.Point(12, 688);
            this.btn_thongtin.Name = "btn_thongtin";
            this.btn_thongtin.Size = new System.Drawing.Size(140, 43);
            this.btn_thongtin.TabIndex = 5;
            this.btn_thongtin.Text = "Dr.Liems";
            // 
            // btn_caidat
            // 
            this.btn_caidat.BackColor = System.Drawing.Color.White;
            this.btn_caidat.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_caidat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_caidat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_caidat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_caidat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_caidat.FillColor = System.Drawing.Color.Transparent;
            this.btn_caidat.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caidat.ForeColor = System.Drawing.Color.Black;
            this.btn_caidat.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_caidat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_caidat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_caidat.Image = ((System.Drawing.Image)(resources.GetObject("btn_caidat.Image")));
            this.btn_caidat.ImageOffset = new System.Drawing.Point(-9, 0);
            this.btn_caidat.Location = new System.Drawing.Point(12, 463);
            this.btn_caidat.Name = "btn_caidat";
            this.btn_caidat.Size = new System.Drawing.Size(140, 43);
            this.btn_caidat.TabIndex = 4;
            this.btn_caidat.Text = "Cài đặt";
            this.btn_caidat.Click += new System.EventHandler(this.btn_caidat_Click);
            // 
            // btn_benhnhan
            // 
            this.btn_benhnhan.BackColor = System.Drawing.Color.White;
            this.btn_benhnhan.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_benhnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_benhnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_benhnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_benhnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_benhnhan.FillColor = System.Drawing.Color.Transparent;
            this.btn_benhnhan.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_benhnhan.ForeColor = System.Drawing.Color.Black;
            this.btn_benhnhan.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_benhnhan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_benhnhan.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_benhnhan.Image = ((System.Drawing.Image)(resources.GetObject("btn_benhnhan.Image")));
            this.btn_benhnhan.ImageOffset = new System.Drawing.Point(-8, 0);
            this.btn_benhnhan.Location = new System.Drawing.Point(22, 177);
            this.btn_benhnhan.Name = "btn_benhnhan";
            this.btn_benhnhan.Size = new System.Drawing.Size(140, 43);
            this.btn_benhnhan.TabIndex = 3;
            this.btn_benhnhan.Text = "Bệnh nhân";
            this.btn_benhnhan.Click += new System.EventHandler(this.btn_benhnhan_Click);
            // 
            // btn_lichhen
            // 
            this.btn_lichhen.BackColor = System.Drawing.Color.White;
            this.btn_lichhen.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_lichhen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_lichhen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_lichhen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_lichhen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_lichhen.FillColor = System.Drawing.Color.Transparent;
            this.btn_lichhen.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichhen.ForeColor = System.Drawing.Color.Black;
            this.btn_lichhen.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_lichhen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_lichhen.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_lichhen.Image = ((System.Drawing.Image)(resources.GetObject("btn_lichhen.Image")));
            this.btn_lichhen.ImageOffset = new System.Drawing.Point(-7, 0);
            this.btn_lichhen.Location = new System.Drawing.Point(12, 128);
            this.btn_lichhen.Name = "btn_lichhen";
            this.btn_lichhen.Size = new System.Drawing.Size(140, 43);
            this.btn_lichhen.TabIndex = 2;
            this.btn_lichhen.Text = "Lịch hẹn";
            this.btn_lichhen.Click += new System.EventHandler(this.btn_lichhen_Click);
            // 
            // btn_tongquan
            // 
            this.btn_tongquan.BackColor = System.Drawing.Color.White;
            this.btn_tongquan.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_tongquan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tongquan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tongquan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tongquan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tongquan.FillColor = System.Drawing.Color.Transparent;
            this.btn_tongquan.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tongquan.ForeColor = System.Drawing.Color.Black;
            this.btn_tongquan.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_tongquan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_tongquan.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tongquan.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_tongquan.Image = ((System.Drawing.Image)(resources.GetObject("btn_tongquan.Image")));
            this.btn_tongquan.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btn_tongquan.Location = new System.Drawing.Point(12, 79);
            this.btn_tongquan.Name = "btn_tongquan";
            this.btn_tongquan.Size = new System.Drawing.Size(140, 43);
            this.btn_tongquan.TabIndex = 1;
            this.btn_tongquan.Text = "Tổng quan";
            this.btn_tongquan.Click += new System.EventHandler(this.btn_tongquan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_saudangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 754);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.guna2Panel2_top);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_saudangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dashboard";
            this.Load += new System.EventHandler(this.frm_saudangnhap_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2_top.ResumeLayout(false);
            this.guna2Panel2_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2_top;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox controlbox_exit;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2CircleButton btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_tongquan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_caidat;
        private Guna.UI2.WinForms.Guna2Button btn_benhnhan;
        private Guna.UI2.WinForms.Guna2Button btn_lichhen;
        private Guna.UI2.WinForms.Guna2Button btn_thongtin;
        private Guna.UI2.WinForms.Guna2Button btn_doanhthu;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel pnl_container;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbl_val;
        public PictureBox pictureBox_val;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btn_dichvu;
        private Guna.UI2.WinForms.Guna2Button btn_hoadon;
    }
}