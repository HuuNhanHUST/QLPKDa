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
    public class thuocService
    {
        Model1 model1 = new Model1();
        public List<Thuoc_> GetAll()
        {
           
            return model1.Thuoc_.ToList();
        }
        // Lấy toa thuốc theo mã

        public ToaThuoc getByMaToa(string matoa)
        {
            return model1.ToaThuocs.Where(d => d.MaToa == matoa).FirstOrDefault();
        }
        // Thêm hoặc sửa thuốc
        public void AddOrUpdate(Thuoc_ thuoc)
        {
            var existingThuoc = model1.Thuoc_.FirstOrDefault(t => t.MaThuoc == thuoc.MaThuoc);
            if (existingThuoc != null)
            {
                // Cập nhật thông tin nếu thuốc đã tồn tại
                existingThuoc.TenThuoc = thuoc.TenThuoc;
                existingThuoc.GiaThuoc = thuoc.GiaThuoc;
                model1.SaveChanges();
            }
            else
            {
                // Thêm mới nếu thuốc chưa tồn tại
                model1.Thuoc_.Add(thuoc);
                model1.SaveChanges();
            }
        }

        // Xóa thuốc theo mã thuốc
        public bool Delete(string maThuoc)
        {
            try
            {
                using (var db = new Model1())
                {
                    // Tìm thuốc dựa trên mã thuốc (maThuoc)
                    var thuocToDelete = db.ToaThuocs.FirstOrDefault(t => t.MaToa == maThuoc);

                    // Kiểm tra nếu tìm thấy thuốc
                    if (thuocToDelete != null)
                    {
                        // Xóa thuốc khỏi cơ sở dữ liệu
                        db.ToaThuocs.Remove(thuocToDelete);
                        db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                        return true; // Trả về true nếu xóa thành công
                    }
                    else
                    {
                        return false; // Không tìm thấy thuốc
                    }
                }
            }
            catch (Exception ex)
            {
              
                return false; // Trả về false nếu có lỗi
            }
                        }



      
        }





    }

       

