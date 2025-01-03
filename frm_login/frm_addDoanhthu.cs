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

namespace frm_login
{
    public partial class frm_addDoanhthu : Form
    {
        bool isEdit;
        string maDoanhThu;
        doanhthuService doanhthuService = new doanhthuService();
        public frm_addDoanhthu(bool isEdit, string maDoanhThu = "")
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.maDoanhThu = maDoanhThu;
        }

        

        private void frm_addDoanhthu_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "Cập nhập doanh thu";
                txtMaDoanhThu.Enabled = false;
                txtMaDoanhThu.Text = maDoanhThu;
                //Load dich vu
                txtTenDichVu.Text = doanhthuService.getByMaDoanhThu(maDoanhThu).MaDichVu;
                txtGia.Text = doanhthuService.getByMaDoanhThu(maDoanhThu).Gia.ToString();
                txtTenDichVu.Focus();
                return;
            }
            this.Text = "Thêm doanh thu";
            txtMaDoanhThu.Enabled = true;
            txtMaDoanhThu.Text = "";
            txtTenDichVu.Text = "";
            txtGia.Text = "";
            txtMaDoanhThu.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaDoanhThu.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã doanh thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDoanhThu.Focus();
                return;
            }
            if (txtTenDichVu.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDichVu.Focus();
                return;
            }
            if (txtGia.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGia.Focus();
                return;
            }
            if (!decimal.TryParse(txtGia.Text, out _))
            {
                MessageBox.Show("Giá dịch vụ chỉ được nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGia.Focus();
                return;
            }
            if (!isEdit && !doanhthuService.checkMaDoanhThu(txtMaDoanhThu.Text))
            {
                MessageBox.Show("Mã doanh thu đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDoanhThu.Focus();
                return;
            }
            if (isEdit)
            {
                doanhthuService.update(txtMaDoanhThu.Text, txtTenDichVu.Text, decimal.Parse(txtGia.Text));
                MessageBox.Show("Cập nhập doanh thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            doanhthuService.add(txtMaDoanhThu.Text, txtTenDichVu.Text, decimal.Parse(txtGia.Text));
            MessageBox.Show("Thêm doanh thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
