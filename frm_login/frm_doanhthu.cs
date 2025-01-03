using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_DA;
using DAL_DA.Model1;

namespace frm_login
{
    public partial class frm_doanhthu : Form
    {
        string maDoanhThu;
        public frm_doanhthu()
        {
            InitializeComponent();
        }

        private readonly doanhthuService doanhThuServices = new doanhthuService();
        private void guna2HtmlLabel26_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            try
            {
                using (var db = new Model1())
                {
                    // Tắt tự động tạo cột nếu chưa làm
                    dta_doanhthu.AutoGenerateColumns = false;

                    // Truy vấn dữ liệu từ cơ sở dữ liệu
                    var data = (from dt in db.DoanhThus
                                join dv in db.DichVus on dt.MaDichVu equals dv.MaDichVu into dvJoin
                                from dv in dvJoin.DefaultIfEmpty() // Liên kết trái
                                select new
                                {
                                    dt.MaDoanhThu,
                                    MaDichVu = dv.MaDichVu ?? "Chưa có dịch vụ", // Kiểm tra null
                                    dt.NgayHoaDon,
                                    dt.Gia
                                }).ToList();

                    // Gán dữ liệu vào DataGridView
                    dta_doanhthu.DataSource = null; // Xóa dữ liệu cũ
                    dta_doanhthu.DataSource = data;

                    dta_doanhthu.Columns["MaDichVu"].DataPropertyName = "MaDichVu";
                    dta_doanhthu.Columns["NgayHoaDon"].DataPropertyName = "NgayHoaDon";
                    dta_doanhthu.Columns["Gia"].DataPropertyName = "Gia";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void frm_doanhthu_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_addDoanhthu frm_Add_Doanhthu = new frm_addDoanhthu(false);
            frm_Add_Doanhthu.ShowDialog();
            LoadData();
        }

        private void dta_doanhthu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dta_doanhthu.Rows.Count > 0 && e.RowIndex >= 0
                && maDoanhThu != dta_doanhthu.Rows[e.RowIndex].Cells["Code"].Value.ToString())
            {
                maDoanhThu = dta_doanhthu.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            }
            else if (dta_doanhthu.Rows.Count <= 0 || e.RowIndex < 0)
            {
                maDoanhThu = "";
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (maDoanhThu == "")
            {
                MessageBox.Show("Chưa chọn doanh thu", "Thông báo");
                return;
            }
            frm_addDoanhthu frm_Add_Doanhthu = new frm_addDoanhthu(true, maDoanhThu);
            frm_Add_Doanhthu.ShowDialog();
        }

        private void BTN_XOA_Click(object sender, EventArgs e)
        {
            if (maDoanhThu == "")
            {
                MessageBox.Show("Chưa chọn doanh thu", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                doanhThuServices.delete(maDoanhThu);
                MessageBox.Show("xóa doanh thu thành công", "Thông báo");
            }
        }
    }
}
