using System;
using System.Collections.Generic;
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

        public void add(string maLichHen, DateTime ngayHenTT, DateTime ngayHenGN, string maBenhNhan, string maDichVu, string ghiChu)
        {
            model1.LichHens.Add(new LichHen()
            {
                MaLichHen = maLichHen,
                NgayHenTT = ngayHenTT,
                NgayHenGN = ngayHenGN,
                MaBenhNhan = maBenhNhan,
                MaDichVu = maDichVu,
                Ghichu = ghiChu
            });
            model1.SaveChanges();
        }

        public void update(string maLichHen, DateTime ngayHenTT, DateTime ngayHenGN, string maBenhNhan, string maDichVu, string ghiChu)
        {
            LichHen lichHen = model1.LichHens.Where(d => d.MaLichHen == maLichHen).FirstOrDefault();
            lichHen.NgayHenTT = ngayHenTT;
            lichHen.NgayHenGN = ngayHenGN;
            lichHen.MaBenhNhan = maBenhNhan;
            lichHen.Ghichu = ghiChu;
            lichHen.MaDichVu = maDichVu;
            model1.LichHens.AddOrUpdate(lichHen);
            model1.SaveChanges();
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
