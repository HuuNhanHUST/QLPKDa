using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DA
{
    public class BenhnhanDTO
    {
        public string MaBenhNhan { get; set; }  // Mã bệnh nhân
        public string TenBenhNhan { get; set; } // Tên bệnh nhân
        public string SoDienThoai { get; set; } // Số điện thoại
        public string DiaChi { get; set; }      // Địa chỉ
        public byte[] Avatar { get; set; }
    }
}
