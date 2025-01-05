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
using static System.Net.Mime.MediaTypeNames;
using BUS_DA;
using System.Data.Entity;
using DrawingImage = System.Drawing.Image;
using DAL_DA.Model1;
namespace frm_login
{
    public partial class frm_danhsachbenhnhan : Form
    {
        private readonly benhnhanService benhnhanServices = new benhnhanService();
        public int temp;
        public frm_danhsachbenhnhan()
        {
            InitializeComponent();
        }
        private void frm_danhsachbenhnhan_Load(object sender, EventArgs e)
        {
            Loaddata();
            temp = count();
            lbl_soluongbenhnhan.Text = $"{temp}";
        }
        public void  Loaddata()
        {
            
                using (var db = new Model1()) // Khởi tạo context cho Entity Framework
                {
                    // Tắt tự động tạo cột nếu chưa làm
                    dta_dsbenhnhan.AutoGenerateColumns = false;

                //// Truy vấn dữ liệu từ cơ sở dữ liệu
                //var data = (from bn in db.BenhNhans
                //            select new
                //            {
                //                bn.MaBenhNhan,        // Mã bệnh nhân
                //                bn.TenBenhNhan,       // Tên bệnh nhân
                //                bn.SoDienThoai,       // Số điện thoại
                //                bn.DiaChi,            // Địa chỉ
                //                Avatar = bn.Avatar  // Avatar, nếu null thì dùng ảnh mặc định
                //                                                                          // Các trường khác nếu cần
                //            }).ToList();
                var data = db.BenhNhans.ToList();
                dta_dsbenhnhan.DataSource = null;
                    dta_dsbenhnhan.DataSource = data;

                    // Đặt tên cột DataPropertyName cho từng cột tương ứng
                    dta_dsbenhnhan.Columns["MaBenhNhan"].DataPropertyName = "MaBenhNhan";
                dta_dsbenhnhan.Columns["ColumnAvatar"].DataPropertyName = "ColumnAvatar";
                dta_dsbenhnhan.Columns["TenBenhNhan"].DataPropertyName = "TenBenhNhan";
                    dta_dsbenhnhan.Columns["SoDienThoai"].DataPropertyName = "SoDienThoai";
                    //dta_dsbenhnhan.Columns["ColumnAvatar"].DataPropertyName = "ColumnAvatar";
                    dta_dsbenhnhan.Columns["DiaChi"].DataPropertyName = "DiaChi";
                    

                    // Xử lý hiển thị hình ảnh trong cột Avatar
                    ProcessAvatarImages();
                }
            
        }

        private void ProcessAvatarImages()
        {
            foreach (DataGridViewRow row in dta_dsbenhnhan.Rows)
            {
                var dataItem = row.DataBoundItem as BenhNhan;
                if (dataItem != null)
                {
                    var avatarData = dataItem.Avatar;
                    if (avatarData != null && avatarData.Length > 0)
                    {
                        row.Cells["ColumnAvatar"].Value = ConvertByteArrayToImage(avatarData);
                    }
                    else
                    {
                        row.Cells["ColumnAvatar"].Value = Properties.Resources.THUOC; 
                    }
                }
            }
        }

        private System.Drawing.Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }


