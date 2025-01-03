using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using DAL_DA.Model1;
namespace BUS_DA
{
    public class benhnhanService
            {
       

    
            public List<BenhNhan> GetAll()
            {
               Model1 model1 = new Model1();
                return model1.BenhNhans.ToList();
            }

            public bool Add(BenhNhan benhNhan)
            {
                try
                {
                    using (Model1 model1 = new Model1())
                    {
                        model1.BenhNhans.Add(benhNhan);
                        model1.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi thêm bệnh nhân: {ex.Message}");
                    return false;
                }
            }

            // Sửa thông tin bệnh nhân
            public bool Update(BenhNhan benhNhan)
            {
                try
                {
                    using (Model1 model1 = new Model1())
                    {
                        var existing = model1.BenhNhans.Find(benhNhan.MaBenhNhan);
                        if (existing == null)
                            return false;

                        // Cập nhật thông tin bệnh nhân
                        existing.TenBenhNhan = benhNhan.TenBenhNhan;
                        existing.SoDienThoai = benhNhan.SoDienThoai;
                        existing.DiaChi = benhNhan.DiaChi;
                        existing.Avatar = benhNhan.Avatar;

                        model1.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi sửa bệnh nhân: {ex.Message}");
                    return false;
                }
            }

            // Xóa bệnh nhân
            public bool Delete(string id)
            {
            try
            {
                using (Model1 model1 = new Model1())
                {
                    // Kiểm tra bệnh nhân có tồn tại không
                    var benhNhan = model1.BenhNhans.Find(id);
                    if (benhNhan == null)
                    {
                        Console.WriteLine($"Lỗi khi xóa");
                        return false;
                    }

                    // Xóa bệnh nhân
                    model1.BenhNhans.Remove(benhNhan);
                    model1.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa: {ex.Message}");
                return false;
            }
        }
        // Tìm kiếm bệnh nhân theo mã
        public BenhNhan FindById(string id)
        {
            try
            {
                using (Model1 model1 = new Model1())
                {
                    return model1.BenhNhans.FirstOrDefault(bn => bn.MaBenhNhan == id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm bệnh nhân theo mã: {ex.Message}");
                return null;
            }
        }

        // Sắp xếp danh sách bệnh nhân theo tên
        public List<BenhNhan> SortByName()
        {
            try
            {
                using (Model1 model1 = new Model1())
                {
                    return model1.BenhNhans.OrderBy(bn => bn.TenBenhNhan).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi sắp xếp theo tên: {ex.Message}");
                return new List<BenhNhan>();
            }
        }

        // Sắp xếp danh sách bệnh nhân theo địa chỉ
        public List<BenhNhan> SortByAddress()
        {
            try
            {
                using (Model1 model1 = new Model1())
                {
                    return model1.BenhNhans.OrderBy(bn => bn.DiaChi).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi sắp xếp theo địa chỉ: {ex.Message}");
                return new List<BenhNhan>();
            }
        }
        public bool SaveToCsv(string filePath)
        {
            try
            {
                List<BenhNhan> benhNhans = GetAll();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Ghi tiêu đề cột
                    writer.WriteLine("MaBenhNhan,TenBenhNhan,SoDienThoai,DiaChi");

                    // Ghi từng dòng dữ liệu
                    foreach (var benhNhan in benhNhans)
                    {
                        writer.WriteLine($"{benhNhan.MaBenhNhan},{benhNhan.TenBenhNhan},{benhNhan.SoDienThoai},{benhNhan.DiaChi}");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu danh sách: {ex.Message}");
                return false;
            }
        }

    }
}
