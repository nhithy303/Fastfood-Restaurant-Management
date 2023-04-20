using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThucDon
    {
        public int MaMon { get; set; }
        public string MaLoai { get; set; }
        public string TenMon { get; set; }
        public string AnhMon { get; set; }
        public int GiaGoc { get; set; }
        public int GiaBan { get; set; }
        public int GiaDaGiam { get; set; }
        public DateTime DaXoa { get; set; }
    }
}
