    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
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

        public partial class frm_lichhen : Form
        {
            string maLichHen;
            private readonly lichhenService lichhenService = new lichhenService();
        public frm_lichhen()
            {
                InitializeComponent();
        }

            private void dta_lichhen_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
            private void frm_lichhen_Load(object sender, EventArgs e)
            {
              LoadData();
                temp = count();
            lbl_soluonghd.Text = temp.ToString();
        }
        private int temp;
        public int count()
        {
            temp = dta_lichhen.Rows.Count;

            if (dta_lichhen.AllowUserToAddRows)
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
                    // Tắt tự động tạo cột nếu chưa làm
                    dta_lichhen.AutoGenerateColumns = false;

                    // Truy vấn dữ liệu từ cơ sở dữ liệu
                    var data = (from lh in db.LichHens
                        join bn in db.BenhNhans on lh.MaBenhNhan equals bn.MaBenhNhan
                        join dv in db.DichVus on lh.MaDichVu equals dv.MaDichVu
                        select new
                        {
                            lh.MaLichHen,
                            Avatar = bn.Avatar, // Hình ảnh
                            TenBenhNhan = bn.TenBenhNhan,
                            NgayHenTT = lh.NgayHenTT,
                            NgayHenGN = lh.NgayHenGN,
                            TenDichVu = dv.TenDichVu,
                            GhiChu = lh.Ghichu
                        }).ToList();

                    // Gán dữ liệu vào DataGridView
                    dta_lichhen.DataSource = null; // Xóa dữ liệu cũ
                    dta_lichhen.DataSource = data;

                    // Đặt tên cột DataPropertyName cho từng cột tương ứng
                    dta_lichhen.Columns["Column1"].DataPropertyName = "MaLichHen";
                    dta_lichhen.Columns["Column2"].DataPropertyName = "Avatar";
                    dta_lichhen.Columns["Column3"].DataPropertyName = "TenBenhNhan";
                    dta_lichhen.Columns["Column4"].DataPropertyName = "NgayHenTT";
                    dta_lichhen.Columns["Column5"].DataPropertyName = "NgayHenGN";
                    dta_lichhen.Columns["Column6"].DataPropertyName = "TenDichVu";
                    dta_lichhen.Columns["Column7"].DataPropertyName = "GhiChu";

                    // Xử lý hiển thị hình ảnh trong cột Avatar
                    ProcessAvatarImages();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ProcessAvatarImages()
        {
            // Xử lý hiển thị hình ảnh cho mỗi dòng
            foreach (DataGridViewRow row in dta_lichhen.Rows)
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
                            MessageBox.Show($"Lỗi khi xử lý hình ảnh cho MaLichHen {row.Cells["MaLichHen"].Value}: {ex.Message}",
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



        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_add_lichhen frm_Add_Edit_Lichhen = new frm_add_lichhen(false, reloadDataCallback: LoadData);
            frm_Add_Edit_Lichhen.ShowDialog();
        }

        private void dta_lichhen_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dta_lichhen.Rows.Count > 0 && e.RowIndex >= 0
                && maLichHen != dta_lichhen.Rows[e.RowIndex].Cells["Column1"].Value.ToString())
            {
                maLichHen = dta_lichhen.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            }
            else if (dta_lichhen.Rows.Count <= 0 || e.RowIndex < 0)
            {
                maLichHen = "";
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (maLichHen == "")
            {
                MessageBox.Show("Chưa chọn lịch hẹn", "Thông báo");
                return;
            }
            frm_add_lichhen frm_Add_Edit_Lichhen = new frm_add_lichhen(true, maLichHen, LoadData);
            frm_Add_Edit_Lichhen.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (maLichHen == "")
            {
                MessageBox.Show("Chưa chọn lịch hẹn", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                lichhenService.delete(maLichHen);
                MessageBox.Show("xóa lịch hẹn thành công", "Thông báo");
                LoadData();
            }
        }
    }
    }
