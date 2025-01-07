using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL_DA.Model1;

namespace BUS_DA
{
    public class lichhenService
    {
        Model1 model1 = new Model1();
        public List<LichHen> GetAll()
        {
            return model1.LichHens.ToList();
        }
        public LichHen getByMaLichHen(string maLichHen)
        {
            return model1.LichHens.Where(d => d.MaLichHen == maLichHen).FirstOrDefault();
        }

        public bool checkMaLichHen(string maLichHen)
        {
            return model1.LichHens.Where(d => d.MaLichHen == maLichHen).FirstOrDefault() == null;
        }

        public void Add(LichHen lichHen)
        {
            model1.LichHens.Add(lichHen); // Thêm đối tượng LichHen vào DbSet
            model1.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
        }

        // Phương thức để sửa cập nhật lịch hẹn
        public void Update(LichHen lichHen)
        {
            var existingLichHen = model1.LichHens
                .FirstOrDefault(lh => lh.MaLichHen == lichHen.MaLichHen); // Tìm kiếm bản ghi lịch hẹn theo mã

            if (existingLichHen != null)
            {
                // Cập nhật các trường cần thiết
                existingLichHen.NgayHenTT = lichHen.NgayHenTT;
                existingLichHen.NgayHenGN = lichHen.NgayHenGN;
                existingLichHen.MaBenhNhan = lichHen.MaBenhNhan;
                existingLichHen.MaDichVu = lichHen.MaDichVu;
                existingLichHen.Ghichu = lichHen.Ghichu;

                model1.SaveChanges(); // Lưu lại thay đổi vào cơ sở dữ liệu
            }
        }


        public void delete(string maLichHen)
        {
            LichHen lichHen = model1.LichHens.Where(d => d.MaLichHen == maLichHen).FirstOrDefault();
            if (lichHen != null)
            {
                model1.LichHens.Remove(lichHen);
                model1.SaveChanges();
            }
        }
    }
}
