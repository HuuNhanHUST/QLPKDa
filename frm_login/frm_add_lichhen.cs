using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_DA;
using DAL_DA.Model1;

namespace frm_login
{
    public partial class frm_add_lichhen : Form
    {
        private Action reloadDataCallback;

        public frm_add_lichhen(bool isEdit, string maLichHen = "", Action reloadDataCallback = null)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.maLichHen = maLichHen;
            this.reloadDataCallback = reloadDataCallback;
        }
        bool isEdit;
        string maLichHen;
        lichhenService lichhenService = new lichhenService();
        benhnhanService benhnhanService = new benhnhanService();
        dichvuService dichvuService = new dichvuService();

        public frm_add_lichhen(bool isEdit, string maLichHen = "")
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.maLichHen = maLichHen;
        }
        public frm_add_lichhen()
        {
            InitializeComponent();
        }

        private void frm_add_lichhen_Load(object sender, EventArgs e)
        {
            dateNgayHenGN.Enabled = false;
            // Lấy danh sách bệnh nhân từ dịch vụ và gán vào ComboBox
            var benhNhanList = benhnhanService.GetAll();
            if (benhNhanList != null)
            {
                cbxBenhNhan.DataSource = benhNhanList;
                cbxBenhNhan.ValueMember = "MaBenhNhan";
                cbxBenhNhan.DisplayMember = "TenBenhNhan";
            }
            else
            {
                MessageBox.Show("Không có bệnh nhân nào trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Lấy danh sách dịch vụ từ dịch vụ và gán vào ComboBox
            var dichVuList = dichvuService.GetAll();
            if (dichVuList != null && dichVuList.Any())
            {
                cbxDichVu.DataSource = dichVuList;
                cbxDichVu.ValueMember = "MaDichVu";
                cbxDichVu.DisplayMember = "TenDichVu";
            }
            else
            {
                MessageBox.Show("Không có dịch vụ nào trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Kiểm tra nếu là chế độ Sửa
            if (isEdit)
            {
                // Cập nhật tiêu đề form và chỉ cho phép sửa mã lịch hẹn
                this.Text = "Cập nhật lịch hẹn";
                txtMaLichHen.Enabled = false;
                txtMaLichHen.Text = maLichHen;

                // Lấy dữ liệu lịch hẹn từ dịch vụ và điền vào các textbox, combobox
                var lichHen = lichhenService.getByMaLichHen(maLichHen);
                if (lichHen != null)
                {
                    dateNgayHenTT.Value = lichHen.NgayHenTT ?? DateTime.Now;

                    // Nếu NgayHenGN là null, không cho phép chỉnh sửa và không gán giá trị
                    if (lichHen.NgayHenGN.HasValue)
                    {
                        dateNgayHenGN.Value = lichHen.NgayHenGN.Value;
                    }
                    else
                    {
                        dateNgayHenGN.Enabled = false; // Vô hiệu hóa dateNgayHenGN nếu NgayHenGN là null
                    }

                    cbxBenhNhan.SelectedValue = lichHen.MaBenhNhan;
                    cbxDichVu.SelectedValue = lichHen.MaDichVu;
                    txtGhiChu.Text = lichHen.Ghichu;
                }
                cbxBenhNhan.Enabled = false;
                dateNgayHenTT.Focus();  // Đặt tiêu điểm vào ngày giờ hẹn
            }
            else
            {
                // Chế độ Thêm mới
                this.Text = "Thêm lịch hẹn";
                txtMaLichHen.Enabled = true;  // Cho phép nhập mã lịch hẹn
                txtMaLichHen.Clear();  // Xóa nội dung mã lịch hẹn
                dateNgayHenTT.Value = DateTime.Now;  // Đặt ngày hẹn
                dateNgayHenGN.Value = DateTime.Now;  // Đặt ngày giờ giao nhận
                cbxBenhNhan.SelectedIndex = -1;  // Đặt lại chỉ mục ComboBox BenhNhan (nếu cần)
                cbxDichVu.SelectedIndex = -1;  // Đặt lại chỉ mục ComboBox DichVu (nếu cần)
                txtGhiChu.Clear();  // Xóa ghi chú
                txtMaLichHen.Focus();  // Đặt tiêu điểm vào mã lịch hẹn

                // Đặt lại giá trị ComboBox (nếu cần)
                cbxBenhNhan.ResetText();
                cbxDichVu.ResetText();
            }


        }

        private void cbxBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBenhNhan.SelectedValue == null)
                return;  // Nếu không có giá trị chọn, dừng xử lý

            string maBenhNhan = cbxBenhNhan.SelectedValue.ToString(); // Lấy mã bệnh nhân từ ComboBox

            using (var db = new Model1())
            {
                var existingLichHen = db.LichHens
                    .Where(lh => lh.MaBenhNhan == maBenhNhan && lh.NgayHenTT < DateTime.Now)
                    .OrderBy(lh => lh.NgayHenTT)
                    .FirstOrDefault();

                if (existingLichHen != null)
                {
                    // Nếu có lịch hẹn gần nhất, gán ngày giờ giao nhận
                    dateNgayHenGN.Value = existingLichHen.NgayHenTT ?? DateTime.Now;
                    dateNgayHenGN.Checked = true; // Đảm bảo DateTimePicker được chọn
                }
                else
                {
                    // Nếu không có lịch hẹn gần nhất, bỏ chọn DateTimePicker
                    dateNgayHenGN.Checked = false;  // Đặt thành không chọn (null)
                }
            }
        }

        public bool CheckAppointmentConflict(DateTime selectedDateTime)
        {
            using (var db = new Model1())  // Sử dụng DbContext
            {
                // Fetch the appointments for the same date
                var conflictingAppointments = db.LichHens
                    .Where(lh => lh.NgayHenTT.HasValue &&  // Kiểm tra NgayHenTT có giá trị không
                                 DbFunctions.TruncateTime(lh.NgayHenTT.Value) == DbFunctions.TruncateTime(selectedDateTime)) // So sánh ngày mà không quan tâm đến giờ
                    .ToList();  // Fetch the data from the database first

                // Now calculate the difference in minutes on the client side
                foreach (var conflictingAppointment in conflictingAppointments)
                {
                    var timeDifference = (conflictingAppointment.NgayHenTT.Value - selectedDateTime).TotalMinutes;
                    if (Math.Abs(timeDifference) < 60)  // Check if the difference is less than 60 minutes
                    {
                        return true;  // Conflict found
                    }
                }

                return false;  // No conflict
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy phần giờ từ time_giohenTT và kết hợp với phần ngày từ dateNgayHenTT
            DateTime selectedNgayHenTT = dateNgayHenTT.Value.Date.Add(time_giohenTT.Value.TimeOfDay); // Kết hợp ngày và giờ

            // Kiểm tra NgayHenGN
            DateTime? selectedNgayHenGN = null;
            if (dateNgayHenGN.Checked)
            {
                selectedNgayHenGN = dateNgayHenGN.Value.Date.Add(dateNgayHenGN.Value.TimeOfDay);
            }

            // Kiểm tra NgayHenGN
            if (selectedNgayHenGN.HasValue && selectedNgayHenGN.Value > selectedNgayHenTT)
            {
                MessageBox.Show("Ngày Hẹn Gần nhất (NgayHenGN) không thể nhỏ hơn Ngày giờ hẹn (NgayHenTT).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xung đột lịch hẹn
            if (CheckAppointmentConflict(selectedNgayHenTT))
            {
                MessageBox.Show("Đã có hẹn với bệnh nhân khác rồi ! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra chế độ sửa hay thêm mới
            if (isEdit)
            {
                var lichHen = lichhenService.getByMaLichHen(maLichHen);
                if (lichHen == null)
                {
                    MessageBox.Show("Lịch hẹn không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật lịch hẹn
                lichHen.NgayHenTT = selectedNgayHenTT;
                lichHen.NgayHenGN = selectedNgayHenGN;  // Đây sẽ là null nếu Checked là false
                lichHen.MaBenhNhan = cbxBenhNhan.SelectedValue.ToString();
                lichHen.MaDichVu = cbxDichVu.SelectedValue.ToString();
                lichHen.Ghichu = txtGhiChu.Text;

                lichhenService.Update(lichHen);
                MessageBox.Show("Lịch hẹn đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var lichHen = new LichHen
                {
                    MaLichHen = txtMaLichHen.Text,
                    NgayHenTT = selectedNgayHenTT,
                    NgayHenGN = selectedNgayHenGN,  // Đây sẽ là null nếu Checked là false
                    MaBenhNhan = cbxBenhNhan.SelectedValue.ToString(),
                    MaDichVu = cbxDichVu.SelectedValue.ToString(),
                    Ghichu = txtGhiChu.Text
                };

                lichhenService.Add(lichHen);
                MessageBox.Show("Lịch hẹn đã được thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Reload lại dữ liệu
            reloadDataCallback?.Invoke();
            this.Close();


        }

    }
}
