using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string TaiKhoan { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public string NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public int LoaiNV { get; set; }
        public string NgayVaoLam { get; set; }
        public DateTime DaXoa { get; set; }
    }
}
