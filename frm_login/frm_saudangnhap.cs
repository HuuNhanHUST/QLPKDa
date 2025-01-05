using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static frm_login.Form1;

namespace frm_login
{
    public partial class frm_saudangnhap : Form
    {
        public frm_saudangnhap()
        {
            InitializeComponent();
            
        }

        private void pnl_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_saudangnhap_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            this.FormClosing += new FormClosingEventHandler(frm_saudangnhap_FormClosing);
            ApplicationExitManager.IsExitMessageShown = false;

        }


        private void btn_tongquan_Click(object sender, EventArgs e)
        {
            lbl_val.Text = "Dashboard overview";
            pictureBox_val.Image = Properties.Resources.dashicon;
            frm_tongquan frm = new frm_tongquan(this);  // Truyền "this" vào để tham chiếu đến frm_saudangnhap
            container(frm);

            frm_danhsachbenhnhan patientListForm = new frm_danhsachbenhnhan();

            patientListForm.Loaddata();  // Đảm bảo load lại dữ liệu trước khi lấy số lượng

            int patientCount = patientListForm.count();  // Lấy số lượng bệnh nhân từ count()
            frm.UpdatePatientCount(patientCount);

        }
        public void container(Form frm)
        {
            if (pnl_container.Controls.Count > 0)
            {
                pnl_container.Controls.Clear();
            }

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(frm);
            pnl_container.Tag = frm;
            frm.Show();
        }
        public void btn_benhnhan_Click(object sender, EventArgs e)
        {
            lbl_val.Text = "Danh sách bệnh nhân";
            pictureBox_val.Image = Properties.Resources.benhnhan;
            frm_danhsachbenhnhan frm = new frm_danhsachbenhnhan();
            frm.Loaddata();
            container(frm);
        }
        private void controlbox_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_saudangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ApplicationExitManager.IsExitMessageShown)  // Kiểm tra nếu thông báo chưa hiển thị
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ApplicationExitManager.IsExitMessageShown = true;  // Đánh dấu thông báo đã được hiển thị
                    Application.Exit();  // Thoát ứng dụng
                }
                else
                {
                    e.Cancel = true;  // Nếu người dùng chọn "No", hủy hành động đóng form
                }
            }
            else
            {
                // Nếu thông báo đã hiển thị từ một form khác, bỏ qua sự kiện này
                e.Cancel = false;
            }
        }

        private void btn_caidat_Click(object sender, EventArgs e)
        {
            lbl_val.Text = "Cài đặt";
            pictureBox_val.Image = Properties.Resources.setting;
            container(new frm_setting());
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {

            lbl_val.Text = "Doanh Thu";
            pictureBox_val.Image = Properties.Resources.doanh_thu;
            container(new frm_doanhthu());  

        }

        private void btn_lichhen_Click(object sender, EventArgs e)
        {
            lbl_val.Text = "Lịch hẹn";
            pictureBox_val.Image = Properties.Resources.lich_newpng;
            container(new frm_lichhen());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lbl_val.Text = "Toa thuốc";
            pictureBox_val.Image = Properties.Resources.THUOC;
            container(new frm_thuoc());
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            lbl_val.Text = "Hóa đơn";
            pictureBox_val.Image = Properties.Resources.hoadon;
            container(new frm_hoadon());
        }

        private void btn_dichvu_Click(object sender, EventArgs e)
        {
            lbl_val.Text = "dịch vụ";
            pictureBox_val.Image = Properties.Resources.dichvu;
            container(new frm_dichvu());
        }
    }
}
