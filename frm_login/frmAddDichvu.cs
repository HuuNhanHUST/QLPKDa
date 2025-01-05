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
    public partial class frmAddDichvu : Form
    {
        public frmAddDichvu()
        {
            InitializeComponent();
        }
        // Constructor để sửa dịch vụ (truyền giá trị vào)
        private dichvuService dichVuService = new dichvuService();
        public frmAddDichvu(string maDichVu, string tenDichVu, decimal giaDV) : this()
        {
            // Đặt lại chế độ thêm/sửa
            dichVuService.IsAdding = false;  // Đảm bảo rằng IsAdding là false khi sửa
            txt_madichvu.Text = maDichVu;
            txt_madichvu.Enabled = false;
            txt_tendichvu.Text = tenDichVu;
            txt_giadichvu.Text = giaDV.ToString();
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các textbox
                string maDichVu = txt_madichvu.Text;
                string tenDichVu = txt_tendichvu.Text;
                decimal giaDV;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maDichVu) || string.IsNullOrEmpty(tenDichVu) || !decimal.TryParse(txt_giadichvu.Text, out giaDV))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và đảm bảo giá trị hợp lệ.");
                    return;
                }

                // Tạo đối tượng dịch vụ
                var dichVu = new DAL_DA.Model1.DichVu
                {
                    MaDichVu = maDichVu,
                    TenDichVu = tenDichVu,
                    GiaDV = giaDV
                };

                // Kiểm tra xem là thêm hay sửa
                if (dichVuService.IsAdding)
                {
                    // Nếu đang thêm mới
                    dichVuService.AddDichVu(dichVu);
                    MessageBox.Show("Thêm dịch vụ thành công!");
                }
                else
                {
                    // Nếu đang sửa
                    // Disable việc sửa mã dịch vụ
                    txt_madichvu.Enabled = false;

                    // Lấy dịch vụ hiện có từ cơ sở dữ liệu
                    var existingDichVu = dichVuService.GetDichVuByMaDichVu(maDichVu);
                    if (existingDichVu != null)
                    {
                        // Chỉnh sửa thông tin dịch vụ
                        existingDichVu.TenDichVu = tenDichVu;
                        existingDichVu.GiaDV = giaDV;

                        // Cập nhật lại dịch vụ trong cơ sở dữ liệu
                        dichVuService.UpdateDichVu(existingDichVu);
                        MessageBox.Show("Sửa dịch vụ thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Dịch vụ không tồn tại.");
                        return;
                    }
                }

                // Đóng form sau khi lưu thành công
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dịch vụ: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void frmAddDichvu_Load(object sender, EventArgs e)
        {

        }

        private void controlbox_exit_Click(object sender, EventArgs e)
        {

        }
    }
}
