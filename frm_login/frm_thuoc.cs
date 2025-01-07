using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_DA;
using DAL_DA.Model1;

namespace frm_login
{
    public partial class frm_thuoc : Form
    {
        private thuocService thuocService;
        private int temp;
        public frm_thuoc()
        {
            InitializeComponent();
            thuocService = new thuocService();  
        }

        private void dta_thuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     

        private void frm_thuoc_Load(object sender, EventArgs e)
        {
            
            LoadData();
            temp = count();
            lbl_soluong.Text = temp.ToString();
        }
        public int count()
        {
            temp = dta_thuoc.Rows.Count;

            if (dta_thuoc.AllowUserToAddRows)
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
                using (var db = new Model1())
                {
                    dta_thuoc.AutoGenerateColumns = false;

                    var data = (from toath in db.ToaThuocs
                                join th in db.Thuoc_ on toath.MaThuoc equals th.MaThuoc
                                join bn in db.BenhNhans on toath.MaBenhNhan equals bn.MaBenhNhan
                                select new
                                {
                                    Matoa = toath.MaToa,
                                    Avatar = bn.Avatar,
                                    TenBenhNhan = bn.TenBenhNhan,
                                    toath.soluong,
                                    TenThuoc = th.TenThuoc,
                                    Ngaylap = toath.ngaylap,
                                    toath.LieuLuon
                                }).ToList();

                    if (data == null || data.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.");
                        return;
                    }

                    dta_thuoc.DataSource = data;

                    ProcessAvatarImages();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }


        private void ProcessAvatarImages()
        {
            // Xử lý hiển thị hình ảnh cho mỗi dòng
            foreach (DataGridViewRow row in dta_thuoc.Rows)
            {
                if (row.Cells[1] != null && row.Cells[1].Value != null)
                {
                    byte[] imageBytes = row.Cells[1].Value as byte[];

                    // Kiểm tra nếu byte[] hợp lệ
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                // Kiểm tra nếu byte[] có phải là hình ảnh hợp lệ
                                Image img = Image.FromStream(ms);
                                row.Cells[1].Value = img;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Nếu có lỗi khi chuyển đổi byte[] thành hình ảnh
                            MessageBox.Show($"Lỗi khi xử lý hình ảnh cho MaToa {row.Cells["MaToa"].Value}: {ex.Message}",
                                "Lỗi Hình Ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Gán hình ảnh mặc định nếu có lỗi
                            row.Cells[1].Value = Properties.Resources.THUOC; // Hình ảnh mặc định
                        }
                    }
                    else
                    {
                        row.Cells[1].Value = Properties.Resources.THUOC; // Hình ảnh mặc định
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_add_toathuoc frm = new frm_add_toathuoc(isEdit: false, reloadDataCallback: LoadData); // Truyền callback LoadData
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData(); // Tải lại dữ liệu sau khi đóng form
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (dta_thuoc.SelectedRows.Count > 0)
            {
                var selectedRow = dta_thuoc.SelectedRows[0];
                string maThuoc = selectedRow.Cells["Matoa"].Value.ToString(); // Lấy mã toa thuốc từ dòng đã chọn

                using (var db = new Model1())
                {
                    // Kiểm tra ràng buộc với các bảng liên quan
                    bool existsInLichHen = db.LichHens.Any(lh => lh.MaBenhNhan == maThuoc);
                    bool existsInToaThuoc = db.ToaThuocs.Any(tt => tt.MaBenhNhan == maThuoc);
                    bool existsInHoaDon = db.HoaDons.Any(hd => hd.MaBenhNhan == maThuoc);

                    if (existsInLichHen || existsInToaThuoc || existsInHoaDon)
                    {
                        MessageBox.Show(
                            "Không thể xóa bệnh nhân vì mã bệnh nhân này đang được sử dụng trong Lịch hẹn, Toa thuốc hoặc Hóa đơn.",
                            "Lỗi Xóa Dữ Liệu",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Hiển thị hộp thoại xác nhận
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa thuốc này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Thực hiện xóa thuốc
                    bool result = thuocService.Delete(maThuoc); // Thực hiện xóa thuốc qua service

                    if (result)
                    {
                        LoadData(); // Tải lại dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thuốc để xóa.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng thuốc để xóa.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dta_thuoc.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn
                var selectedRow = dta_thuoc.SelectedRows[0];

                // Lấy thông tin mã toa thuốc từ dòng được chọn
                string maToa = selectedRow.Cells["Matoa"].Value.ToString(); // Thay đổi "Matoa" thành tên cột thực tế chứa mã toa thuốc

                // Lấy thông tin toa thuốc từ service
                ToaThuoc toaThuoc = thuocService.getByMaToa(maToa);

                if (toaThuoc != null)
                {
                    // Mở form sửa thông tin toa thuốc với thông tin hiện tại
                    frm_add_toathuoc frm = new frm_add_toathuoc(isEdit: true, maThuoc: maToa, reloadDataCallback: LoadData);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        // Sau khi sửa xong và nhấn OK, tải lại dữ liệu
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy toa thuốc để sửa.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng toa thuốc để sửa.");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchByPatientName(string patientName)
        {
            using (var db = new Model1())
            {
                // Nếu textbox trống, tải lại tất cả dữ liệu
                if (string.IsNullOrEmpty(patientName))
                {
                    LoadData();  // Tải lại toàn bộ dữ liệu
                }
                else
                {
                    // Tìm kiếm theo tên bệnh nhân
                    var query = from toath in db.ToaThuocs
                                join th in db.Thuoc_ on toath.MaThuoc equals th.MaThuoc
                                join bn in db.BenhNhans on toath.MaBenhNhan equals bn.MaBenhNhan
                                where bn.TenBenhNhan.Contains(patientName) // Lọc theo tên bệnh nhân
                                select new
                                {
                                    Matoa = toath.MaToa,
                                    Avatar = bn.Avatar,
                                    TenBenhNhan = bn.TenBenhNhan,
                                    toath.soluong,
                                    TenThuoc = th.TenThuoc,
                                    Ngaylap = toath.ngaylap,
                                    toath.LieuLuon
                                };

                    // Hiển thị kết quả lên DataGridView
                    dta_thuoc.DataSource = query.ToList();
                }
            }
        }


        private void btn_tim_Click(object sender, EventArgs e)
        {
            string patientName = txt_tenthuoc.Text;
            SearchByPatientName(patientName); // Tìm kiếm theo tên bệnh nhân
        }

        private void cbx_sort_SelectedIndexChanged(object sender, EventArgs e)
        { // Lấy giá trị lựa chọn của combobox
            string sortOption = cbx_sort.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(sortOption)) return;

            using (var db = new Model1())
            {
                // Tạo câu truy vấn để lấy dữ liệu toa thuốc
                var query = from toath in db.ToaThuocs
                            join th in db.Thuoc_ on toath.MaThuoc equals th.MaThuoc
                            join bn in db.BenhNhans on toath.MaBenhNhan equals bn.MaBenhNhan
                            select new
                            {
                                Matoa = toath.MaToa,
                                Avatar = bn.Avatar,
                                TenBenhNhan = bn.TenBenhNhan,
                                toath.soluong,
                                TenThuoc = th.TenThuoc,
                                Ngaylap = toath.ngaylap,
                                toath.LieuLuon,
                                GiaThuoc = th.GiaThuoc, // Giá thuốc
                                TongGia = th.GiaThuoc * toath.soluong // Tính tổng giá (số lượng * giá thuốc)
                            };

                // Sắp xếp theo lựa chọn của người dùng
                if (sortOption == "Giá tăng dần")
                {
                    query = query.OrderBy(tt => tt.TongGia); // Sắp xếp tăng dần theo tổng giá
                }
                else if (sortOption == "Giá giảm dần")
                {
                    query = query.OrderByDescending(tt => tt.TongGia); // Sắp xếp giảm dần theo tổng giá
                }

                // Cập nhật lại DataGridView sau khi sắp xếp
                dta_thuoc.DataSource = query.ToList();
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
