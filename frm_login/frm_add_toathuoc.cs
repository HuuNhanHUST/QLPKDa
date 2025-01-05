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
    public partial class frm_add_toathuoc : Form
    {
        public frm_add_toathuoc()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private Action reloadDataCallback;

        public frm_add_toathuoc(bool isEdit, string maThuoc = "", Action reloadDataCallback = null)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.maThuoc = maThuoc;
            this.reloadDataCallback = reloadDataCallback;
            if (isEdit && !string.IsNullOrEmpty(maThuoc))
            {
                LoadToaThuocData();
            }
        }
        private void LoadToaThuocData()
        {
            using (var db = new Model1())
            {
                var toaThuoc = db.ToaThuocs.FirstOrDefault(t => t.MaToa == maThuoc);
                if (toaThuoc != null)
                {
                    txtMatoa.Text = toaThuoc.MaToa;
                    cbxBenhNhan.SelectedValue = toaThuoc.MaBenhNhan;
                    cbxThuoc.SelectedValue = toaThuoc.MaThuoc;
                    txt_soluong.Text = toaThuoc.soluong.ToString();

                    // Check if ngaylap is not null before setting
                    if (toaThuoc.ngaylap.HasValue)
                    {
                        dateNgayLap.Value = toaThuoc.ngaylap.Value;
                    }
                    else
                    {
                        dateNgayLap.Value = DateTime.Now; // Or set to a default date, e.g., today
                    }

                    txtGhiChu.Text = toaThuoc.LieuLuon;
                }
                else
                {
                    MessageBox.Show("Toa thuốc không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool isEdit;
        string maThuoc;
        thuocService thuocServices = new thuocService();
        benhnhanService benhnhanService = new benhnhanService();

        public frm_add_toathuoc(bool isEdit, string maLichHen = "")
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.maThuoc = maLichHen;
        }

        private void frm_add_toathuoc_Load(object sender, EventArgs e)
        {
            cbxBenhNhan.DataSource = benhnhanService.GetAll();
            cbxBenhNhan.ValueMember = "MaBenhNhan";
            cbxBenhNhan.DisplayMember = "TenBenhNhan";

            // Lấy danh sách thuốc từ thuocService
            var thuocList = thuocServices.GetAll();
            if (thuocList == null || thuocList.Count == 0)
            {
                MessageBox.Show("Không có thuốc nào trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Gán danh sách thuốc vào ComboBox
                cbxThuoc.DataSource = thuocList;
                cbxThuoc.ValueMember = "MaThuoc";
                cbxThuoc.DisplayMember = "TenThuoc";
            }
            //    if (isEdit)
            //    {
            //        LoadToaThuocData();
            //    }
            //}
            //private void LoadToaThuocData()
            //{
            //    var toaThuoc = thuocServices.getByMaThuoc(maThuoc);
            //    if (toaThuoc != null)
            //    {
            //        txtMatoa.Text = toaThuoc;
            //        cbxBenhNhan.SelectedValue = toaThuoc.MaBenhNhan;
            //        cbxThuoc.SelectedValue = toaThuoc.MaThuoc;
            //        txtGhiChu.Text = toaThuoc.GhiChu;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Toa thuốc không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrEmpty(txtMatoa.Text) ||
                    string.IsNullOrEmpty(cbxBenhNhan.Text) ||
                    string.IsNullOrEmpty(cbxThuoc.Text) ||
                    string.IsNullOrEmpty(txt_soluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    if (isEdit)
                    {
                        var existingToaThuoc = db.ToaThuocs.FirstOrDefault(t => t.MaToa == maThuoc);
                        if (existingToaThuoc != null)
                        {
                            existingToaThuoc.MaBenhNhan = cbxBenhNhan.SelectedValue.ToString();
                            existingToaThuoc.ngaylap = dateNgayLap.Value;
                            existingToaThuoc.LieuLuon = txtGhiChu.Text;
                            existingToaThuoc.MaThuoc = cbxThuoc.SelectedValue.ToString();
                            existingToaThuoc.soluong = int.Parse(txt_soluong.Text);

                            db.SaveChanges();
                            MessageBox.Show("Cập nhật toa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        var newToaThuoc = new ToaThuoc()
                        {
                            MaToa = txtMatoa.Text,
                            MaBenhNhan = cbxBenhNhan.SelectedValue.ToString(),
                            MaThuoc = cbxThuoc.SelectedValue.ToString(),
                            soluong = int.Parse(txt_soluong.Text),
                            ngaylap = dateNgayLap.Value,
                            LieuLuon = txtGhiChu.Text
                        };

                        db.ToaThuocs.Add(newToaThuoc);
                        db.SaveChanges();
                        MessageBox.Show("Thêm mới toa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reloadDataCallback?.Invoke(); // Gọi callback để làm mới dữ liệu

                    this.Close(); // Đóng form sau khi lưu thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        }
    }

}
