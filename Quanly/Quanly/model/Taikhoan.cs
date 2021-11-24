using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanly.model
{
    public class Taikhoan
    {
        private int id;
        private string hoten;
        private DateTime ngaysinh;
        private string diachi;
        private string email;
        private string username;
        private string password;
        private int quyen;
        private int trangthai;

        public int Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public int Quyen { get => quyen; set => quyen = value; }
    }
}
