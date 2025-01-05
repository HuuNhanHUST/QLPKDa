using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DA.Model1;

namespace BUS_DA
{
    public class dichvuService
    {
        public List<DichVu> GetAll()
        {
            Model1 model1 = new Model1();
            return model1.DichVus.ToList();
        }
        private Model1 dbContext = new Model1();  // Khởi tạo dbContext
        public bool IsAdding { get; set; } = true;
        // Method to add a new service
        public void AddDichVu(DichVu newDichVu)
        {
            try
            {
                using (var model1 = new Model1())
                {
                    model1.DichVus.Add(newDichVu);
                    model1.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm dịch vụ: " + ex.Message);
            }
        }

        public DAL_DA.Model1.DichVu GetDichVuByMaDichVu(string maDichVu)
        {
            try
            {
                var dichVu = dbContext.DichVus.FirstOrDefault(d => d.MaDichVu == maDichVu);
                return dichVu; 
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dịch vụ: " + ex.Message);
            }
        }

        // Method to update a service
        public void UpdateDichVu(DichVu updatedDichVu)
        {
            using (var db = new Model1())
            {
                var existingDichVu = db.DichVus.FirstOrDefault(dv => dv.MaDichVu == updatedDichVu.MaDichVu);
                if (existingDichVu != null)
                {
                    existingDichVu.TenDichVu = updatedDichVu.TenDichVu;
                    existingDichVu.GiaDV = updatedDichVu.GiaDV;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Dịch vụ không tồn tại.");
                }
            }
        }

        // Method to delete a service
        public void DeleteDichVu(string maDichVu)
        {
            try
            {
                using (var model1 = new Model1())
                {
                    var dichVu = model1.DichVus.FirstOrDefault(dv => dv.MaDichVu == maDichVu);
                    if (dichVu != null)
                    {
                        model1.DichVus.Remove(dichVu);
                        model1.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Dịch vụ không tồn tại.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa dịch vụ: " + ex.Message);
            }
        }

        // Method to search for services by name
        public List<DichVu> SearchDichVuByName(string name)
        {
            try
            {
                using (var model1 = new Model1())
                {
                    return model1.DichVus
                                  .Where(dv => dv.TenDichVu.Contains(name))
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm dịch vụ: " + ex.Message);
            }
        }

        // Method to sort services by price (ascending or descending)
        public List<DichVu> SortDichVuByPrice(bool ascending = true)
        {
            try
            {
                using (var model1 = new Model1())
                {
                    if (ascending)
                    {
                        return model1.DichVus.OrderBy(dv => dv.GiaDV).ToList();
                    }
                    else
                    {
                        return model1.DichVus.OrderByDescending(dv => dv.GiaDV).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sắp xếp dịch vụ theo giá: " + ex.Message);
            }
        }
    


}
}
