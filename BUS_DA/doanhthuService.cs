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
    public class doanhthuService
    {
        Model1 model1 = new Model1();   
        public List<DoanhThu> GetAll()
        {
            Model1 model1 = new Model1();
            return model1.DoanhThus.ToList();
        }
        public DoanhThu getByMaDoanhThu(string maDoanhThu)
        {
            return model1.DoanhThus.Where(d => d.MaDoanhThu == maDoanhThu).FirstOrDefault();
        }

        public bool checkMaDoanhThu(string maDoanhThu)
        {
            return model1.DoanhThus.Where(d => d.MaDoanhThu == maDoanhThu).FirstOrDefault() == null;
        }

        public void add(string maDoanhThu, string tenDichVu, decimal gia)
        {
            model1.DoanhThus.Add(new DoanhThu()
            {
                MaDoanhThu = maDoanhThu,
                Gia = gia,
                MaDichVu = tenDichVu,
                NgayHoaDon = DateTime.Now
            });
            model1.SaveChanges();
        }

        public void update(string maDoanhThu, string tenDichVu, decimal gia)
        {
            DoanhThu doanhThu = model1.DoanhThus.Where(d => d.MaDoanhThu == maDoanhThu).FirstOrDefault();
            doanhThu.Gia = gia;
            doanhThu.MaDichVu = tenDichVu;
            model1.DoanhThus.AddOrUpdate(doanhThu);
            model1.SaveChanges();
        }

        public void delete(string maDoanhThu)
        {
            DoanhThu doanhThu = model1.DoanhThus.Where(d => d.MaDoanhThu == maDoanhThu).FirstOrDefault();
            if (doanhThu != null)
            {
                model1.DoanhThus.Remove(doanhThu);
                model1.SaveChanges();
            }
        }
    }
}
