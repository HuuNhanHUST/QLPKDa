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
using System.Data.Entity; // Đảm bảo bạn đã thêm namespace này

namespace frm_login
{
    public partial class frm_doanhthu : Form
    {
        string maDoanhThu;
        public frm_doanhthu()
        {
            InitializeComponent();
        }

        private void frm_doanhthu_Load(object sender, EventArgs e)
        { // Đảm bảo tệp RDLC được chỉ định đúng
            reportViewer1.LocalReport.ReportPath = @"Report1.rdlc"; // Chỉ định đường dẫn đúng tới tệp RDLC

            // Lấy dữ liệu báo cáo
            var baoCao = GenerateBaoCaoDoanhThu();

            // Kiểm tra dữ liệu có sẵn không
            if (baoCao.Any())
            {
                // Gán nguồn dữ liệu
                reportViewer1.LocalReport.DataSources.Clear();
                var reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", baoCao);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu báo cáo để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private List<baoCaoDoanhThu> GenerateBaoCaoDoanhThu()
        {
            using (var db = new Model1())
            {
                var baoCao = db.HoaDons
                    .Where(hd => hd.ngaylap.HasValue) // Chỉ lấy các hóa đơn có ngày lập
                    .GroupBy(hd => DbFunctions.TruncateTime(hd.ngaylap.Value)) // TruncateTime loại bỏ giờ, phút, giây
                    .Select(g => new baoCaoDoanhThu
                    {
                        Ngay = g.Key.Value, // Trả về ngày đã được loại bỏ giờ

                        TongTienDichVu = g.Sum(hd =>
                            db.DichVus
                                .Where(dv => dv.MaDichVu == hd.MaDichVu)
                                .Select(dv => dv.GiaDV ?? 0) // Lấy giá dịch vụ
                                .FirstOrDefault()),

                        TongTienThuoc = g.Sum(hd =>
                            db.ToaThuocs
                                .Where(tt => tt.MaToa == hd.MaToa)
                                .Select(tt =>
                                    db.Thuoc_
                                        .Where(t => t.MaThuoc == tt.MaThuoc)
                                        .Select(t => (t.GiaThuoc ?? 0) * tt.soluong) // Tính tổng tiền thuốc
                                        .FirstOrDefault())
                                .Sum() ?? 0) // Sử dụng `?? 0` để tránh null và tính tổng
                    })
                    .ToList();

                return baoCao;
            }
        }
        }



    }


