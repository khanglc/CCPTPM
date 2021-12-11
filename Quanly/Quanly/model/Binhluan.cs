using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanly.model
{
    public class Binhluan
    {
        private int id;
        private int idtaikhoan;
        private int trangthai;

        public int Id { get => id; set => id = value; }
        public int Idtaikhoan { get => idtaikhoan; set => idtaikhoan = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
