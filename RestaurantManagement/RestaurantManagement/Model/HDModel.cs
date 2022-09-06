using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    class HDModel
    {
        public String maHD { get; set; }
        public String ngay { get; set; }     
        public String masothue { get; set; }
        public String hotenkh { get; set; }
        public int idnv { get; set; }
        public string hoTenNV { get; set; }
        public int trigia { get; set; }
        public int giaSauThue { get; set; }
        public string giaChu { get; set; }
        public List<CTDatMonModel> ctDatMonList { get; set; }
    }
}
