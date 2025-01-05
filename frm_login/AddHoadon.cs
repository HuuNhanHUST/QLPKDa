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
    public partial class AddHoadon : Form
    {
        private HoadonService hoadonService = new HoadonService();
        public AddHoadon()
        {
            InitializeComponent();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string maHoaDon = txt_mahd.Text.Trim();
            DateTime ngayLap = dateNgaylap.Value;
            string maToa = cbx_toathuoc.SelectedValue?.ToString();
            string maBenhNhan = cbxBenhNhan.SelectedValue?.ToString();
            string maDichVu = cbxDichVu.SelectedValue?.ToString();  // Có thể null

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(maHoaDon) || string.IsNullOrEmpty(maBenhNhan))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin (trừ toa thuốc)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (hoadonService.IsAdding)
                {
                    // Thêm hóa đơn, có thể để null cho maDichVu
                    hoadonService.AddHoaDon(maHoaDon, ngayLap, string.IsNullOrEmpty(maToa) ? null : maToa, maBenhNhan, string.IsNullOrEmpty(maDichVu) ? null : maDichVu);
                    MessageBox.Show("Thêm hóa đơn thành công.");
                }
                else
                {
                    // Sửa hóa đơn
                    hoadonService.UpdateHoaDon(maHoaDon, ngayLap, string.IsNullOrEmpty(maToa) ? null : maToa, maBenhNhan, string.IsNullOrEmpty(maDichVu) ? null : maDichVu);
                    MessageBox.Show("Sửa hóa đơn thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }

       
        private void AddHoadon_Load(object sender, EventArgs e)
        {

            var khachHangList = hoadonService.GetAllKhachHang();
            cbxBenhNhan.DataSource = khachHangList;
            cbxBenhNhan.DisplayMember = "TenBenhNhan";
            cbxBenhNhan.ValueMember = "MaBenhNhan";
            cbxBenhNhan.SelectedIndex = -1;

            var dichVuList = hoadonService.GetAllDichVu();
            cbxDichVu.DataSource = dichVuList;
            cbxDichVu.DisplayMember = "TenDichVu";
            cbxDichVu.ValueMember = "MaDichVu";
            cbxDichVu.SelectedIndex = -1;

            cbx_toathuoc.Enabled = false; 
            

          
        }



        private void cbx_khachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBenhNhan.SelectedIndex != -1)
            {
                string maBenhNhan = cbxBenhNhan.SelectedValue?.ToString();

                if (!string.IsNullOrEmpty(maBenhNhan))
                {
                    var toaThuocList = hoadonService.GetToaThuocByKhachHang(maBenhNhan);

                    if (toaThuocList != null && toaThuocList.Count > 0)
                    {
                        cbx_toathuoc.DataSource = toaThuocList;
                        cbx_toathuoc.DisplayMember = "MaToa";
                        cbx_toathuoc.ValueMember = "MaToa";
                        cbx_toathuoc.Enabled = true;
                    }
                    else
                    {
                        cbx_toathuoc.DataSource = null;
                        cbx_toathuoc.Enabled = false;
                    }
                }
            }
            else
            {
                cbx_toathuoc.DataSource = null;
                cbx_toathuoc.Enabled = false;
            }

        }



        public void LoadHoaDonForEdit(string maHoaDon)
        {
            using (var db = new Model1())
            {
                var hoaDon = db.HoaDons.FirstOrDefault(h => h.MaHoaDon == maHoaDon);

                if (hoaDon != null)
                {
                    hoadonService.IsAdding = false;
                    txt_mahd.Text = hoaDon.MaHoaDon;
                    dateNgaylap.Value = hoaDon.ngaylap ?? DateTime.Now;

                    // Gán giá trị vào ComboBox
                    cbxBenhNhan.SelectedValue = hoaDon.MaBenhNhan;
                    cbxDichVu.SelectedValue = hoaDon.MaDichVu;
                    cbx_toathuoc.SelectedValue = hoaDon.MaToa;

                   
                    txt_mahd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }



    }



}

