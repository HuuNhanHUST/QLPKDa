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
            cbxBenhNhan.DataSource = benhnhanService.GetAll();
            cbxBenhNhan.ValueMember = "MaBenhNhan";
            cbxBenhNhan.DisplayMember = "TenBenhNhan";

            // Kiểm tra lại cách nạp dữ liệu dịch vụ
            var dichVuList = dichvuService.GetAll();
            if (dichVuList == null || !dichVuList.Any())
            {
                MessageBox.Show("Không có dịch vụ nào trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cbxDichVu.DataSource = dichVuList;
            cbxDichVu.ValueMember = "MaDichVu";  
            cbxDichVu.DisplayMember = "TenDichVu";
            if (isEdit)
            {
                this.Text = "Cập nhập lịch hẹn";
                txtMaLichHen.Enabled = false;
                txtMaLichHen.Text = maLichHen;
                dateNgayHenTT.Value = lichhenService.getByMaLichHen(maLichHen).NgayHenTT.Value;
                dateNgayHenGN.Value = lichhenService.getByMaLichHen(maLichHen).NgayHenGN.Value;
                cbxBenhNhan.SelectedValue = lichhenService.getByMaLichHen(maLichHen).MaBenhNhan;
                cbxDichVu.SelectedValue = lichhenService.getByMaLichHen(maLichHen).MaDichVu;
                txtGhiChu.Text = lichhenService.getByMaLichHen(maLichHen).Ghichu;
                dateNgayHenTT.Focus();
                return;
            }
            this.Text = "Thêm lịch hẹn";
            txtMaLichHen.Enabled = true;
            txtMaLichHen.Text = "";
            dateNgayHenTT.Value = DateTime.Now;
            dateNgayHenGN.Value = DateTime.Now;
            cbxBenhNhan.SelectedIndex = 0;
            //cbxDichVu.SelectedIndex = 0;
            txtGhiChu.Text = "";
            txtMaLichHen.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new Model1()) // Model1 là DbContext của bạn
            {
                if (string.IsNullOrEmpty(txtMaLichHen.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã lịch hẹn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLichHen.Focus();
                    return;
                }

                if (!isEdit)
                {
                    // Kiểm tra mã lịch hẹn có tồn tại không
                    if (db.LichHens.Any(lh => lh.MaLichHen == txtMaLichHen.Text))
                    {
                        MessageBox.Show("Mã lịch hẹn đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLichHen.Focus();
                        return;
                    }

                    // Thêm mới lịch hẹn
                    var newLichHen = new LichHen
                    {
                        MaLichHen = txtMaLichHen.Text,
                        NgayHenTT = dateNgayHenTT.Value,
                        NgayHenGN = dateNgayHenGN.Value,
                        MaBenhNhan = cbxBenhNhan.SelectedValue.ToString(),
                       MaDichVu = cbxDichVu.SelectedValue.ToString(),
                        Ghichu = txtGhiChu.Text
                    };
                    db.LichHens.Add(newLichHen);
                }
                else
                {
                    // Sửa lịch hẹn
                    var existingLichHen = db.LichHens.FirstOrDefault(lh => lh.MaLichHen == maLichHen);
                    if (existingLichHen != null)
                    {
                        existingLichHen.NgayHenTT = dateNgayHenTT.Value;
                        existingLichHen.NgayHenGN = dateNgayHenGN.Value;
                        existingLichHen.MaBenhNhan = cbxBenhNhan.SelectedValue.ToString();
                        existingLichHen.MaDichVu = cbxDichVu.SelectedValue.ToString();
                        existingLichHen.Ghichu = txtGhiChu.Text;
                    }
                }

                // Lưu thay đổi
                db.SaveChanges();
                MessageBox.Show(isEdit ? "Cập nhật lịch hẹn thành công!" : "Thêm lịch hẹn thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadDataCallback?.Invoke(); // Gọi hàm callback để load lại dữ liệu
                // Đóng form
                this.Close();
            }
        }
    }
}
