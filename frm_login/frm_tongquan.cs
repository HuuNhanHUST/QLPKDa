using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace frm_login
{
    public partial class frm_tongquan : Form
    {
        private frm_saudangnhap parentForm;
        public frm_tongquan(frm_saudangnhap parent)
        {
            InitializeComponent();
            this.parentForm = parent;

        }

        private void guna2HtmlLabel22_Click(object sender, EventArgs e)
        {

        }


        public void container(Form frm)
        {
            // Kiểm tra nếu có form hiện tại trong container thì xóa đi
            if (parentForm.Controls.Count > 0)
            {
                parentForm.Controls.Clear();
            }

            // Đặt các thuộc tính cho form mới
            frm.TopLevel = false;                // Chắc chắn form là dạng con, không phải form chính
            frm.FormBorderStyle = FormBorderStyle.None;  // Không có đường viền
            frm.Dock = DockStyle.Fill;           // Đảm bảo form chiếm toàn bộ không gian của panel
            parentForm.Controls.Add(frm);      // Thêm form vào panel
            parentForm.Tag = frm;              // Lưu lại form này vào tag của panel (nếu cần)

            frm.Show();                          // Hiển thị form
        }
        private void btn_hen_Click(object sender, EventArgs e)
        {
            //chuyen sang form lichhen
        }

        private void btn_gap_Click(object sender, EventArgs e)
        {
            //chuyen sang form lichhen
        }

        private void btn_doanhso_Click(object sender, EventArgs e)
        {
            parentForm.container(new frm_doanhthu());
            parentForm.lbl_val.Text = "Doanh số";
            parentForm.pictureBox_val.Image = Properties.Resources.doanh_thu;
        }

        private void btn_benhnhann_Click(object sender, EventArgs e)
        {
            parentForm.container(new frm_danhsachbenhnhan());
            parentForm.lbl_val.Text = "Danh sách bệnh nhân";
            parentForm.pictureBox_val.Image = Properties.Resources.benhnhan;
        }

        private void btn_lichhenn_Click(object sender, EventArgs e)
        {
          parentForm.container(new frm_lichhen());
            parentForm.lbl_val.Text = "Lịch hẹn";
            parentForm.pictureBox_val.Image = Properties.Resources.lich_newpng;
        }

        private void frm_tongquan_Load(object sender, EventArgs e)
        {
        }
        public void UpdatePatientCount(int count)
        {
            if (lbl_thismonth != null)  // Kiểm tra xem lbl_thismonth có null không
            {
                Console.WriteLine("Cập nhật lbl_thismonth với giá trị: " + count);
                lbl_thismonth.Text = "0"+count.ToString();  // Gán số lượng bệnh nhân vào label
            }

        }

        private void lbl_thismonth_Click(object sender, EventArgs e)
        {
            
        }
    }
}
