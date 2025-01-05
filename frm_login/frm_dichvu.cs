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
    public partial class frm_dichvu : Form
    {
       private dichvuService dichVuService = new dichvuService();
        public frm_dichvu()
        {
            InitializeComponent();
        }
        private void frm_dichvu_Load(object sender, EventArgs e)
        {
            LoadData();
            temp = count(); 
            lbl_soluong.Text = temp.ToString();
        }
        private int temp;
        public int count()
        {
            temp = dta_dichvu.Rows.Count;

            if (dta_dichvu.AllowUserToAddRows)
            {
                temp--;
            }
            if (this.Owner is frm_saudangnhap parentForm)
            {
                var frmTongQuan = parentForm.Controls.OfType<frm_tongquan>().FirstOrDefault();
                if (frmTongQuan != null)
                {
                    frmTongQuan.UpdatePatientCount(temp);  // Cập nhật số lượng bệnh nhân vào frm_tongquan
                }
            }
            return temp;
        }


        private void LoadData()
        {
            try
            {

                // Tắt tính năng tự động tạo cột
                dta_dichvu.AutoGenerateColumns = false;
                // Lấy danh sách dịch vụ từ service
                using (var db = new Model1())
                {
                    var dichVus = (from dv in db.DichVus
                                   select new
                                   {
                                       MaDichVu = dv.MaDichVu,
                                       TenDichVu = dv.TenDichVu,
                                       GiaDV = dv.GiaDV
                                   }).ToList();

                    // Kiểm tra nếu có dữ liệu
                    if (dichVus.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView
                        dta_dichvu.DataSource = dichVus;

                        // Cập nhật các cột để tương ứng với dữ liệu
                        dta_dichvu.Columns["MaDichVu"].DataPropertyName = "MaDichVu";
                        dta_dichvu.Columns["TenDichVu"].DataPropertyName = "TenDichVu";
                        dta_dichvu.Columns["GiaDV"].DataPropertyName = "GiaDV";
                    }
                    else
                    {
                        MessageBox.Show("Không có dịch vụ để hiển thị.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dichVuService.IsAdding = true;  // Đặt cờ cho thêm

            // Mở form thêm dịch vụ
            frmAddDichvu frmAdd = new frmAddDichvu();
            frmAdd.ShowDialog();  // Mở form và chờ người dùng hoàn tất
            LoadData();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dta_dichvu.SelectedRows.Count > 0)
                {
                    // Lấy mã dịch vụ từ dòng đã chọn
                    var maDichVu = dta_dichvu.SelectedRows[0].Cells["MaDichVu"].Value.ToString();

                    // Kiểm tra dịch vụ có bị ràng buộc trong các bảng khác không
                    using (var db = new Model1())
                    {
                        // Kiểm tra xem dịch vụ có đang tồn tại trong bảng khác không (ví dụ hóa đơn, hay bảng liên quan)
                        var isUsed = db.HoaDons.Any(r => r.MaDichVu == maDichVu);  // Điều chỉnh bảng liên quan của bạn
                        var isUsed2 = db.LichHens.Any(r => r.MaDichVu == maDichVu);
                        if (isUsed || isUsed2)
                        {
                            MessageBox.Show("Dịch vụ này đang được sử dụng trong các bản ghi khác, không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Tìm dịch vụ theo mã
                        var dichVu = db.DichVus.FirstOrDefault(dv => dv.MaDichVu == maDichVu);
                        if (dichVu != null)
                        {
                            // Xóa dịch vụ
                            db.DichVus.Remove(dichVu);
                            db.SaveChanges();
                            MessageBox.Show("Dịch vụ đã được xóa thành công.");
                            LoadData();  // Tải lại dữ liệu sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Dịch vụ không tồn tại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dịch vụ: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dta_dichvu.SelectedRows.Count > 0)
            {
                dichVuService.IsAdding = false;  // Đặt cờ cho sửa

                // Lấy thông tin dịch vụ đã chọn
                var maDichVu = dta_dichvu.SelectedRows[0].Cells["MaDichVu"].Value.ToString();
                var tenDichVu = dta_dichvu.SelectedRows[0].Cells["TenDichVu"].Value.ToString();
                var giaDV = (decimal)dta_dichvu.SelectedRows[0].Cells["GiaDV"].Value;

                // Mở form sửa dịch vụ và truyền dữ liệu vào
                frmAddDichvu frmEdit = new frmAddDichvu(maDichVu, tenDichVu, giaDV);
                frmEdit.ShowDialog();  // Mở form sửa
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để sửa.");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
