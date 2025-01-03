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
using DAL_DA.Model1;

namespace frm_login
{
    public partial class frm_thuoc : Form
    {
        public frm_thuoc()
        {
            InitializeComponent();
        }

        private void dta_thuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     

        private void frm_thuoc_Load(object sender, EventArgs e)
        {
            
            LoadData();

        }

        private void LoadData()
        {
            using (var db = new Model1())
            {
                // Tạo các cột của DataGridView nếu chưa có
                dta_thuoc.AutoGenerateColumns = false;

                var data = (from tt in db.ToaThuocs
                            join hd in db.HoaDons on tt.MaHoaDon equals hd.MaHoaDon
                            join bn in db.BenhNhans on hd.MaBenhNhan equals bn.MaBenhNhan
                            join dv in db.DichVus on hd.MaDichVu equals dv.MaDichVu
                            join thuoc in db.Thuoc_ on tt.MaToa equals thuoc.MaToa
                            select new
                            {
                                tt.MaToa,
                                Avatar = bn.Avatar,  // Đảm bảo Avatar có dữ liệu
                                TenBenhNhan = bn.TenBenhNhan,
                                TenDichVu = dv.TenDichVu,
                                TenThuoc = thuoc.TenThuoc,
                                Price = thuoc.Gia * tt.SoLuong,  // Tính giá (Price * SoLuong)
                                 tt.LieuLuon,  // Đảm bảo có LieuLuong
                            }).ToList();
                // Gán dữ liệu vào DataGridView
                dta_thuoc.DataSource = data;

                // Sau khi gán dữ liệu vào DataGridView, xử lý hình ảnh (nếu có)
                ProcessAvatarImages();
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

    }
}