        public int count()
        {
            temp = dta_dsbenhnhan.Rows.Count;

            if (dta_dsbenhnhan.AllowUserToAddRows)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_addbenhnhan frm = new frm_addbenhnhan(null); // Truyền null để thêm mới
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BenhNhan newBenhNhan = frm.benhNhan; // Hoặc frm.BenhNhan nếu sử dụng thuộc tính
                benhnhanServices.Add(newBenhNhan);
                Loaddata(); // Làm mới danh sách
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dta_dsbenhnhan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dta_dsbenhnhan.SelectedRows[0];
                var benhNhan = (BenhNhan)selectedRow.DataBoundItem;

                if (benhNhan != null)
                {
                    var confirmResult = MessageBox.Show(
                        $"Bạn có chắc chắn muốn xóa bệnh nhân: {benhNhan.TenBenhNhan}?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        if (benhnhanServices.Delete(benhNhan.MaBenhNhan))
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Loaddata(); // Làm mới danh sách
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa bệnh nhân. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dta_dsbenhnhan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dta_dsbenhnhan.SelectedRows[0];
                var benhNhan = (BenhNhan)selectedRow.DataBoundItem;
                selectedBenhnhan = benhNhan; // Cập nhật selectedBenhnhan

                if (selectedBenhnhan != null)
                {
                    frm_addbenhnhan frm = new frm_addbenhnhan(selectedBenhnhan);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        BenhNhan updatedBenhNhan = frm.benhNhan; // Lấy thông tin bệnh nhân đã sửa
                        if (benhnhanServices.Update(updatedBenhNhan)) // Gọi phương thức cập nhật trong service
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật thông tin. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private BenhNhan selectedBenhnhan;
        private void dta_dsbenhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dta_dsbenhnhan.RowCount)
                {
                    var selectedRow = dta_dsbenhnhan.Rows[e.RowIndex];
                    if (selectedRow.DataBoundItem is BenhNhan benhNhan)
                    {
                        selectedBenhnhan = benhNhan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void cbx_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cbx_sort.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedOption))
            {
                Loaddata(); // Nếu không chọn gì, tải lại danh sách mặc định
                return;
            }

            try
            {
                List<BenhNhan> sortedList = null;

                switch (selectedOption)
                {
                    case "Tên":
                        // Sắp xếp theo tên
                        sortedList = benhnhanServices.GetAll().OrderBy(bn => bn.TenBenhNhan).ToList();
                        break;

                    case "Địa chỉ":
                        // Sắp xếp theo địa chỉ
                        sortedList = benhnhanServices.GetAll().OrderBy(bn => bn.DiaChi).ToList();
                        break;

                    default:
                        Loaddata(); // Trường hợp không rõ ràng, tải lại danh sách mặc định
                        return;
                }

                // Hiển thị danh sách đã sắp xếp trong DataGridView
                dta_dsbenhnhan.DataSource = sortedList;
                ProcessAvatarImages();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi sắp xếp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_taitep_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog.Title = "Lưu danh sách bệnh nhân";
                    saveFileDialog.FileName = "DanhSachBenhNhan.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        bool result = benhnhanServices.SaveToCsv(filePath);

                        if (result)
                        {
                            MessageBox.Show("Lưu danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lưu danh sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi lưu danh sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string searchText = txt_timbnhan.Text.Trim().ToLower(); // Get the search text and convert it to lowercase

            if (string.IsNullOrEmpty(searchText))
            {
                // If the search text is empty, reload the full list of patients
                Loaddata();
            }
            else
            {
                using (var db = new Model1())
                {
                    // Filter the list of patients based on the search text (case-insensitive)
                    var data = db.BenhNhans
                                 .Where(bn => bn.TenBenhNhan.ToLower().Contains(searchText))
                                 .ToList();

                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân với tên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Update DataGridView with filtered data
                    dta_dsbenhnhan.DataSource = null;
                    dta_dsbenhnhan.DataSource = data;

                    // Update the DataGridView columns
                    dta_dsbenhnhan.Columns["MaBenhNhan"].DataPropertyName = "MaBenhNhan";
                    dta_dsbenhnhan.Columns["TenBenhNhan"].DataPropertyName = "TenBenhNhan";
                    dta_dsbenhnhan.Columns["SoDienThoai"].DataPropertyName = "SoDienThoai";
                    dta_dsbenhnhan.Columns["ColumnAvatar"].DataPropertyName = "ColumnAvatar";
                    dta_dsbenhnhan.Columns["DiaChi"].DataPropertyName = "DiaChi";

                    // Process Avatar images
                    ProcessAvatarImages();
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
