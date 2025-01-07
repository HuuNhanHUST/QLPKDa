using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;  


namespace frm_login
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1; // Mã cho sự kiện nhấn chuột trái
        private const int HTCAPTION = 0x2;         // Khu vực thanh tiêu đề (caption)

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Kiểm tra nếu nhấn chuột trái
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            this.KeyPreview = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            this.MouseDown += Form1_MouseDown;
            this.KeyDown += Form1_KeyDown;
        }
        public static class ApplicationExitManager
        {
            public static bool IsExitMessageShown = false;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox
            string username = txt_user.Text;
            string password = txt_password.Text;

            // Xác thực tài khoản
            bool isAuthenticated = AccountManager.AuthenticateUser(username, password, @"D:\VISUAL STUDIO\QLPKDa\account.txt");

            if (isAuthenticated)
            {
                // Nếu tài khoản và mật khẩu đúng, hiển thị form loading
                loading load = new loading();
                load.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.");
            }
        }
        
         private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu nhấn phím Esc và thông báo thoát chưa được hiển thị
            if (e.KeyCode == Keys.Escape && !ApplicationExitManager.IsExitMessageShown)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ApplicationExitManager.IsExitMessageShown = true;  // Đánh dấu thông báo đã hiển thị
                    Application.Exit();  // Thoát ứng dụng
                }
                else
                {
                    // Không làm gì nếu chọn "No", tránh việc thông báo hiện lại
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Kiểm tra nếu thông báo thoát chưa được hiển thị
            if (!ApplicationExitManager.IsExitMessageShown)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ApplicationExitManager.IsExitMessageShown = true;  // Đánh dấu thông báo đã hiển thị
                    Application.Exit();  // Thoát ứng dụng
                }
                else
                {
                    ApplicationExitManager.IsExitMessageShown = true;
                    e.Cancel = true;  // Hủy hành động đóng form nếu chọn No
                }
            }
        }

    }
}
