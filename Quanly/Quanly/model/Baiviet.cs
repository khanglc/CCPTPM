using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanly.model
{
    public class Baiviet
    {
        private int idtin;
        private string tieude;
        private string hinh;
        private DateTime ngay;
        private int idUser;
        private string noidung;
        private int trangthai;

        public int Idtin { get => idtin; set => idtin = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Hinh { get => hinh; set => hinh = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
