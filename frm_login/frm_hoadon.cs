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
using static System.Net.Mime.MediaTypeNames;

namespace frm_login
{

    public partial class frm_hoadon : Form
    {
        private int temp;
        public frm_hoadon()
        {
            InitializeComponent();
        }
        private HoadonService hoadonService = new HoadonService();
        private string maHoaDon;

        private void frm_hoadon_Load(object sender, EventArgs e)
        {
           LoadHoaDonData();
            temp = count();
            lbl_soluonghd.Text = $"{ temp}";
        }
        public int count()
        {
            temp = dta_hoadon.Rows.Count;

            if (dta_hoadon.AllowUserToAddRows)
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
        // Hàm load dữ liệu hóa đơn
        private void LoadHoaDonData()
        {
            try
            {
                using (var db = new Model1())
                {
                    dta_hoadon.AutoGenerateColumns = false;

                    // Truy vấn LINQ với các phép nối (join)
                    var hoaDonData = (from hd in db.HoaDons
                                      join toath in db.ToaThuocs on hd.MaToa equals toath.MaToa into toathJoin
                                      from toath in toathJoin.DefaultIfEmpty() // Xử lý khi ToaThuoc là null
                                      join thuoc in db.Thuoc_ on toath.MaThuoc equals thuoc.MaThuoc into thuocJoin
                                      from thuoc in thuocJoin.DefaultIfEmpty() // Xử lý khi Thuoc là null
                                      join bn in db.BenhNhans on hd.MaBenhNhan equals bn.MaBenhNhan
                                      join dv in db.DichVus on hd.MaDichVu equals dv.MaDichVu into dvJoin
                                      from dv in dvJoin.DefaultIfEmpty() // Xử lý khi DichVu là null
                                      select new
                                      {
                                          MaHoaDon = hd.MaHoaDon,
                                          NgayLap = hd.ngaylap,
                                          TenBenhNhan = bn.TenBenhNhan,
                                          TenDichVu = dv != null ? dv.TenDichVu : "Không có dịch vụ",
                                          GiaDV = dv != null ? (dv.GiaDV ?? 0) : 0,
                                          TenThuoc = toath != null && thuoc != null ? thuoc.TenThuoc : "Không có thuốc",
                                          GiaThuoc = (toath != null && thuoc != null) ? (thuoc.GiaThuoc ?? 0) * (toath.soluong ?? 0) : 0
                                      }).ToList();

                    // Kiểm tra nếu không có dữ liệu nào
                    if (hoaDonData == null || hoaDonData.Count == 0)
                    {
                        MessageBox.Show("Không có hóa đơn để hiển thị.");
                        return;
                    }

                    // Gán dữ liệu vào DataGridView
                    dta_hoadon.DataSource = hoaDonData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu hóa đơn: {ex.Message}");
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddHoadon addHoadonForm = new AddHoadon();
            hoadonService.IsAdding = true;
            addHoadonForm.ShowDialog();
            LoadHoaDonData();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (dta_hoadon.SelectedRows.Count > 0)
            {
                string maHoaDon = dta_hoadon.SelectedRows[0].Cells["MaHoaDon"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa hóa đơn này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        HoadonService hoadonService = new HoadonService();
                        hoadonService.DeleteHoaDon(maHoaDon);

                        MessageBox.Show("Xóa hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu sau khi xóa
                        LoadHoaDonData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dta_hoadon.SelectedRows.Count > 0)
            {
                string maHoaDon_selected = dta_hoadon.SelectedRows[0].Cells["MaHoaDon"].Value.ToString();

                AddHoadon addHoadonForm = new AddHoadon();
                addHoadonForm.LoadHoaDonForEdit(maHoaDon_selected); 
                addHoadonForm.ShowDialog();
                LoadHoaDonData(); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_timhd_Click(object sender, EventArgs e)
        {
            string searchText = txt_timhd.Text.Trim().ToLower(); // Get the search text and convert it to lowercase

            SearchByBillName(searchText);
        }

            private void cbx_sorthoadon_SelectedIndexChanged(object sender, EventArgs e)
            {
                string sortOption = cbx_sorthoadon.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(sortOption)) return;

                using (var db = new Model1())
                {
                    var query = from hd in db.HoaDons
                                join toath in db.ToaThuocs on hd.MaToa equals toath.MaToa into toathGroup
                                from toath in toathGroup.DefaultIfEmpty() // Left join với ToaThuocs
                                join th in db.Thuoc_ on toath.MaThuoc equals th.MaThuoc into thuocGroup
                                from th in thuocGroup.DefaultIfEmpty() // Left join với Thuoc_
                                join dv in db.DichVus on hd.MaDichVu equals dv.MaDichVu into dvGroup
                                from dv in dvGroup.DefaultIfEmpty() // Left join với DichVus
                                join bn in db.BenhNhans on hd.MaBenhNhan equals bn.MaBenhNhan into bnGroup
                                from bn in bnGroup.DefaultIfEmpty() // Left join với BenhNhans
                                select new
                                {
                                    hd.MaHoaDon,
                                    TenBenhNhan = bn.TenBenhNhan,
                                    hd.ngaylap,
                                    TenDichVu = dv.TenDichVu,
                                    GiaDV = dv.GiaDV,
                                    TenThuoc = th.TenThuoc,
                                    GiaThuoc = th.GiaThuoc * toath.soluong ,// Tính tổng giá (số lượng * giá thuốc)
                                    TongTienHD = th.GiaThuoc * toath.soluong + dv.GiaDV 
                                };

                    // Sắp xếp theo lựa chọn của người dùng
                    if (sortOption == "Giá tăng dần")
                    {
                        query = query.OrderBy(tt => tt.TongTienHD); // Sắp xếp tăng dần theo tổng giá
                    }
                    else if (sortOption == "Giá giảm dần")
                    {
                        query = query.OrderByDescending(tt => tt.TongTienHD); // Sắp xếp giảm dần theo tổng giá
                    }

                    dta_hoadon.DataSource = query.ToList();
                }
            }
        private void SearchByBillName(string billName)
        {
            using (var db = new Model1())
            {
                if (string.IsNullOrEmpty(billName))
                {
                    LoadHoaDonData();  // Tải lại toàn bộ dữ liệu
                }
                else
                {
                    var query = (from hd in db.HoaDons
                                join toath in db.ToaThuocs on hd.MaToa equals toath.MaToa into toathGroup
                                from toath in toathGroup.DefaultIfEmpty() // Left join với ToaThuocs
                                join th in db.Thuoc_ on toath.MaThuoc equals th.MaThuoc into thuocGroup
                                from th in thuocGroup.DefaultIfEmpty() // Left join với Thuoc_
                                join dv in db.DichVus on hd.MaDichVu equals dv.MaDichVu into dvGroup
                                from dv in dvGroup.DefaultIfEmpty() // Left join với DichVus
                                join bn in db.BenhNhans on hd.MaBenhNhan equals bn.MaBenhNhan into bnGroup
                                from bn in bnGroup.DefaultIfEmpty() // Left join với BenhNhans
                                 where bn.TenBenhNhan.Contains(billName)
                                 select new
                                {
                                    hd.MaHoaDon,
                                    TenBenhNhan = bn.TenBenhNhan,
                                    hd.ngaylap,
                                    TenDichVu = dv.TenDichVu,
                                    GiaDV = dv.GiaDV,
                                    TenThuoc = th.TenThuoc,
                                    GiaThuoc = th.GiaThuoc * toath.soluong,// Tính tổng giá (số lượng * giá thuốc)
                                    TongTienHD = th.GiaThuoc * toath.soluong + dv.GiaDV
                                }).ToList();

                    // Hiển thị kết quả lên DataGridView
                    dta_hoadon.DataSource = null;
                    dta_hoadon.DataSource = query;
                }
            }
        }

        private void btn_taitep_Click(object sender, EventArgs e)
        {
            if (selectedBill != null)
            {
                // Mở form frmXuatHD và truyền đối tượng selectedBill vào
                frmXuatHD frmXuatHD = new frmXuatHD();
                frmXuatHD.SetBillDetails(selectedBill); // Phương thức này bạn sẽ cần phải tạo trong frmXuatHD
                frmXuatHD.ShowDialog();  // Hiển thị form
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xuất.");
            }
        }

        private TThoadon selectedBill = null;
        private void dta_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào dòng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ các cell trong dòng được click
                string maHoaDon = dta_hoadon.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                string ngayLap = dta_hoadon.Rows[e.RowIndex].Cells["NgayLap"].Value.ToString();
                string tenThuoc = dta_hoadon.Rows[e.RowIndex].Cells["TenThuoc"].Value.ToString();
                string tenBenhNhan = dta_hoadon.Rows[e.RowIndex].Cells["TenBenhNhan"].Value.ToString();
                string tenDichVu = dta_hoadon.Rows[e.RowIndex].Cells["TenDichVu"].Value.ToString();
                string giaDV = dta_hoadon.Rows[e.RowIndex].Cells["GiaDV"].Value.ToString();
                string giaThuoc = dta_hoadon.Rows[e.RowIndex].Cells["GiaThuoc"].Value.ToString();

                // Lưu thông tin dòng vào biến selectedBill
                selectedBill = new TThoadon
                {
                    MaHoaDon = maHoaDon,
                    NgayLap = ngayLap,
                    tenthuoc = tenThuoc,
                    tenbn = tenBenhNhan,
                    tendv = tenDichVu,
                    giadv = giaDV,
                    giathuoc = giaThuoc
                };
            }

        }
        
        private void dta_hoadon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dta_hoadon.Rows.Count > 0 && e.RowIndex >= 0
                && maHoaDon != dta_hoadon.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString())
            {
                maHoaDon = dta_hoadon.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
            }
            else if (dta_hoadon.Rows.Count <= 0 || e.RowIndex < 0)
            {
                maHoaDon = "";
            }
        }
    }


    }

