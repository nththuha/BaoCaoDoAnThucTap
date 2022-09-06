using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    class PhieuDatModel
    {
        public int idPD { get; set; }
        public String ngay { get; set; }
        public int idnv { get; set; }
        public string hoTenNV { get; set; }
        public String maBan { get; set; }
        public String tenBan { get; set; }
        public String maPhong { get; set; }
        public String tenPhong { get; set; }
    }
}
