using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DA.Model1;

namespace BUS_DA
{
    public class HoadonService
    {
        private Model1 db = new Model1();

        // Lấy danh sách hóa đơn
        public List<HoaDon> GetAllHoaDon()
        {
            return db.HoaDons.ToList();
        }
        public void AddHoaDon(string maHoaDon, DateTime ngayLap, string maToa, string maBenhNhan, string maDichVu)
        {
            using (var db = new Model1())
            {
                try
                {
                    var newHoaDon = new HoaDon
                    {
                        MaHoaDon = maHoaDon,
                        ngaylap = ngayLap,
                        MaToa = string.IsNullOrEmpty(maToa) ? null : maToa, // Cho phép null nếu không có dịch vụ
                        MaBenhNhan = maBenhNhan,
                        MaDichVu = string.IsNullOrEmpty(maDichVu) ? null : maDichVu  // Cho phép null nếu không có dịch vụ
                    };

                    db.HoaDons.Add(newHoaDon);
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationError in ex.EntityValidationErrors)
                    {
                        foreach (var error in validationError.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {error.PropertyName} Error: {error.ErrorMessage}");
                        }
                    }

                    throw new Exception("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
                }
            }
        }


        
        // Phương thức lấy hóa đơn theo mã hóa đơn
        public HoaDon GetById(string maHoaDon)
        {
            return db.HoaDons.FirstOrDefault(h => h.MaHoaDon == maHoaDon);
        }
        // Sửa hóa đơn
        public void UpdateHoaDon(string maHoaDon, DateTime ngayLap, string maToa, string maBenhNhan, string maDichVu)
        {
            using (var db = new Model1())
            {
                try
                {
                    var hoaDon = db.HoaDons.FirstOrDefault(h => h.MaHoaDon == maHoaDon);
                    if (hoaDon != null)
                    {
                        hoaDon.ngaylap = ngayLap;
                        hoaDon.MaToa = string.IsNullOrEmpty(maToa) ? null : maToa;
                        hoaDon.MaBenhNhan = maBenhNhan;
                        hoaDon.MaDichVu = string.IsNullOrEmpty(maDichVu) ? null : maDichVu; ;

                        db.SaveChanges();
                    }
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationError in ex.EntityValidationErrors)
                    {
                        foreach (var error in validationError.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {error.PropertyName} Error: {error.ErrorMessage}");
                        }
                    }

                    throw new Exception("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
                }
            }
        }

        // Cờ để kiểm tra thao tác (Thêm hay Sửa)
        public bool IsAdding { get; set; } = true;
        // Kiểm tra mã hóa đơn đã tồn tại chưa
        public bool CheckMaHoaDon(string maHoaDon)
        {
            return db.HoaDons.Any(h => h.MaHoaDon == maHoaDon);
        }
        
        public HoaDon layTTHOADON(string maHoaDon)
        {
            return db.HoaDons.FirstOrDefault(h => h.MaHoaDon == maHoaDon);
        }
        // Lấy danh sách khách hàng
        public List<BenhNhan> GetAllKhachHang()
        {
            return db.BenhNhans.ToList();
        }

        public List<ToaThuoc> GetToaThuocByKhachHang(string maBenhNhan)
        {
            return db.ToaThuocs.Where(t => t.MaBenhNhan == maBenhNhan).ToList();
        }

        // Lấy danh sách dịch vụ
        public List<DichVu> GetAllDichVu()
        {
            return db.DichVus.ToList();
        }
        // Xóa hóa đơn
        public void DeleteHoaDon(string maHoaDon)
        {
            try
            {
                // Tìm hóa đơn theo mã
                var hoaDon = db.HoaDons.FirstOrDefault(h => h.MaHoaDon == maHoaDon);

                if (hoaDon != null)
                {
                    // Xóa hóa đơn khỏi cơ sở dữ liệu
                    db.HoaDons.Remove(hoaDon);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Hóa đơn không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa hóa đơn: {ex.Message}");
            }
        }

    }
}
