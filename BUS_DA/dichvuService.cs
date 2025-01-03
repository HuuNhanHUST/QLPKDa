using System;
using System.Collections.Generic;
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
    }
}
